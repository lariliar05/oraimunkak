using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20231002_Feladat
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

        private void button1_Click(object sender, EventArgs e)
        {
            string inputtext = txb1.Text;
            string[] szamokSzoveg = inputtext.Split(' ');
            List<int> szamok = new List<int>();

            foreach (string szamSzo in szamokSzoveg)
            {
                if (int.TryParse(szamSzo, out int szam))
                {
                    szamok.Add(szam);
                }
            }
            szamok.Sort();

            lb1.Items.Clear();
            foreach (int szam in szamok)
            {
                lb1.Items.Add(szam);
            }

        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
