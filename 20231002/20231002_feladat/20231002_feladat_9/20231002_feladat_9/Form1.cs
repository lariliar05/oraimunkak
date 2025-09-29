using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20231002_feladat_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string clipboardText = Clipboard.GetText();
            lsb1.Items.Add(clipboardText);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txb1.Text);
            txb1.Clear();
        }

        private void lsb1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
