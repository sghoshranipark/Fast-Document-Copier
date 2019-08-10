using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Fast_Document_Copier
{
    public partial class Form1 : Form
    {
        int currentRotation = 0;
        ArrayList arImage = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                textBox2.Enabled = true;
            else
                textBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            try
            {
                if (textBox1.Text.Length == 0)
                {
                    //get images from scanner
                    List<System.Drawing.Image> images = WIAScanner.Scan((string)comboBox1.SelectedItem);
                    foreach (System.Drawing.Image image in images)
                    {
                        pictureBox1.Image = image;
                        //save scanned image into specific folder
                        saveImage(image,textBox3.Text + "\\" + DateTime.Now.ToString("yyyy-MM-dd HHmmss"));
                        textBox1.Text = DateTime.Now.ToString("yyyy-MM-dd HHmmss");
                    }
                }
                else
                {
                    //If Document Name not Empty
                    if (radioButton1.Checked)
                    {
                        //For Unlimited Option
                        //For MultiScan
                        int temp = 0;
                        int count = 0;
                        String overHead = "";
                        if (Directory.Exists(textBox3.Text + "\\" + textBox1.Text))
                        {
                            while (Directory.Exists(textBox3.Text + "\\" + textBox1.Text + " (" + count + ")"))
                                count++;
                            Directory.CreateDirectory(textBox3.Text + "\\" + textBox1.Text + " (" + count + ")");
                            overHead = " ("+count+")";
                        }
                        else
                            Directory.CreateDirectory(textBox3.Text + "\\" + textBox1.Text);
                        String directorySavePath = textBox3.Text + "\\" + textBox1.Text + overHead + "\\";
                        while (true)
                        {
                            ConfirmingDialogBox cdb = new ConfirmingDialogBox();
                            cdb.currentpage = temp + 1;
                            cdb.maxpage = 0;
                            cdb.ShowDialog();
                            if (cdb.status == 1)
                            {
                                try
                                {
                                    List<System.Drawing.Image> images = WIAScanner.Scan((string)comboBox1.SelectedItem);
                                    foreach (System.Drawing.Image image in images)
                                    {
                                        rotate(image);
                                        pictureBox1.Image = image;
                                        //save scanned image into specific folder
                                        saveImage(image, directorySavePath + temp);
                                        temp++;
                                    }
                                }
                                catch(Exception e1)
                                {
                                    DialogResult dr=MessageBox.Show("Unfortunately, the software has encountered the following Error : "+e1.Message, "SCANNING ERROR", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                                    if (dr == DialogResult.Ignore)
                                        temp++;
                                    else if (dr == DialogResult.Abort)
                                        break;
                                }
                            }
                            else
                                break;
                        }
                    }
                    else if (int.Parse(textBox2.Text) > 0)
                    {
                        int n = int.Parse(textBox2.Text);
                        if (n == 1)
                        {
                            List<System.Drawing.Image> images = WIAScanner.Scan((string)comboBox1.SelectedItem);
                            foreach (System.Drawing.Image image in images)
                            {
                                pictureBox1.Image = image;
                                //save scanned image into specific folder
                                if (File.Exists(textBox3.Text + "\\" + textBox1.Text + ".jpeg"))
                                {
                                    int temp = 0;
                                    while (File.Exists(textBox3.Text + "\\" + textBox1.Text + " (" + temp + ").jpeg"))
                                        temp++;
                                    saveImage(image,textBox3.Text + "\\" + textBox1.Text + "(" + temp + ")");
                                }
                                else
                                    saveImage(image,textBox3.Text + "\\" + textBox1.Text + DateTime.Now.ToString("yyyy-MM-dd HHmmss"));
                            }
                        }
                        else
                        {
                            //For MultiScan
                            int temp = 0;
                            int count = 0;
                            String overHead = "";
                            if (Directory.Exists(textBox3.Text + "\\" + textBox1.Text))
                            {
                                while (Directory.Exists(textBox3.Text + "\\" + textBox1.Text + " (" + count + ")"))
                                    count++;
                                Directory.CreateDirectory(textBox3.Text + "\\" + textBox1.Text + " (" + count + ")");
                                overHead = " (" + count + ")";
                            }
                            else
                                Directory.CreateDirectory(textBox3.Text + "\\" + textBox1.Text);
                            String directorySavePath = textBox3.Text + "\\" + textBox1.Text + overHead + "\\";
                            for (int i = 0; i < int.Parse(textBox2.Text); i++)
                            {
                                ConfirmingDialogBox cdb = new ConfirmingDialogBox();
                                cdb.maxpage = int.Parse(textBox2.Text);
                                cdb.currentpage = i + 1;
                                cdb.ShowDialog();
                                if (cdb.status == 1)
                                {
                                    List<System.Drawing.Image> images = WIAScanner.Scan((string)comboBox1.SelectedItem);
                                    foreach (System.Drawing.Image image in images)
                                    {
                                        rotate(image);
                                        pictureBox1.Image = image;
                                        //save scanned image into specific folder
                                        saveImage(image,directorySavePath + temp );
                                        temp++;
                                    }
                                }
                                else
                                    break;
                            }
                        }
                    }
                    else
                        MessageBox.Show("Please enter the number of pages you wish to scan in the dedicated Textbox.", "PARAMETER MISSING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            pdfIfRequired();
            button1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //get list of devices available
                List<string> devices = WIAScanner.GetDevices();
                foreach (string device in devices)
                {
                    comboBox1.Items.Add(device);
                }
                //check if device is not available
                if (comboBox1.Items.Count == 0)
                {
                    MessageBox.Show("No Compatible WIA Device Found", "DEVICE UNPLUGGED",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    this.Close();
                }
                else
                    comboBox1.SelectedIndex = 0;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
                textBox3.Text = folderBrowserDialog1.SelectedPath;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private System.Drawing.Image rotate(System.Drawing.Image img)
        {
            switch(currentRotation)
            {
                case 1: img.RotateFlip(RotateFlipType.Rotate90FlipNone); break;
                case 2: img.RotateFlip(RotateFlipType.Rotate180FlipNone); break;
                case 3: img.RotateFlip(RotateFlipType.Rotate270FlipNone); break;
            }
            return img;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentRotation++;
            if (currentRotation > 3)
                currentRotation = 0;
            System.Drawing.Image temp = pictureBox2.Image;
            temp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox2.Image = temp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentRotation--;
            if (currentRotation < 0)
                currentRotation = 3;
            System.Drawing.Image temp = pictureBox2.Image;
            temp.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox2.Image = temp;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<System.Drawing.Image> images = WIAScanner.Scan((string)comboBox1.SelectedItem);
            foreach (System.Drawing.Image image in images)
            {
                pictureBox2.Image = rotate(image);
                pictureBox1.Image = image;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = rotate(Properties.Resources.MARKER);
        }

        void disableAll()
        {
            jPEGToolStripMenuItem.Checked = false;
            pNGToolStripMenuItem.Checked = false;
        }
        void saveImage(System.Drawing.Image image,String fileName)
        {
            if (checkBox1.Checked)
            {
                arImage.Add(fileName);
            }
            if (jPEGToolStripMenuItem.Checked)
                image.Save(fileName + ".jpeg", ImageFormat.Jpeg);
            else if (pNGToolStripMenuItem.Checked)
                image.Save(fileName + ".png", ImageFormat.Png);
            else if (bMPToolStripMenuItem.Checked)
                image.Save(fileName + ".bmp", ImageFormat.Bmp);
                
        }
        private void jPEGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            disableAll();
            jPEGToolStripMenuItem.Checked = true;
        }

        private void pNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            disableAll();
            pNGToolStripMenuItem.Checked = true;
        }

        private void bMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            disableAll();
            bMPToolStripMenuItem.Checked = true;
        }
        void pdfIfRequired()
        {
            //Work left
            Object[] arr = arImage.ToArray();
            int l=arr.Length;
            if (l > 0)
            {
                Document doc = new Document(PageSize.A4,0,0,0,0);
                try
                {
                    String filePath = textBox3.Text + "\\" + textBox1.Text;
                    if (File.Exists(filePath + ".pdf"))
                    {
                        int temp = 0;
                        while (File.Exists(textBox3.Text + "\\" + textBox1.Text + " (" + temp + ").pdf"))
                            temp++;
                        filePath += "(" + temp + ")";
                    }
                    PdfWriter.GetInstance(doc, new FileStream(filePath+".pdf", FileMode.Create));
                    doc.Open();
                    if(currentRotation!=0 && currentRotation!=2)
                        doc.SetPageSize(iTextSharp.text.PageSize.A4.Rotate());
                    for (int i = 0; i < l; i++)
                    {
                        String imageURL = (String)arr[i];
                        if (jPEGToolStripMenuItem.Checked)
                            imageURL+=".jpeg";
                        else if (pNGToolStripMenuItem.Checked)
                            imageURL += ".png";
                        else if (bMPToolStripMenuItem.Checked)
                            imageURL += ".bmp";
                        iTextSharp.text.Image store = iTextSharp.text.Image.GetInstance(imageURL);
                        store.ScaleToFit(PageSize.A4.Width, PageSize.A4.Height);
                        doc.Add(store);
                        doc.NewPage();
                    }
                }
                catch (Exception ex)
                {
                    //Log error;
                }
                finally
                {
                    doc.Close();
                }
            }
            arImage = new ArrayList();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            //Clear on Right Click
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            //Shrink grow filter to the needs
        }
    }
}
