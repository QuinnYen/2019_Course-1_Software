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
    public partial class Menu : Form
    {
        Image MP = Pro_02.Properties.Resources.Menu;


        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = MP;
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            Map map = new Map(this);
            this.Hide();
            map.Show();
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否要離開遊戲？", "ლ(ﾟдﾟლ)", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
            else
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Visible == true) { this.listBox1.Visible = false; }
            else { this.listBox1.Visible = true; }
        }
    }
}
