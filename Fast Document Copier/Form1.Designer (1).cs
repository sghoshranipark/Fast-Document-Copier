namespace Fast_Document_Copier
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorySettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewDirectoryIfExistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keepScannedImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.a4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jPEGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(330, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 571);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Document Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "No. of Pages";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(15, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 51);
            this.panel1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(67, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(92, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "1";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Limited";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Unlimited";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 138);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Convert to PDF";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(15, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start Scanning";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Source";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Destination Folder : ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 271);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(309, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 26);
            this.button2.TabIndex = 10;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(15, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 214);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rotational Setup";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 86);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "Restore";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(228, 86);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Preview";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Fast_Document_Copier.Properties.Resources.MARKER;
            this.pictureBox2.Location = new System.Drawing.Point(90, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 178);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(228, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 50);
            this.button4.TabIndex = 15;
            this.button4.Text = "Rotate Right";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 50);
            this.button3.TabIndex = 14;
            this.button3.Text = "Rotate Left";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 592);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directorySettingsToolStripMenuItem,
            this.pDFSettingsToolStripMenuItem,
            this.pageSizeToolStripMenuItem,
            this.saveSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // directorySettingsToolStripMenuItem
            // 
            this.directorySettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewDirectoryIfExistsToolStripMenuItem});
            this.directorySettingsToolStripMenuItem.Name = "directorySettingsToolStripMenuItem";
            this.directorySettingsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.directorySettingsToolStripMenuItem.Text = "Directory Settings";
            // 
            // createNewDirectoryIfExistsToolStripMenuItem
            // 
            this.createNewDirectoryIfExistsToolStripMenuItem.Checked = true;
            this.createNewDirectoryIfExistsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.createNewDirectoryIfExistsToolStripMenuItem.Name = "createNewDirectoryIfExistsToolStripMenuItem";
            this.createNewDirectoryIfExistsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.createNewDirectoryIfExistsToolStripMenuItem.Text = "Create New Directory if Exists";
            // 
            // pDFSettingsToolStripMenuItem
            // 
            this.pDFSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keepScannedImageToolStripMenuItem});
            this.pDFSettingsToolStripMenuItem.Name = "pDFSettingsToolStripMenuItem";
            this.pDFSettingsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.pDFSettingsToolStripMenuItem.Text = "PDF Settings";
            // 
            // keepScannedImageToolStripMenuItem
            // 
            this.keepScannedImageToolStripMenuItem.Checked = true;
            this.keepScannedImageToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.keepScannedImageToolStripMenuItem.Name = "keepScannedImageToolStripMenuItem";
            this.keepScannedImageToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.keepScannedImageToolStripMenuItem.Text = "Keep Scanned Image";
            // 
            // pageSizeToolStripMenuItem
            // 
            this.pageSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.a4ToolStripMenuItem});
            this.pageSizeToolStripMenuItem.Name = "pageSizeToolStripMenuItem";
            this.pageSizeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.pageSizeToolStripMenuItem.Text = "Page Size";
            // 
            // a4ToolStripMenuItem
            // 
            this.a4ToolStripMenuItem.Checked = true;
            this.a4ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.a4ToolStripMenuItem.Name = "a4ToolStripMenuItem";
            this.a4ToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.a4ToolStripMenuItem.Text = "A4";
            // 
            // saveSettingsToolStripMenuItem
            // 
            this.saveSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jPEGToolStripMenuItem,
            this.pNGToolStripMenuItem,
            this.bMPToolStripMenuItem});
            this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
            this.saveSettingsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveSettingsToolStripMenuItem.Text = "Save Settings";
            // 
            // jPEGToolStripMenuItem
            // 
            this.jPEGToolStripMenuItem.Checked = true;
            this.jPEGToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.jPEGToolStripMenuItem.Name = "jPEGToolStripMenuItem";
            this.jPEGToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.jPEGToolStripMenuItem.Text = "JPEG";
            this.jPEGToolStripMenuItem.Click += new System.EventHandler(this.jPEGToolStripMenuItem_Click);
            // 
            // pNGToolStripMenuItem
            // 
            this.pNGToolStripMenuItem.Name = "pNGToolStripMenuItem";
            this.pNGToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.pNGToolStripMenuItem.Text = "PNG";
            this.pNGToolStripMenuItem.Click += new System.EventHandler(this.pNGToolStripMenuItem_Click);
            // 
            // bMPToolStripMenuItem
            // 
            this.bMPToolStripMenuItem.Name = "bMPToolStripMenuItem";
            this.bMPToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.bMPToolStripMenuItem.Text = "BMP";
            this.bMPToolStripMenuItem.Click += new System.EventHandler(this.bMPToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 616);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Fast Document Copier";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jPEGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem a4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keepScannedImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directorySettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewDirectoryIfExistsToolStripMenuItem;
    }
}

