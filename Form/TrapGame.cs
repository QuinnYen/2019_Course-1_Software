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
    public partial class TrapGame : Form
    {
        Image trap = Pro_02.Properties.Resources.BP_12;
        Random ram = new Random();
        int tmp;
        int i = 4;

        public TrapGame()
        {
            InitializeComponent();
        }

        public void Event_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = trap;
            label1.Text = "在5次內，猜中數字，即可獲得自由";
            label4.Text = "";
            tmp = ram.Next(1, 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string str = string.Empty;
                int input = int.Parse(str = textBox1.Text);
                if(i != 0)
                {
                    if (input > tmp)
                    {
                        label4.Text = "太高了";
                        button1.Text = "確認數字，剩餘" + i + "次";
                    }
                    if (input < tmp)
                    {
                        label4.Text = "太低了";
                        button1.Text = "確認數字，剩餘" + i + "次";
                    }
                    if (input == tmp)
                    {
                        label4.Text = "恭喜你，猜中了";
                        MessageBox.Show("你成功掙脫了陷阱", "甘拜下風");
                        DialogResult = DialogResult.Yes; this.Close();
                    }
                    --i;
                }
                else
                {
                    label4.Text = "失敗";
                    button1.Text = "剩餘" + i + "次"; button1.Enabled = false;
                    MessageBox.Show("看來你得花點時間在這", "停止一回合");
                    DialogResult = DialogResult.No; this.Close();
                }
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("請輸入值");
            }
        }
    }
}
