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

namespace _20231009
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                string[] beolvas = File.ReadAllLines(openFileDialog1.FileName);
                foreach (var item in beolvas)
                {
                    lstBered1.Items.Add(item);
                }
            }
            if (lstBered1.Items.Count > 0)
            {
                btnSzam.Enabled = true;
            }
            else
            {
                btnSzam.Enabled = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstBered1.SelectedItems != null)
            {
                int a = lstBered1.SelectedIndex;
                int b = Convert.ToInt32(lstBered1.SelectedItems);
                lstBered1.Items[a] = (b + 1).ToString();


            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBered1.Items.Count > 0)
            {
                btnSzam.Enabled = true;
            }
            else
            {
                btnSzam.Enabled = false;
            }
        }

        private void btn2Kilep_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
