using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_02
{
    public partial class StoryMsg : Form
    {
        Image ev = Pro_02.Properties.Resources._event;
        Image wi = Pro_02.Properties.Resources.win;
        Image ru = Pro_02.Properties.Resources.run;

        public StoryMsg()
        {
            InitializeComponent();
            
        }

        private void Help_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = ru;
            pictureBox2.Image = ev;
            pictureBox3.Image = wi;
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
