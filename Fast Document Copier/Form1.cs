using System;
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

namespace Fast_Document_Copier
{
    public partial class Form1 : Form
    {
        int currentRotation = 0;
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
                    List<Image> images = WIAScanner.Scan((string)comboBox1.SelectedItem);
                    foreach (Image image in images)
                    {
                        pictureBox1.Image = image;
                        //save scanned image into specific folder
                        image.Save(textBox3.Text + "\\" + DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".jpeg", ImageFormat.Jpeg);
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
                        if (Directory.Exists(textBox3.Text + "\\" + textBox1.Text))
                        {
                            int count = 0;
                            while (Directory.Exists(textBox3.Text + "\\" + textBox1.Text + " (" + count + ")"))
                                count++;
                            Directory.CreateDirectory(textBox3.Text + "\\" + textBox1.Text + " (" + count + ")");
                        }
                        else
                            Directory.CreateDirectory(textBox3.Text + "\\" + textBox1.Text);
                        while (true)
                        {
                            ConfirmingDialogBox cdb = new ConfirmingDialogBox();
                            cdb.currentpage = temp + 1;
                            cdb.maxpage = 0;
                            cdb.ShowDialog();
                            if (cdb.status == 1)
                            {
                                List<Image> images = WIAScanner.Scan((string)comboBox1.SelectedItem);
                                foreach (Image image in images)
                                {
                                    rotate(image);
                                    pictureBox1.Image = image;
                                    //save scanned image into specific folder
                                    image.Save(textBox3.Text + "\\" + textBox1.Text + "\\" + temp + ".jpeg", ImageFormat.Jpeg);
                                    temp++;
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
                            List<Image> images = WIAScanner.Scan((string)comboBox1.SelectedItem);
                            foreach (Image image in images)
                            {
                                pictureBox1.Image = image;
                                //save scanned image into specific folder
                                if (File.Exists(textBox3.Text + "\\" + textBox1.Text + ".jpeg"))
                                {
                                    int temp = 0;
                                    while (File.Exists(textBox3.Text + "\\" + textBox1.Text + " (" + temp + ").jpeg"))
                                        temp++;
                                    image.Save(textBox3.Text + "\\" + textBox1.Text + "(" + temp + ").jpeg", ImageFormat.Jpeg);
                                }
                                else
                                    image.Save(textBox3.Text + "\\" + textBox1.Text + DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".jpeg", ImageFormat.Jpeg);
                            }
                        }
                        else
                        {
                            //For MultiScan
                            int temp = 0;
                            if (Directory.Exists(textBox3.Text + "\\" + textBox1.Text))
                            {
                                int count = 0;
                                while (Directory.Exists(textBox3.Text + "\\" + textBox1.Text + " (" + count + ")"))
                                    count++;
                                Directory.CreateDirectory(textBox3.Text + "\\" + textBox1.Text + " (" + count + ")");
                            }
                            else
                                Directory.CreateDirectory(textBox3.Text + "\\" + textBox1.Text);
                            for (int i = 0; i < int.Parse(textBox2.Text); i++)
                            {
                                ConfirmingDialogBox cdb = new ConfirmingDialogBox();
                                cdb.maxpage = int.Parse(textBox2.Text);
                                cdb.currentpage = i + 1;
                                cdb.ShowDialog();
                                if (cdb.status == 1)
                                {
                                    List<Image> images = WIAScanner.Scan((string)comboBox1.SelectedItem);
                                    foreach (Image image in images)
                                    {
                                        rotate(image);
                                        pictureBox1.Image = image;
                                        //save scanned image into specific folder
                                        image.Save(textBox3.Text + "\\" + textBox1.Text + "\\" + temp + ".jpeg", ImageFormat.Jpeg);
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
                    MessageBox.Show("You do not have any WIA devices.");
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

        private Image rotate(Image img)
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
            Image temp = pictureBox2.Image;
            temp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox2.Image = temp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentRotation--;
            if (currentRotation < 0)
                currentRotation = 3;
            Image temp = pictureBox2.Image;
            temp.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox2.Image = temp;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Image> images = WIAScanner.Scan((string)comboBox1.SelectedItem);
            foreach (Image image in images)
                pictureBox2.Image = rotate(image);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = rotate(Properties.Resources.MARKER);
        }
    }
}
