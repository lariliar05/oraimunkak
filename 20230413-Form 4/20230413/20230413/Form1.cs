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

namespace _20230413
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblkarakter.Text = "Karakterek száma:" + txtszoveg.Text.Length;
            lblszavak.Text = "Szavak száma:" + txtszoveg.Text.Trim().Split().Length;
            int mh = 0;
            int nagybetu = 0;
            string maganhangzok = "aáeéiíoóüűöőúu";
            foreach (var item in txtszoveg.Text)
            {
                if (maganhangzok.Contains(item.ToString().ToLower()))
                {
                    mh++;
                }
                if (char.IsUpper(item))
                {
                    nagybetu++;
                }
                
            }
            lblmaganhangzok.Text = mh.ToString();
            lblnagybetuk2.Text = nagybetu.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnkilepes_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnfont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                lblbetutipus.Font = fontDialog1.Font;
            }
        }

        private void btnszin_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog()== DialogResult.OK)
            {
                lblbetumeret.BackColor = colorDialog1.Color;
            }
        }

        private void btnmentes_Click(object sender, EventArgs e)
        {
            if (txtszoveg.Text!="")
            {
                if (saveFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, txtszoveg.Text);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnbeolvas_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                foreach (var item in File.ReadAllLines(openFileDialog1.FileName))
                {
                    lbxforras.Items.Add(item);
                }
            }
        }
    }
}
