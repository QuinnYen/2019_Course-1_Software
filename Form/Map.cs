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
    public partial class Map : Form
    {
        //-----------------------------------------------------------------------------------------//
        //區塊01 - 全域變數設定
        private Menu Mainmenu;
        ToolTip tip = new ToolTip();

        Block[] blocks;
        Block[] BY; Block[] BB; Block[] BP; Block[] BR;

        Random random;
        int[] arr = new int[] { 5, 10, 15, 20, 30 };
        int now_player;
        int step; int sy; int sb; int sp; int sr;
        int Bar01; int Bar02;
        int Bar03; int Bar04;
        GameState now_state;
        CellState now_cell;

        //區塊02 - 全域圖片設定
        //主地圖與主玩家
        ProgressBar[] PR_Player_HPBar;
        GroupBox[] GroupBox_Player_Area;
        Player[] players;
        Image _1P = Pro_02.Properties.Resources._1P;
        Image _2P = Pro_02.Properties.Resources._2P;
        Image _3P = Pro_02.Properties.Resources._3P;
        Image _4P = Pro_02.Properties.Resources._4P;
        Image Main_map = Pro_02.Properties.Resources.Map_Ver2_2;

        //副地圖
        public Point player01_location;
        public Point player02_location;
        public Point player03_location;
        public Point player04_location;
        Bitmap S_1P = Pro_02.Properties.Resources.S_1P;
        Bitmap S_2P = Pro_02.Properties.Resources.S_2P;
        Bitmap S_3P = Pro_02.Properties.Resources.S_3P;
        Bitmap S_4P = Pro_02.Properties.Resources.S_4P;
        Bitmap Zoom_map = Pro_02.Properties.Resources.Map_Ver2_1;
        //-----------------------------------------------------------------------------------------//


        //-----------------------------------------------------------------------------------------//
        public Map(Menu menu)
        {
            InitializeComponent();
            Mainmenu = menu;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
            //主地圖與主玩家 加載
            PictureBox_Map.Image = Main_map;
            PB_1P.Image = _1P;
            PB_2P.Image = _2P;
            PB_3P.Image = _3P;
            PB_4P.Image = _4P;

            //設定副地圖
            player01_location = new Point(125, 35);
            player02_location = new Point(125, 35);
            player03_location = new Point(125, 35);
            player04_location = new Point(125, 35);

            
            //設定玩家體力槽
            PR_Player_HPBar = new ProgressBar[Constants.PLAYER_NUMBER];
            //////
            PR_Player_HPBar[0] = Label_HPBar1;
            PR_Player_HPBar[1] = Label_HPBar2;
            PR_Player_HPBar[2] = Label_HPBar3;
            PR_Player_HPBar[3] = Label_HPBar4;
            

            //設定玩家區域
            GroupBox_Player_Area = new GroupBox[Constants.PLAYER_NUMBER];
            //////
            GroupBox_Player_Area[0] = GroupBox_Player1;
            GroupBox_Player_Area[1] = GroupBox_Player2;
            GroupBox_Player_Area[2] = GroupBox_Player3;
            GroupBox_Player_Area[3] = GroupBox_Player4;

            //設定主玩家圖片及初始位置
            players = new Player[Constants.PLAYER_NUMBER];
            //////
            players[0] = new Player(_1P, 0);
            Controls.Add(players[0].Image);
            players[0].Location = PictureBox_Map.Location;
            players[0].Image.BringToFront();

            players[1] = new Player(_2P, 1);
            Controls.Add(players[1].Image);
            players[1].Location = PictureBox_Map.Location;
            players[1].Image.BringToFront();

            players[2] = new Player(_3P, 2);
            Controls.Add(players[2].Image);
            players[2].Location = PictureBox_Map.Location;
            players[2].Image.BringToFront();

            players[3] = new Player(_4P, 3);
            Controls.Add(players[3].Image);
            players[3].Location = PictureBox_Map.Location;
            players[3].Image.BringToFront();

            //設定主地圖移動區塊
            blocks = new Block[Constants.BLOCK_NUMBER];
            //////
            blocks[0] = new StartBlock(new Point(0, 0)); //起點
            blocks[1] = new Block(new Point(-35, 55));
            blocks[2] = new YellowBlock(new Point(-65, 115)); //黃徑
            blocks[3] = new Block(new Point(-35, 170));
            blocks[4] = new Block(new Point(0, 225));
            blocks[5] = new SwampBlock(new Point(35, 285)); //沼澤
            blocks[6] = new Block(new Point(65, 340));
            blocks[7] = new EventBlock(new Point(100, 395)); //事件
            blocks[8] = new BlueBlock(new Point(165, 395)); //藍徑
            blocks[9] = new Block(new Point(200,340));
            blocks[10] = new TrapBlock(new Point(165, 285)); //陷阱
            blocks[11] = new Block(new Point(135, 225));
            blocks[12] = new EventBlock(new Point(100, 170)); //事件
            blocks[13] = new Block(new Point(135, 115));
            blocks[14] = new PurpleBlock(new Point(200, 115)); //紫徑
            blocks[15] = new Block(new Point(235, 170));
            blocks[16] = new EventBlock(new Point(265, 225)); //事件
            blocks[17] = new Block(new Point(300, 285));
            blocks[18] = new Block(new Point(335, 340));
            blocks[19] = new Block(new Point(365, 395));
            blocks[20] = new EventBlock(new Point(430, 395)); //事件
            blocks[21] = new Block(new Point(465, 340));
            blocks[22] = new FoxBlock(new Point(430, 285)); //狐狸
            blocks[23] = new Block(new Point(395, 225));
            blocks[24] = new EventBlock(new Point(365, 170)); //事件
            blocks[25] = new Block(new Point(395, 115));
            blocks[26] = new Block(new Point(460, 115));
            blocks[27] = new MonkeyBlock(new Point(495, 170)); //猴子
            blocks[28] = new Block(new Point(525, 225));
            blocks[29] = new EventBlock(new Point(590, 225)); //事件
            blocks[30] = new RedBlock(new Point(625, 170)); //紅徑
            blocks[31] = new Block(new Point(655, 115));
            blocks[32] = new Block(new Point(690, 55));
            blocks[33] = new LionBlock(new Point(660, 0)); //獅子
            blocks[34] = new Block(new Point(590, 0));
            blocks[35] = new Block(new Point(525, 0));
            blocks[36] = new EventBlock(new Point(460, 0)); //事件
            blocks[37] = new Block(new Point(395, 0));
            blocks[38] = new Block(new Point(325, 0));
            blocks[39] = new ManBlock(new Point(260, 0)); //路人
            blocks[40] = new Block(new Point(200, 0));
            blocks[41] = new EventBlock(new Point(135, 0)); //事件
            blocks[42] = new Block(new Point(65, 0));

            //設定黃色小徑移動區塊
            BY = new Block[Constants.BLOCK_Yellow];
            //////
            BY[0] = new Block(new Point(-65, 115));
            BY[1] = new Block(new Point(35, 115));
            BY[2] = new Block(new Point(65, 115));
            BY[3] = new Block(new Point(135, 115));

            //設定藍色小徑移動區塊
            BB = new Block[Constants.BLOCK_Blue];
            //////
            BB[0] = new Block(new Point(165, 395));
            BB[1] = new Block(new Point(235, 395));
            BB[2] = new Block(new Point(300, 395));
            BB[3] = new Block(new Point(365, 395));

            //設定紫色小徑移動區塊
            BP = new Block[Constants.BLOCK_Purple];
            //////
            BP[0] = new Block(new Point(200, 115));
            BP[1] = new Block(new Point(265, 115));
            BP[2] = new Block(new Point(365, 115));
            BP[3] = new Block(new Point(395, 115));

            //設定紅色小徑移動區塊
            BR = new Block[Constants.BLOCK_Red];
            //////
            BR[0] = new Block(new Point(625, 170));
            BR[1] = new Block(new Point(590, 115));
            BR[2] = new Block(new Point(565, 55));
            BR[3] = new Block(new Point(525, 0));

            //設定 TopTip
            tip.SetToolTip(this.PB_nothing, "點我開啟「開發人員模式」");
            tip.SetToolTip(this.PB_nothing2, "Ground Pound");

            //設定其他變數
            random = new Random();
            now_player = 0;
            step = 0;
            sy = 0; sb = 0; sp = 0; sr = 0;

            now_state = GameState.Initial;
            UpdateUI();

            //故事訊息
            Story S = new Story();
            S.ShowDialog();
        }
        //-----------------------------------------------------------------------------------------//


        //-----------------------------------------------------------------------------------------//
        //骰子按鈕
        private void Button_Dice_Click(object sender, EventArgs e)
        {
            if (players[now_player].IsRested == false)
            {
                step = random.Next(Constants.DICE_NUMBER) + 1;
                players[now_player].IsRested = false;
                int Dice = step;
                Text_DiceNumber.Text += "玩家擲出 " + Dice + " 點。";
                now_state = GameState.Walking;

                int A = PR_Player_HPBar[now_player].Value;
                if (A > 0 && A - 5 > 0) { PR_Player_HPBar[now_player].Value -= 5; }
                if (A > 0 && A - 5 == 0) { PR_Player_HPBar[now_player].Value = 0; }
                if (A > 0 && A - 5 <= 0) { PR_Player_HPBar[now_player].Value = 0; }
                if (A <= 0) { PR_Player_HPBar[now_player].Value = 0; }
                UpdateBar();
            }
            if (players[now_player].IsRested == true) { players[now_player].IsRested = false; now_state = GameState.jail; }

            UpdateUI();
        }

        //結束回合按鈕
        private void Button_End_Click(object sender, EventArgs e)
        {
            now_player = (now_player + 1) % Constants.PLAYER_NUMBER;
            while (players[now_player].State == PlayerState.Dead)
                now_player = (now_player + 1) % Constants.PLAYER_NUMBER;

            now_state = GameState.Initial;
            UpdateUI();
        }

        //離開沼澤按鈕
        private void Button_Leave_Click(object sender, EventArgs e)
        {
            SwampMsg S = new SwampMsg();
            S.ShowDialog();
            players[now_player].IsRested = false;
            Button_Leave.Visible = false;
            Button_End.Enabled = true;
        }

        //幫助按鈕
        private void Button_Help_Click(object sender, EventArgs e)
        {
            StoryMsg H = new StoryMsg();
            H.ShowDialog();
        }

        //測試按鈕
        private void Button_Test_Click(object sender, EventArgs e)
        {
            if(TB_input.Text != "")
            {
                string Test = string.Empty;
                Test = TB_input.Text.ToString();
                step = int.Parse(Test);
                int Dice = step;
                Text_DiceNumber.Text += "你擲出 " + Dice + " 點";
                now_state = GameState.Walking;
                UpdateUI();
            }
            else
            {
                MessageBox.Show("請先輸入值阿");
            }
        }

        //顯示開發人員模式
        private void PB_nothing_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == true) { this.groupBox1.Visible = false; }
            else { this.groupBox1.Visible = true; }
        }

        //直接贏得遊戲模式
        private void PB_nothing2_DoubleClick(object sender, EventArgs e)
        {
            PR_Player_HPBar[now_player].Value = 100; UpdateBar(); PlayerWin();
        }

        //重新執行應用程式
        private void Button_Restart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否要重啟遊戲？", "ლ(ﾟдﾟლ)", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
            }
            else
            {
                return;
            }
        }

        //關閉應用程式
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
        //-----------------------------------------------------------------------------------------//


        //-----------------------------------------------------------------------------------------//
        //設定計時器
        private void Timer_Process_Tick(object sender, EventArgs e)
        {
            if (step != 0)
            {
                if (PlayerMove())
                {
                    players[now_player].BlockIndex = (players[now_player].BlockIndex + 1) % Constants.BLOCK_NUMBER;
                    PictureBox_Zoom.Refresh();
                    --step;

                    //00_起始格子，更新狀態
                    if (blocks[players[now_player].BlockIndex] is StartBlock)
                    {
                        int A = PR_Player_HPBar[now_player].Value;
                        if (A+10 < 100) { PR_Player_HPBar[now_player].Value += 10; }
                        if (A+10 >= 100) { PR_Player_HPBar[now_player].Value = 100; PlayerWin(); }

                        if (players[now_player] == players[0]) Text_1PInfo.AppendText("經過起點得到10體力\n");
                        if (players[now_player] == players[1]) Text_2PInfo.AppendText("經過起點得到10體力\n");
                        if (players[now_player] == players[2]) Text_3PInfo.AppendText("經過起點得到10體力\n");
                        if (players[now_player] == players[3]) Text_4PInfo.AppendText("經過起點得到10體力\n");
                    }

                    //01_黃徑格子，更新狀態
                    if (step == 0 && blocks[players[now_player].BlockIndex] is YellowBlock)
                    {
                        now_state = GameState.Stopped; UpdateUI();
                        now_cell = CellState.Yellow; UpdateCell();
                    }

                    //02_藍徑格子，更新狀態
                    if (step == 0 && blocks[players[now_player].BlockIndex] is BlueBlock)
                    {
                        now_state = GameState.Stopped; UpdateUI();
                        now_cell = CellState.Blue; UpdateCell();
                    }

                    //03_紫徑格子，更新狀態
                    if (step == 0 && blocks[players[now_player].BlockIndex] is PurpleBlock)
                    {
                        now_state = GameState.Stopped; UpdateUI();
                        now_cell = CellState.Purple; UpdateCell();
                    }

                    //04_紅徑格子，更新狀態
                    if (step == 0 && blocks[players[now_player].BlockIndex] is RedBlock)
                    {
                        now_state = GameState.Stopped; UpdateUI();
                        now_cell = CellState.Red; UpdateCell();
                    }

                    //05_沼澤格子，更新狀態
                    if (step == 0 && blocks[players[now_player].BlockIndex] is SwampBlock)
                    {
                        now_state = GameState.Stopped; UpdateUI();
                        now_cell = CellState.Swamp; UpdateCell();
                    }

                    //06_陷阱格子，更新狀態
                    if (step == 0 && blocks[players[now_player].BlockIndex] is TrapBlock)
                    {
                        now_state = GameState.Stopped; UpdateUI();
                        now_cell = CellState.Trap; UpdateCell();
                    }

                    //07_狐狸格子，更新狀態
                    if (step == 0 && blocks[players[now_player].BlockIndex] is FoxBlock)
                    {
                        
                        now_state = GameState.Stopped; UpdateUI();
                        now_cell = CellState.Fox; UpdateCell();
                    }

                    //08_猴子格子，更新狀態
                    if (step == 0 && blocks[players[now_player].BlockIndex] is MonkeyBlock)
                    {
                        now_state = GameState.Stopped; UpdateUI();
                        now_cell = CellState.Monkey; UpdateCell();
                    }

                    //09_獅子格子，更新狀態
                    if (step == 0 && blocks[players[now_player].BlockIndex] is LionBlock)
                    {
                        now_state = GameState.Stopped; UpdateUI();
                        now_cell = CellState.Lion; UpdateCell();
                    }

                    //10_路人格子，更新狀態
                    if (step == 0 && blocks[players[now_player].BlockIndex] is ManBlock)
                    {
                        now_state = GameState.Stopped; UpdateUI();
                        now_cell = CellState.Man; UpdateCell();
                    }

                    //11_事件格子，更新狀態
                    if (step == 0 && blocks[players[now_player].BlockIndex] is EventBlock)
                    {
                        now_state = GameState.Stopped; UpdateUI();
                        now_cell = CellState.Evented; UpdateCell();
                    }

                    //當步數為0，停止前進
                    if (step == 0)
                    {
                        now_state = GameState.Stopped; UpdateUI();
                    }
                }
            }
            //黃色移動
            if (sy != 0)
            {
                if (PlayerMove_Y())
                {
                    players[now_player].BlockIndex = (players[now_player].BlockIndex + 1) % Constants.BLOCK_Yellow;
                    --sy;
                }
                if (sy == 0)
                {
                    now_state = GameState.Stopped; UpdateUI();
                    players[now_player].BlockIndex = 13;
                    YellowMsg Y = new YellowMsg(); Y.Show();
                }
            }
            //藍色移動
            if (sb != 0)
            {
                if (PlayerMove_B())
                {
                    players[now_player].BlockIndex = (players[now_player].BlockIndex + 1) % Constants.BLOCK_Blue;
                    --sb;
                }
                if (sb == 0)
                {
                    now_state = GameState.Stopped; UpdateUI();
                    players[now_player].BlockIndex = 19;
                    BlueMsg B = new BlueMsg(); B.Show();
                }
            }
            //紫色移動
            if (sp != 0)
            {
                if (PlayerMove_P())
                {
                    players[now_player].BlockIndex = (players[now_player].BlockIndex + 1) % Constants.BLOCK_Purple;
                    --sp;
                }
                if (sp == 0)
                {
                    now_state = GameState.Stopped; UpdateUI();
                    players[now_player].BlockIndex = 25;
                    PurpleMsg P = new PurpleMsg(); P.Show();
                }
            }
            //紅色移動
            if (sr != 0)
            {
                if (PlayerMove_R())
                {
                    players[now_player].BlockIndex = (players[now_player].BlockIndex + 1) % Constants.BLOCK_Red;
                    --sr;
                }
                if (sr == 0)
                {
                    now_state = GameState.Stopped; UpdateUI();
                    players[now_player].BlockIndex = 35;
                    RedMsg R = new RedMsg(); R.Show();
                }
            }
        }

        //設定百分比數值
        private void UpdateBar()
        {
            Bar01 = 100 * (PR_Player_HPBar[0].Value - PR_Player_HPBar[0].Minimum) / (PR_Player_HPBar[0].Maximum - PR_Player_HPBar[0].Minimum);
            Bar02 = 100 * (PR_Player_HPBar[1].Value - PR_Player_HPBar[1].Minimum) / (PR_Player_HPBar[1].Maximum - PR_Player_HPBar[1].Minimum);
            Bar03 = 100 * (PR_Player_HPBar[2].Value - PR_Player_HPBar[2].Minimum) / (PR_Player_HPBar[2].Maximum - PR_Player_HPBar[2].Minimum);
            Bar04 = 100 * (PR_Player_HPBar[3].Value - PR_Player_HPBar[3].Minimum) / (PR_Player_HPBar[3].Maximum - PR_Player_HPBar[3].Minimum);
            if (players[now_player] == players[0]) Label_1P.Text = Bar01.ToString() + "%";
            if (players[now_player] == players[1]) Label_2P.Text = Bar02.ToString() + "%";
            if (players[now_player] == players[2]) Label_3P.Text = Bar03.ToString() + "%";
            if (players[now_player] == players[3]) Label_4P.Text = Bar04.ToString() + "%";
        }

        //在Map中，移動滑鼠，顯示座標
        private void PictureBox_Map_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = string.Format("X: {0}, Y: {1}", e.X, e.Y);
        }
        //-----------------------------------------------------------------------------------------//


        //-----------------------------------------------------------------------------------------//
        //設定主玩家移動
        private bool PlayerMove()
        {
            int now_index = players[now_player].BlockIndex;
            int next_index = (now_index + 1) % Constants.BLOCK_NUMBER;
            int dx = (blocks[next_index].Location.X - blocks[now_index].Location.X) / Constants.STEPS_PER_BLOCK;
            int dy = (blocks[next_index].Location.Y - blocks[now_index].Location.Y) / Constants.STEPS_PER_BLOCK;

            players[now_player].Location = new Point(players[now_player].Location.X + dx, players[now_player].Location.Y + dy);

            Point pre01_location = player01_location;
            player01_location = new Point(pre01_location.X + dx, pre01_location.Y + dy);

            if (players[now_player].Location.X - PictureBox_Map.Location.X == blocks[next_index].Location.X &&
                 players[now_player].Location.Y - PictureBox_Map.Location.Y == blocks[next_index].Location.Y)
            {
                return true;
            }
            return false;
        }

        //設定黃徑移動
        private bool PlayerMove_Y()
        {
            int now_index = players[now_player].BlockIndex;
            int next_index = (now_index + 1) % Constants.BLOCK_Yellow;
            int dx = (BY[next_index].Location.X - BY[now_index].Location.X) / Constants.STEPS_PER_BLOCK;
            int dy = (BY[next_index].Location.Y - BY[now_index].Location.Y) / Constants.STEPS_PER_BLOCK;

            players[now_player].Location = new Point(players[now_player].Location.X + dx, players[now_player].Location.Y + dy);


            if (players[now_player].Location.X - PictureBox_Map.Location.X == BY[next_index].Location.X &&
                 players[now_player].Location.Y - PictureBox_Map.Location.Y == BY[next_index].Location.Y)
            {
                return true;
            }
            return false;
        }

        //設定藍徑移動
        private bool PlayerMove_B()
        {
            int now_index = players[now_player].BlockIndex;
            int next_index = (now_index + 1) % Constants.BLOCK_Blue;
            int dx = (BB[next_index].Location.X - BB[now_index].Location.X) / Constants.STEPS_PER_BLOCK;
            int dy = (BB[next_index].Location.Y - BB[now_index].Location.Y) / Constants.STEPS_PER_BLOCK;

            players[now_player].Location = new Point(players[now_player].Location.X + dx, players[now_player].Location.Y + dy);


            if (players[now_player].Location.X - PictureBox_Map.Location.X == BB[next_index].Location.X &&
                 players[now_player].Location.Y - PictureBox_Map.Location.Y == BB[next_index].Location.Y)
            {
                return true;
            }
            return false;
        }

        //設定紫徑移動
        private bool PlayerMove_P()
        {
            int now_index = players[now_player].BlockIndex;
            int next_index = (now_index + 1) % Constants.BLOCK_Purple;
            int dx = (BP[next_index].Location.X - BP[now_index].Location.X) / Constants.STEPS_PER_BLOCK;
            int dy = (BP[next_index].Location.Y - BP[now_index].Location.Y) / Constants.STEPS_PER_BLOCK;

            players[now_player].Location = new Point(players[now_player].Location.X + dx, players[now_player].Location.Y + dy);


            if (players[now_player].Location.X - PictureBox_Map.Location.X == BP[next_index].Location.X &&
                 players[now_player].Location.Y - PictureBox_Map.Location.Y == BP[next_index].Location.Y)
            {
                return true;
            }
            return false;
        }

        //設定紅徑移動
        private bool PlayerMove_R()
        {
            int now_index = players[now_player].BlockIndex;
            int next_index = (now_index + 1) % Constants.BLOCK_Red;
            int dx = (BR[next_index].Location.X - BR[now_index].Location.X) / Constants.STEPS_PER_BLOCK;
            int dy = (BR[next_index].Location.Y - BR[now_index].Location.Y) / Constants.STEPS_PER_BLOCK;

            players[now_player].Location = new Point(players[now_player].Location.X + dx, players[now_player].Location.Y + dy);


            if (players[now_player].Location.X - PictureBox_Map.Location.X == BR[next_index].Location.X &&
                 players[now_player].Location.Y - PictureBox_Map.Location.Y == BR[next_index].Location.Y)
            {
                return true;
            }
            return false;
        }

        //設定遊戲格子介面
        private void UpdateCell()
        {
            switch(now_cell)
            {
                case CellState.Yellow:
                    if (MessageBox.Show("是否進入黃色小徑?\n將觸發一個事件", "一分二路", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        YellowMsg Y = new YellowMsg();
                        players[now_player].BlockIndex = 0;
                        sy = 3;
                        PlayerMove_Y();
                        if (players[now_player] == players[0]) Text_1PInfo.AppendText("選擇進入黃色小徑\n");
                        if (players[now_player] == players[1]) Text_2PInfo.AppendText("選擇進入黃色小徑\n");
                        if (players[now_player] == players[2]) Text_3PInfo.AppendText("選擇進入黃色小徑\n");
                        if (players[now_player] == players[3]) Text_4PInfo.AppendText("選擇進入黃色小徑\n");
                        if (Y.ShowDialog() == DialogResult.Yes) { now_cell = CellState.Evented; UpdateCell();}
                    }
                    else
                    {
                        if (players[now_player] == players[0]) Text_1PInfo.AppendText("拒絕進入黃色小徑\n");
                        if (players[now_player] == players[1]) Text_2PInfo.AppendText("拒絕進入黃色小徑\n");
                        if (players[now_player] == players[2]) Text_3PInfo.AppendText("拒絕進入黃色小徑\n");
                        if (players[now_player] == players[3]) Text_4PInfo.AppendText("拒絕進入黃色小徑\n");
                    }
                    Text_GameInfo.AppendText("玩家" + (now_player+1) + "，碰到黃色小徑\n");
                    break;

                case CellState.Blue:
                    if (MessageBox.Show("是否進入藍色小徑?\n將觸發一個事件", "縮短距離", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        BlueMsg B = new BlueMsg();
                        players[now_player].BlockIndex = 0;
                        sb = 3;
                        PlayerMove_B();
                        if (players[now_player] == players[0]) Text_1PInfo.AppendText("選擇進入藍色小徑\n");
                        if (players[now_player] == players[1]) Text_2PInfo.AppendText("選擇進入藍色小徑\n");
                        if (players[now_player] == players[2]) Text_3PInfo.AppendText("選擇進入藍色小徑\n");
                        if (players[now_player] == players[3]) Text_4PInfo.AppendText("選擇進入藍色小徑\n");
                        if (B.ShowDialog() == DialogResult.Yes) { now_cell = CellState.Evented; UpdateCell(); }
                    }
                    else
                    {
                        if (players[now_player] == players[0]) Text_1PInfo.AppendText("拒絕進入藍色小徑\n");
                        if (players[now_player] == players[1]) Text_2PInfo.AppendText("拒絕進入藍色小徑\n");
                        if (players[now_player] == players[2]) Text_3PInfo.AppendText("拒絕進入藍色小徑\n");
                        if (players[now_player] == players[3]) Text_4PInfo.AppendText("拒絕進入藍色小徑\n");
                    }
                    Text_GameInfo.AppendText("玩家" + (now_player + 1) + "，碰到藍色小徑\n");
                    break;

                case CellState.Purple:
                    if (MessageBox.Show("是否進入紫色小徑?\n將觸發一個事件", "量子傳輸", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        PurpleMsg P = new PurpleMsg();
                        players[now_player].BlockIndex = 0;
                        sp = 3;
                        PlayerMove_P();
                        if (players[now_player] == players[0]) Text_1PInfo.AppendText("選擇進入紫色小徑\n");
                        if (players[now_player] == players[1]) Text_2PInfo.AppendText("選擇進入紫色小徑\n");
                        if (players[now_player] == players[2]) Text_3PInfo.AppendText("選擇進入紫色小徑\n");
                        if (players[now_player] == players[3]) Text_4PInfo.AppendText("選擇進入紫色小徑\n");
                        if (P.ShowDialog() == DialogResult.Yes) { now_cell = CellState.Evented; UpdateCell(); }
                    }
                    else
                    {
                        if (players[now_player] == players[0]) Text_1PInfo.AppendText("拒絕進入紫色小徑\n");
                        if (players[now_player] == players[1]) Text_2PInfo.AppendText("拒絕進入紫色小徑\n");
                        if (players[now_player] == players[2]) Text_3PInfo.AppendText("拒絕進入紫色小徑\n");
                        if (players[now_player] == players[3]) Text_4PInfo.AppendText("拒絕進入紫色小徑\n");
                    }
                    Text_GameInfo.AppendText("玩家" + (now_player + 1) + "，碰到紫色小徑\n");
                    break;

                case CellState.Red:
                    if (MessageBox.Show("是否進入紅色小徑?\n將觸發一個事件", "切西瓜", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        RedMsg R = new RedMsg();
                        players[now_player].BlockIndex = 0;
                        sr = 3;
                        PlayerMove_R();
                        if (players[now_player] == players[0]) Text_1PInfo.AppendText("選擇進入紅色小徑\n");
                        if (players[now_player] == players[1]) Text_2PInfo.AppendText("選擇進入紅色小徑\n");
                        if (players[now_player] == players[2]) Text_3PInfo.AppendText("選擇進入紅色小徑\n");
                        if (players[now_player] == players[3]) Text_4PInfo.AppendText("選擇進入紅色小徑\n");
                        if (R.ShowDialog() == DialogResult.Yes) { now_cell = CellState.Evented; UpdateCell(); }
                    }
                    else
                    {
                        if (players[now_player] == players[0]) Text_1PInfo.AppendText("拒絕進入紅色小徑\n");
                        if (players[now_player] == players[1]) Text_2PInfo.AppendText("拒絕進入紅色小徑\n");
                        if (players[now_player] == players[2]) Text_3PInfo.AppendText("拒絕進入紅色小徑\n");
                        if (players[now_player] == players[3]) Text_4PInfo.AppendText("拒絕進入紅色小徑\n");
                    }
                    Text_GameInfo.AppendText("玩家" + (now_player + 1) + "，碰到紅色小徑\n");
                    break;

                case CellState.Swamp:
                    if (MessageBox.Show("你一腳踏入沼澤中\n(將暫停一回合)", "注意腳邊", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        Swamp();
                    }
                    Text_GameInfo.AppendText("玩家" + (now_player + 1) + "，一腳踩進沼澤\n");
                    break;

                case CellState.Trap:
                    if (MessageBox.Show("你不小心踩重陷阱\n(輸了將暫停一回合)", "注意腳邊", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        Trap();
                    }
                    Text_GameInfo.AppendText("玩家" + (now_player + 1) + "，不小心踩中陷阱\n");
                    break;

                case CellState.Fox:
                    if (MessageBox.Show("前方似乎有誰在", "碰到熟人", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        UpdateSP_UP();
                    }
                    Text_GameInfo.AppendText("玩家" + (now_player + 1) + "，得到狐狸的幫忙\n");
                    break;

                case CellState.Monkey:
                    if (MessageBox.Show("沿路猴子的考驗", "智者的考驗", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        Monkey();
                    }
                    Text_GameInfo.AppendText("玩家" + (now_player + 1) + "，遇見一隻猴子\n");
                    break;

                case CellState.Lion:
                    if (MessageBox.Show("前方似乎有誰在", "危機四伏", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        UpdateSP_DN();
                    }
                    Text_GameInfo.AppendText("玩家" + (now_player + 1) + "，撞見一頭獅子\n");
                    break;

                case CellState.Man:
                    if (MessageBox.Show("一位陌生人向你搭話", "拳拳到位", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        Man();
                    }
                    Text_GameInfo.AppendText("玩家" + (now_player + 1) + "，路過一位陌生人\n");
                    break;

                case CellState.Evented:
                    if (MessageBox.Show("你碰到了一個奇特的事件", "觸發事件", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        Event();
                    }
                    Text_GameInfo.AppendText("玩家" + (now_player + 1) + "，碰到一件事件\n");
                    break;
            }
        }

        //設定事件體力上升介面
        private void UpdateSP_UP()
        {
            Random ran = new Random();
            EventGoodMsg M = new EventGoodMsg();
            FoxMsg F = new FoxMsg();
            int n = ran.Next(arr.Length - 1);
            int S = arr[n];
            int A = PR_Player_HPBar[now_player].Value;

            if(A != 100)
            {
                switch (now_cell)
                {
                    case CellState.Evented:

                        if (A+S < 100) { PR_Player_HPBar[now_player].Value += S; M.ShowDialog(); }
                        if (A+S >= 100) { PR_Player_HPBar[now_player].Value = 100; PlayerWin(); }

                        if (players[now_player] == players[0]) Text_1PInfo.AppendText("事件，上升" + S + "體力\n");
                        if (players[now_player] == players[1]) Text_2PInfo.AppendText("事件，上升" + S + "體力\n");
                        if (players[now_player] == players[2]) Text_3PInfo.AppendText("事件，上升" + S + "體力\n");
                        if (players[now_player] == players[3]) Text_4PInfo.AppendText("事件，上升" + S + "體力\n");
                        break;

                    case CellState.Fox:
                        if (A + 50 < 100) { PR_Player_HPBar[now_player].Value += 50; F.ShowDialog(); }
                        if (A + 50 >= 100) { PR_Player_HPBar[now_player].Value = 100; PlayerWin(); }

                        if (players[now_player] == players[0]) Text_1PInfo.AppendText("從狐狸那得到50體力\n");
                        if (players[now_player] == players[1]) Text_2PInfo.AppendText("從狐狸那得到50體力\n");
                        if (players[now_player] == players[2]) Text_3PInfo.AppendText("從狐狸那得到50體力\n");
                        if (players[now_player] == players[3]) Text_4PInfo.AppendText("從狐狸那得到50體力\n");
                        break;

                    case CellState.Started:
                        if (A + 50 < 100) { PR_Player_HPBar[now_player].Value += 10; }
                        if (A + 50 >= 100) { PR_Player_HPBar[now_player].Value = 100; PlayerWin(); }

                        if (players[now_player] == players[0]) Text_1PInfo.AppendText("經過起點得到10體力\n");
                        if (players[now_player] == players[1]) Text_2PInfo.AppendText("經過起點得到10體力\n");
                        if (players[now_player] == players[2]) Text_3PInfo.AppendText("經過起點得到10體力\n");
                        if (players[now_player] == players[3]) Text_4PInfo.AppendText("經過起點得到10體力\n");
                        break;

                    case CellState.Monkey:
                        if (A + 20 < 100) { PR_Player_HPBar[now_player].Value += 20; }
                        if (A + 20 >= 100) { PR_Player_HPBar[now_player].Value = 100; PlayerWin(); }

                        if (players[now_player] == players[0]) Text_1PInfo.AppendText("從猴子那得到20體力\n");
                        if (players[now_player] == players[1]) Text_2PInfo.AppendText("從猴子那得到20體力\n");
                        if (players[now_player] == players[2]) Text_3PInfo.AppendText("從猴子那得到20體力\n");
                        if (players[now_player] == players[3]) Text_4PInfo.AppendText("從猴子那得到20體力\n");
                        break;

                    case CellState.Man:
                        if (A + 30 < 100) { PR_Player_HPBar[now_player].Value += 30; }
                        if (A + 30 >= 100) { PR_Player_HPBar[now_player].Value = 100; PlayerWin(); }

                        if (players[now_player] == players[0]) Text_1PInfo.AppendText("從路人那得到30體力\n");
                        if (players[now_player] == players[1]) Text_2PInfo.AppendText("從路人那得到30體力\n");
                        if (players[now_player] == players[2]) Text_3PInfo.AppendText("從路人那得到30體力\n");
                        if (players[now_player] == players[3]) Text_4PInfo.AppendText("從路人那得到30體力\n");
                        break;
                }
            }
            else
            {
                if (A == 100) { PlayerWin(); }
            }
            UpdateBar();
        }

        //設定事件體力下降介面
        private void UpdateSP_DN()
        {
            Random ran = new Random();
            EventBadMsg N = new EventBadMsg();
            LionMsg L = new LionMsg();
            int n = ran.Next(arr.Length - 1);
            int S = arr[n];
            int A = PR_Player_HPBar[now_player].Value;

            if (A != 100)
            {
                switch (now_cell)
                {
                    case CellState.Evented:

                        if (A > 0 && A-S > 0) { PR_Player_HPBar[now_player].Value -= S; }
                        if (A > 0 && A-S == 0) { PR_Player_HPBar[now_player].Value = 0; }
                        if (A > 0 && A-S <= 0) { PR_Player_HPBar[now_player].Value = 0; }
                        if (A <= 0) { PR_Player_HPBar[now_player].Value = 0; }
                        N.Show();

                        if (players[now_player] == players[0]) Text_1PInfo.AppendText("事件，下降" + S + "體力\n"); UpdateBar();
                        if (players[now_player] == players[1]) Text_2PInfo.AppendText("事件，下降" + S + "體力\n"); UpdateBar();
                        if (players[now_player] == players[2]) Text_3PInfo.AppendText("事件，下降" + S + "體力\n"); UpdateBar();
                        if (players[now_player] == players[3]) Text_4PInfo.AppendText("事件，下降" + S + "體力\n"); UpdateBar();
                        break;

                    case CellState.Lion:
                        if (A > 0 && A-50 > 0) { PR_Player_HPBar[now_player].Value -= 50; }
                        if (A > 0 && A-50 == 0) { PR_Player_HPBar[now_player].Value = 0; }
                        if (A > 0 && A-50 <= 0) { PR_Player_HPBar[now_player].Value = 0; }
                        if (A <= 0) { PR_Player_HPBar[now_player].Value = 0; }
                        L.Show();

                        if (players[now_player] == players[0]) Text_1PInfo.AppendText("逃跑耗了50體力\n");
                        if (players[now_player] == players[1]) Text_2PInfo.AppendText("逃跑耗了50體力\n");
                        if (players[now_player] == players[2]) Text_3PInfo.AppendText("逃跑耗了50體力\n");
                        if (players[now_player] == players[3]) Text_4PInfo.AppendText("逃跑耗了50體力\n");
                        break;

                    case CellState.Monkey:
                        if (A > 0 && A - 20 > 0) { PR_Player_HPBar[now_player].Value -= 20; }
                        if (A > 0 && A - 20 == 0) { PR_Player_HPBar[now_player].Value = 0; }
                        if (A > 0 && A - 20 <= 0) { PR_Player_HPBar[now_player].Value = 0; }
                        if (A <= 0) { PR_Player_HPBar[now_player].Value = 0; }

                        if (players[now_player] == players[0]) Text_1PInfo.AppendText("「遭到香蕉攻擊」-20體力\n");
                        if (players[now_player] == players[1]) Text_2PInfo.AppendText("「遭到香蕉攻擊」-20體力\n");
                        if (players[now_player] == players[2]) Text_3PInfo.AppendText("「遭到香蕉攻擊」-20體力\n");
                        if (players[now_player] == players[3]) Text_4PInfo.AppendText("「遭到香蕉攻擊」-20體力\n");
                        break;
                }
            }
            UpdateBar();
        }

        //設定遊戲介面
        private void UpdateUI()
        {
            switch (now_state)
            {
                case GameState.Initial:
                    for (int i = 0; i < Constants.PLAYER_NUMBER; ++i)
                    {
                        if (players[i].State == PlayerState.Normal)
                        {
                            if (i != now_player)
                            {
                                GroupBox_Player_Area[i].BackColor = Color.Gray;
                                GroupBox_Player_Area[i].Enabled = false;
                            }
                            else
                            {
                                GroupBox_Player_Area[i].BackColor = Color.Yellow;
                                GroupBox_Player_Area[i].Enabled = true;
                                players[i].Image.BringToFront();
                            }
                        }
                    }

                    Text_DiceNumber.Text = "";
                    TB_input.Text = "";
                    Button_Test.Enabled = true;
                    Button_Dice.Enabled = true;
                    Button_Leave.Enabled = false;
                    Button_End.Enabled = false;
                    break;

                case GameState.Walking:
                    Button_Test.Enabled = false;
                    Button_Dice.Enabled = false;
                    Button_Leave.Enabled = false;
                    Button_End.Enabled = false;
                    break;

                case GameState.Stopped:
                    Button_Test.Enabled = false;
                    Button_Dice.Enabled = false;
                    Button_Leave.Enabled = false;
                    Button_End.Enabled = true;
                    break;

                case GameState.jail:
                    Button_Test.Enabled = false;
                    Button_Dice.Enabled = false;
                    Button_Leave.Enabled = true;
                    Button_Leave.Visible = true;
                    Button_End.Enabled = false;
                    break;

            }
        }

        //設定贏得遊戲介面
        private void PlayerWin()
        {
            WinMsg W = new WinMsg();
            W.ShowDialog();
        }
        //-----------------------------------------------------------------------------------------//


        //-----------------------------------------------------------------------------------------//
        //定義事件格子
        private void Event()
        {
            int E = random.Next(1, 10);
            switch (E)
            {
                case 1:UpdateSP_UP(); break;
                case 2:UpdateSP_DN(); break;
                case 3:UpdateSP_UP(); break;
                case 4:UpdateSP_DN(); break;
                case 5:UpdateSP_UP(); break;
                case 6:UpdateSP_DN(); break;
                case 7:UpdateSP_UP(); break;
                case 8:UpdateSP_DN(); break;
                case 9:UpdateSP_UP(); break;
                case 10:UpdateSP_DN(); break;
            }
        }

        //定義沼澤休息格子
        private void Swamp()
        {
            blocks[players[now_player].BlockIndex].ExcecuteAction(players[now_player]);
            now_state = GameState.Stopped;
            players[now_player].IsRested = true;
            if (players[now_player] == players[0]) Text_1PInfo.AppendText("踏入沼澤，將停止一回合\n");
            if (players[now_player] == players[1]) Text_2PInfo.AppendText("踏入沼澤，將停止一回合\n");
            if (players[now_player] == players[2]) Text_3PInfo.AppendText("踏入沼澤，將停止一回合\n");
            if (players[now_player] == players[3]) Text_4PInfo.AppendText("踏入沼澤，將停止一回合\n");
        }

        //定義陷阱格子
        private void Trap()
        {
            TrapGame T = new TrapGame();
            if (T.ShowDialog() == DialogResult.No)
            {
                blocks[players[now_player].BlockIndex].ExcecuteAction(players[now_player]);
                now_state = GameState.Stopped;
                players[now_player].IsRested = true;
                if (players[now_player] == players[0]) Text_1PInfo.AppendText("無法脫離，將停止一回合\n");
                if (players[now_player] == players[1]) Text_2PInfo.AppendText("無法脫離，將停止一回合\n");
                if (players[now_player] == players[2]) Text_3PInfo.AppendText("無法脫離，將停止一回合\n");
                if (players[now_player] == players[3]) Text_4PInfo.AppendText("無法脫離，將停止一回合\n");
            }
            else
            {
                if (players[now_player] == players[0]) Text_1PInfo.AppendText("成功脫逃陷阱\n");
                if (players[now_player] == players[1]) Text_2PInfo.AppendText("成功脫逃陷阱\n");
                if (players[now_player] == players[2]) Text_3PInfo.AppendText("成功脫逃陷阱\n");
                if (players[now_player] == players[3]) Text_4PInfo.AppendText("成功脫逃陷阱\n");
            }
        }

        //定義猴子格子
        private void Monkey()
        {
            GuessGame G = new GuessGame();
            if (G.ShowDialog() == DialogResult.Yes) { UpdateSP_UP(); }
            else { UpdateSP_DN(); }
        }

        //定義路人格子
        private void Man()
        {
            FingerGame G = new FingerGame();
            if (G.ShowDialog() == DialogResult.Yes) { UpdateSP_UP(); }
            else 
            {
                if (players[now_player] == players[0]) Text_1PInfo.AppendText("路人，甚麼都沒發生\n");
                if (players[now_player] == players[1]) Text_2PInfo.AppendText("路人，甚麼都沒發生\n");
                if (players[now_player] == players[2]) Text_3PInfo.AppendText("路人，甚麼都沒發生\n");
                if (players[now_player] == players[3]) Text_4PInfo.AppendText("路人，甚麼都沒發生\n");
            }
        }
        //-----------------------------------------------------------------------------------------//


        //-----------------------------------------------------------------------------------------//
        //BETA測試中的繪畫功能
        private void PictureBox_Zoom_Paint(object sender, PaintEventArgs e)
        {
            DrawZoomMap(e.Graphics);
            DrawZoomMIni01(e.Graphics);
        }
        
        private void DrawZoomMap(Graphics g)
        {
            Rectangle draw_area = new Rectangle(0, 0, PictureBox_Zoom.Width, PictureBox_Zoom.Height);
            Rectangle source_area = new Rectangle(0, 0, PictureBox_Zoom.Width, PictureBox_Zoom.Height);

            source_area.X = player01_location.X + S_1P.Width / 2 - PictureBox_Zoom.Width / 2;
            source_area.X = Math.Max(0, Math.Min(Zoom_map.Width - PictureBox_Zoom.Width, source_area.X));

            source_area.Y = player01_location.Y + S_1P.Height / 2 - PictureBox_Zoom.Height / 2;
            source_area.Y = Math.Max(0, Math.Min(Zoom_map.Height - PictureBox_Zoom.Height, source_area.Y));

            g.DrawImage(Zoom_map, draw_area, source_area, GraphicsUnit.Pixel);
        }

        private void DrawZoomMIni01(Graphics g)
        {
            Point loc = new Point(0, 0);
            loc.X = player01_location.X / 2 +0;
            loc.Y = player01_location.Y / 2 +0;
            g.DrawImage(S_1P, loc);
        }
        //-----------------------------------------------------------------------------------------//
    }
}
