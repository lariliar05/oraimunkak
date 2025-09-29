using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _20231128_Gyak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1osszehas_Click(object sender, EventArgs e)
        {
            string elso = txb1szoveg.Text;
            string masodik = txb2szoveg.Text;

            if (elso.CompareTo(masodik) < 0)
            {
                MessageBox.Show("1. Szöveg hamarább van!");

            }
           else if (elso.CompareTo(masodik) > 0)
            {
                MessageBox.Show("2. Szöveg hamarabb van!");
            }
           else
            {
                MessageBox.Show("A Szövegek egyeznek");
            }
            



        }
        // Lenght = Hossza adott dolognak.
        private void btn1SzovegHossza_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Szöveg 1 Hossza: " + txb1szoveg.Text.Length);
        }

        private void btn1SzovegNagyb_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txb1szoveg.Text.ToUpper());
        }

        private void btn2SzovegHossza_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Szöveg 1 Hossza: " + txb2szoveg.Text.Length);
        }

        private void btn2SzovegKisbetu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txb2szoveg.Text.ToLower());
        }

        private void btn1karakvag_Click(object sender, EventArgs e)
        {
            try
            {
                int hanyadiktol = int.Parse(txb1hanyadik.Text);
                int mennyit = int.Parse(txb1karaktervag.Text);

                MessageBox.Show(txb1szoveg.Text.Substring(hanyadiktol - 1, mennyit));
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba!");
            }
        }

        private void btn2karakvag_Click(object sender, EventArgs e)
        {
            try
            {
                int hanyadiktol = int.Parse(txb2hanyadik.Text);
                int mennyit = int.Parse(txb2karaktervag.Text);

                MessageBox.Show(txb2szoveg.Text.Substring(hanyadiktol - 1, mennyit));
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba!");
            }

        }

        private void btn1kereses_Click(object sender, EventArgs e)
        {
            if (txb1szoveg.Text.Contains(txb1szovegkeres.Text))
            {
                MessageBox.Show("A", txb1szovegkeres.Text + " megtalálahtó a Szöveg 1-ben.");
            }

            else
            {
                MessageBox.Show("A", txb1szovegkeres.Text + " Nem található meg a Szöveg 2-ben");
            }
            
        }

        private void btn2kereses_Click(object sender, EventArgs e)
        {
            if (txb1szoveg.Text.Contains(txb2szovegkeres.Text))
            {
                MessageBox.Show("A", txb2szovegkeres.Text + " megtalálahtó a Szöveg 2-ben.");
            }
            else
            {
                MessageBox.Show("A", txb2szovegkeres.Text + " Nem található meg a Szöveg 2-ben");
            }
        }

        private void btnkilepes_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txb1szoveg_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //
        private void btnszovegbesz1_Click(object sender, EventArgs e)
        {
            try
            {
                string mit = txtbbeszur1.Text;
                int honnan = int.Parse(txtbhonnanszu1.Text);

                MessageBox.Show(txb1szoveg.Text.Insert(honnan - 1,mit));

            }
            catch (Exception)
            {
                MessageBox.Show("Hiba!");

            }

        }

        private void txtbbeszur1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbhonnanszu1_TextChanged(object sender, EventArgs e)
        {

        }
        //

        private void btnszovegbesz2_Click(object sender, EventArgs e)
        {
            try
            {
                string mit = txtbbeszur2.Text;
                int honnan = int.Parse(txtbhonnanszu2.Text);

                MessageBox.Show(txb2szoveg.Text.Insert(honnan - 1, mit));

            }
            catch (Exception)
            {
                MessageBox.Show("Hiba!");

            }

        }

        private void txtbbeszur2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbhonnanszu2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
