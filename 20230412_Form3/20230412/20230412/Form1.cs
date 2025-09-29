using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230412
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnszamol_Click(object sender, EventArgs e)
        {
            if (txtoldal.Text != "")
            {
                int a = int.Parse(txtoldal.Text);
                int k = 4 * a;
                int t = a * a;
                lblterulet.Text = "A négyzet kerülete" + k;
                lblkerulet.Text = "A négyzet kerülete" + t;
                lblkerulet.Visible = true;
                lblterulet.Visible = true;
            }
            else
            {
                MessageBox.Show("Nem adtad meg a négyzet oldalát!");
            }
        }

        private void btntorles_Click(object sender, EventArgs e)
        {
            txtoldal.Text = "";
            lblkerulet.Visible = false;
            lblterulet.Visible = true;

        }
    }
}
