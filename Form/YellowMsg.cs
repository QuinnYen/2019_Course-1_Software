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
    public partial class YellowMsg : Form
    {
        Image PB_05 = Pro_02.Properties.Resources.BP_05;


        public YellowMsg()
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
            label1.Text = "你穿過了黃色小徑";
            pictureBox1.Image = PB_05;
            
        }
    }
}
