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
    public partial class LionMsg : Form
    {
        Image PB_09 = Pro_02.Properties.Resources.BP_09;


        public LionMsg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Event_Load(object sender, EventArgs e)
        {
            label1.Text = "你不幸地被一隻兇猛的獅子發現，逃跑時耗費大量地體力";
            pictureBox1.Image = PB_09;
        }
    }
}
