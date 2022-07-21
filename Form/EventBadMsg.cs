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
    public partial class EventBadMsg : Form
    {
        Image PB_02 = Pro_02.Properties.Resources.BP_02;


        public EventBadMsg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Event_Load(object sender, EventArgs e)
        {
            label1.Text = "你在森林裡不知做了啥，因此體力下降些許";
            pictureBox1.Image = PB_02;
        }
    }
}
