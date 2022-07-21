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
    public partial class RedMsg : Form
    {
        Image PB_08 = Pro_02.Properties.Resources.BP_08;


        public RedMsg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        public void Event_Load(object sender, EventArgs e)
        {
            label1.Text = "你穿過了紅色小徑";
            pictureBox1.Image = PB_08;
            
        }
    }
}
