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
    public partial class FoxMsg : Form
    {
        Image PB_03 = Pro_02.Properties.Resources.BP_03;


        public FoxMsg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Event_Load(object sender, EventArgs e)
        {
            label1.Text = "你偶然遇到一隻好心的狐狸，體力得到飛躍性地提升";
            pictureBox1.Image = PB_03;
        }
    }
}
