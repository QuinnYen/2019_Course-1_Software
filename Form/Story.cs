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
    public partial class Story : Form
    {
        Image PB_00 = Pro_02.Properties.Resources.BP_00;


        public Story()
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
            label1.Text = 
                "原本在農莊生活的四匹老馬，因逐漸虛弱而被農場主人嫌棄，並想將他們趕出去。\n" +
                "為了證明自己還老當益壯，老馬們決定踏出舒適圈，\n" +
                "進入危險的叢林中尋找機會改變自己的命運。\n" +
                "得知此事的狐狸，決定告訴他們一些技巧，當然這都取決於命運......";
            pictureBox1.Image = PB_00;

            Color myColor = Color.FromArgb(150, Color.Black);
            label1.BackColor = myColor;
            label1.Parent = pictureBox1;
        }
    }
}
