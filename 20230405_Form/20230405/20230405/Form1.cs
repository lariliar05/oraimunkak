using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230405
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            btnGreen.BackColor = Color.White;
            btnGreen.ForeColor = Color.Green;
            btnRed.BackColor = Color.Red;
            btnRed.ForeColor = Color.White;
            btnBlue.BackColor = Color.Blue;
            btnBlue.ForeColor = Color.White;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            btnRed.BackColor = Color.White;
            btnRed.ForeColor = Color.Red;
            btnGreen.BackColor = Color.Green;
            btnGreen.ForeColor = Color.White;
            btnBlue.BackColor = Color.Blue;
            btnBlue.ForeColor = Color.White;

        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            btnBlue.BackColor = Color.White;
            btnBlue.ForeColor = Color.Blue;
            btnRed.BackColor = Color.Red;
            btnRed.ForeColor = Color.White;
            btnGreen.BackColor = Color.Green;
            btnGreen.ForeColor = Color.White;
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
