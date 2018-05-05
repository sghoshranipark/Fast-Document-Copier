using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fast_Document_Copier
{
    public partial class ConfirmingDialogBox : Form
    {
        int stats=0;
        public ConfirmingDialogBox()
        {
            InitializeComponent();
        }
        public int status
        {
            get
            {
                return (stats);
            }
        }
        public int maxpage
        {
            set
            {
                int n = value;
                label5.Text = "" + n;
                if (n == 0)
                    label5.Text = "∞";
            }
        }
        public int currentpage
        {
            set
            {
                Size szold = label3.Size;
                label3.Text = "" + value;
                Size sznew = label3.Size;
                label4.Location = new Point(label4.Location.X + (sznew.Width - szold.Width), label4.Location.Y);
                label5.Location = new Point(label5.Location.X + (sznew.Width - szold.Width), label5.Location.Y);
            }
        }

        private void ConfirmingDialogBox_Load(object sender, EventArgs e)
        {
            button2.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stats = 1;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
