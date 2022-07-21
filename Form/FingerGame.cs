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
    public partial class FingerGame : Form
    {
        Image man = Pro_02.Properties.Resources.BP_11;
        Image S = Pro_02.Properties.Resources.S;
        Image R = Pro_02.Properties.Resources.R;
        Image P = Pro_02.Properties.Resources.P;
        Image Q = Pro_02.Properties.Resources.Q;

        public FingerGame()
        {
            InitializeComponent();
        }

        public void Event_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = man;
            pictureBox2.Image = Q;
            button1.BackgroundImage = S; 
            button2.BackgroundImage = R;
            button3.BackgroundImage = P;
            label1.Text = "三選一，是時候來場猜拳了";
            
        }

        private void Finger_Event(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int buttonTag = btn.TabIndex;

            Random r = new Random();
            int computer = r.Next(1, 4);
            int i = 0;

            //玩家剪刀
            if (buttonTag == 1)
            {
                if (computer == 1)
                {
                    pictureBox2.Image = S;
                    label2.Text = "雙方平手";
                }
                if (computer == 2)
                {
                    pictureBox2.Image = R;
                    label2.Text = "電腦獲勝";
                }
                if (computer == 3)
                {
                    pictureBox2.Image = P;
                    label2.Text = "玩家獲勝"; i = 1;
                }
            }

            if (buttonTag == 2)
            {
                if (computer == 1)
                {
                    pictureBox2.Image = S;
                    label2.Text = "玩家獲勝"; i = 1;
                }
                if (computer == 2)
                {
                    pictureBox2.Image = R;
                    label2.Text = "雙方平手";
                }
                if (computer == 3)
                {
                    pictureBox2.Image = P;
                    label2.Text = "電腦獲勝";
                }
            }

            if (buttonTag == 3)
            {
                if (computer == 1)
                {
                    pictureBox2.Image = S;
                    label2.Text = "電腦獲勝";
                }
                if (computer == 2)
                {
                    pictureBox2.Image = R;
                    label2.Text = "玩家獲勝"; i = 1;
                }
                if (computer == 3)
                {
                    pictureBox2.Image = P;
                    label2.Text = "雙方平手";
                }
            }

            if (i == 1)
            {
                MessageBox.Show("你居然贏了，這是送你的獎勵");
                DialogResult = DialogResult.Yes; this.Close();
            }

            if (i == 0)
            {
                MessageBox.Show("下次碰面時，在比吧");
                DialogResult = DialogResult.No; this.Close();
            }
        }
    }
}
