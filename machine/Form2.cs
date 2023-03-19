using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace machine
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            qr1.Visible = false;
            qr2.Visible = true;
            qr3.Visible = false;
            bnt1.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            qr1.Visible = true;
            qr3.Visible = false;
            qr2.Visible = false;
            bnt1.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            qr1.Visible = false;
            qr3.Visible = true;
            qr2.Visible = false;
            bnt1.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            qr1.Visible = false;
            qr3.Visible = false;
            qr2.Visible = false;
            bnt1.Visible = false;
        }

        private void bnt1_Click(object sender, EventArgs e)
        {
            this.Close();
            string message = "Hoan tat thanh toan";
            MessageBox.Show(message);

        }
    }
}
