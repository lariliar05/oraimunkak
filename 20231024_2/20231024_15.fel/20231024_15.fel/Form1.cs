using System;
using System.IO;
using System.Windows.Forms;

namespace _20231024_15.fel
{
    public partial class Form1 : Form
    {
        public Form1()
        {     
            InitializeComponent();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] beolvas = File.ReadAllLines(openFileDialog1.FileName);
                foreach (var item in beolvas)
                {
                    ltb1.Items.Add(item);

                }

            }
        }

        private void btn3tor_Click(object sender, EventArgs e)
        {
            ltb1.Items.Clear();
        }

        private void btn2cser_Click(object sender, EventArgs e)
        {
            if (ltb1.Items.Count < 2)
            {
                return;
            }
            int selectedindex = ltb1.SelectedIndex;
            if (selectedindex >= 0 && selectedindex < ltb1.Items.Count - 1)
            {
                object temp = ltb1.Items[selectedindex];
                ltb1.Items[selectedindex] = ltb1.Items[selectedindex + 1];
                ltb1.Items[selectedindex + 1] = temp;
                ltb1.SelectedIndex = selectedindex + 1;



            }


        }

        private void btn1Kilep_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
