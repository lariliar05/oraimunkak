using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kepkorbe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pic03_Click(object sender, EventArgs e)
        {

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            Image ki = pic01.Image;
            pic01.Image = pic02.Image;
            pic02.Image = pic03.Image;
            pic03.Image = pic04.Image;
            pic04.Image = pic05.Image;
            pic05.Image = pic06.Image;
            pic06.Image = pic07.Image;
            pic07.Image = pic08.Image;
            pic08.Image = ki;

        }
    }
}
