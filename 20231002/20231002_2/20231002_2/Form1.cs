using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20231002_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txb1.Text == "")
            {
                btn1szamol.Enabled = false;
            }
            else
            {
                btn1szamol.Enabled = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string[] darabok = txb1.Text.Trim().Split();
            List<int> szamok = new List<int>();
            try
            {
                foreach (var item in darabok)
                {
                    szamok.Add(int.Parse(item));
                }
            .items.Add(txb1.Text.Trim(+$" átlag : {szamok.Average(:.80)}");
            }
            catch (Exception)
            {

                throw;
            }

            txb1.Clear();

        }
    }
}
