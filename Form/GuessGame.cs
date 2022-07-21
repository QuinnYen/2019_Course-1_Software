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
    public partial class GuessGame : Form
    {
        Image monkey = Pro_02.Properties.Resources.Monkey;
        int correctAnswer = 0;
        int score = 0;
        int i = 1;

        public GuessGame()
        {
            InitializeComponent();
            Rm();
        }

        public void Event_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = monkey;
            label1.Text = "回答四個問題，猴子說道";
        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int buttonTag = btn.TabIndex;

            if (buttonTag == correctAnswer) { score++; }
            if (i == 4 && score >= 3)
            {
                MessageBox.Show("你得到猴子的尊重", "智者的餽贈");
                label1.Text = score.ToString();
                DialogResult = DialogResult.Yes; this.Close();
                askQuestion(0);
            }
            if (i == 4 && score < 3)
            {
                MessageBox.Show("猴子朝你扔了根香蕉", "愚者的拜北");
                DialogResult = DialogResult.No; this.Close();
                askQuestion(0);
            }
            Rm();
            i++;
        }
        private void Rm()
        {
            Random ram = new Random();
            int[] E = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int n = ram.Next(E.Length - 1);
            int S = E[n];
            askQuestion(S);
        }

        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:
                    label2.Text = "猴子不喜歡什麽線？";

                    button1.Text = "平行線";
                    button2.Text = "交叉線";
                    button3.Text = "針織線";
                    button4.Text = "牽紅線";

                    correctAnswer = 1;
                    break;

                case 2:
                    label2.Text = "什麽動物最愛貼在牆上？";

                    button1.Text = "海獅";
                    button2.Text = "海豹";
                    button3.Text = "海豚";
                    button4.Text = "海象";

                    correctAnswer = 2;
                    break;
                case 3:

                    label2.Text = "透明的劍是什麽劍？";

                    button1.Text = "中國劍";
                    button2.Text = "希臘劍";
                    button3.Text = "屠龍劍";
                    button4.Text = "看不劍";

                    correctAnswer = 4;
                    break;

                case 4:
                    label2.Text = "甲、乙、丙、丁、戊、己、庚、辛，那一個字最酷？";

                    button1.Text = "甲";
                    button2.Text = "丙";
                    button3.Text = "丁";
                    button4.Text = "己";

                    correctAnswer = 3;
                    break;

                case 5:
                    label2.Text = "一顆心值多少錢？";

                    button1.Text = "一億";
                    button2.Text = "二萬";
                    button3.Text = "三兆";
                    button4.Text = "四元";

                    correctAnswer = 1;
                    break;

                case 6:
                    label2.Text = "什麽顔色最會模仿？";

                    button1.Text = "藍";
                    button2.Text = "紫";
                    button3.Text = "紅";
                    button4.Text = "綠";

                    correctAnswer = 3;
                    break;

                case 7:
                    label2.Text = "天上的星星有多重？";

                    button1.Text = "四克";
                    button2.Text = "十斤";
                    button3.Text = "八克";
                    button4.Text = "兩斤";

                    correctAnswer = 3;
                    break;

                case 8:
                    label2.Text = "什麽雞沒有翅膀？";

                    button1.Text = "小雞";
                    button2.Text = "公雞";
                    button3.Text = "火雞";
                    button4.Text = "田雞";

                    correctAnswer = 4;
                    break;
            }
        }
    }
}
