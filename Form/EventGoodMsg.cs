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
    public partial class EventGoodMsg : Form
    {
        Image PB_01 = Pro_02.Properties.Resources.BP_01;


        public EventGoodMsg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Event_Load(object sender, EventArgs e)
        {
            label1.Text = "你在森林裡發現了一些東西，因此體力得到上升";
            pictureBox1.Image = PB_01;
        }
    }
}
