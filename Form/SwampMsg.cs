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
    public partial class SwampMsg : Form
    {
        Image PB_04 = Pro_02.Properties.Resources.BP_04;


        public SwampMsg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Event_Load(object sender, EventArgs e)
        {
            label1.Text = "你花了一點時間終於離開，得加緊腳步才行";
            pictureBox1.Image = PB_04;
        }
    }
}
