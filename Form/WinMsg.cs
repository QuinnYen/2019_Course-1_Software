using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Pro_02
{
    public partial class WinMsg : Form
    {
        Image PB_10 = Pro_02.Properties.Resources.BP_10;
        


        public WinMsg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        public void Event_Load(object sender, EventArgs e)
        {
            label1.Text = "你獲得了農場主人的青睞，恭喜贏得遊戲勝利";
            pictureBox1.Image = PB_10;
            SoundPlayer music = new SoundPlayer(Pro_02.Properties.Resources.win_party);
            Thread.Sleep(1000); music.Play();
        }
    }
}
