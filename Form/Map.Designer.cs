namespace Pro_02
{
    partial class Map
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map));
            this.Button_Dice = new System.Windows.Forms.Button();
            this.Button_End = new System.Windows.Forms.Button();
            this.GroupBox_Player1 = new System.Windows.Forms.GroupBox();
            this.Label_1P = new System.Windows.Forms.Label();
            this.Label_HPBar1 = new System.Windows.Forms.ProgressBar();
            this.Text_1PInfo = new System.Windows.Forms.RichTextBox();
            this.PB_1P = new System.Windows.Forms.PictureBox();
            this.Timer_Process = new System.Windows.Forms.Timer(this.components);
            this.GroupBox_Player2 = new System.Windows.Forms.GroupBox();
            this.Label_2P = new System.Windows.Forms.Label();
            this.Label_HPBar2 = new System.Windows.Forms.ProgressBar();
            this.Text_2PInfo = new System.Windows.Forms.RichTextBox();
            this.PB_2P = new System.Windows.Forms.PictureBox();
            this.GroupBox_Player3 = new System.Windows.Forms.GroupBox();
            this.Label_3P = new System.Windows.Forms.Label();
            this.Label_HPBar3 = new System.Windows.Forms.ProgressBar();
            this.Text_3PInfo = new System.Windows.Forms.RichTextBox();
            this.PB_3P = new System.Windows.Forms.PictureBox();
            this.GroupBox_Player4 = new System.Windows.Forms.GroupBox();
            this.Label_4P = new System.Windows.Forms.Label();
            this.Label_HPBar4 = new System.Windows.Forms.ProgressBar();
            this.Text_4PInfo = new System.Windows.Forms.RichTextBox();
            this.PB_4P = new System.Windows.Forms.PictureBox();
            this.Text_DiceNumber = new System.Windows.Forms.TextBox();
            this.Text_GameInfo = new System.Windows.Forms.RichTextBox();
            this.Button_Test = new System.Windows.Forms.Button();
            this.TB_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PB_nothing = new System.Windows.Forms.PictureBox();
            this.PictureBox_Map = new System.Windows.Forms.PictureBox();
            this.PictureBox_Zoom = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Button_Leave = new System.Windows.Forms.Button();
            this.Button_Help = new System.Windows.Forms.Button();
            this.Button_Restart = new System.Windows.Forms.Button();
            this.Button_Close = new System.Windows.Forms.Button();
            this.PB_nothing2 = new System.Windows.Forms.PictureBox();
            this.GroupBox_Player1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_1P)).BeginInit();
            this.GroupBox_Player2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_2P)).BeginInit();
            this.GroupBox_Player3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_3P)).BeginInit();
            this.GroupBox_Player4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_4P)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_nothing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Zoom)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_nothing2)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Dice
            // 
            this.Button_Dice.BackColor = System.Drawing.Color.Brown;
            this.Button_Dice.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Button_Dice, "Button_Dice");
            this.Button_Dice.ForeColor = System.Drawing.Color.White;
            this.Button_Dice.Name = "Button_Dice";
            this.Button_Dice.UseVisualStyleBackColor = false;
            this.Button_Dice.Click += new System.EventHandler(this.Button_Dice_Click);
            // 
            // Button_End
            // 
            this.Button_End.BackColor = System.Drawing.Color.Brown;
            this.Button_End.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Button_End, "Button_End");
            this.Button_End.ForeColor = System.Drawing.Color.White;
            this.Button_End.Name = "Button_End";
            this.Button_End.UseVisualStyleBackColor = false;
            this.Button_End.Click += new System.EventHandler(this.Button_End_Click);
            // 
            // GroupBox_Player1
            // 
            this.GroupBox_Player1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GroupBox_Player1.Controls.Add(this.Label_1P);
            this.GroupBox_Player1.Controls.Add(this.Label_HPBar1);
            this.GroupBox_Player1.Controls.Add(this.Text_1PInfo);
            this.GroupBox_Player1.Controls.Add(this.PB_1P);
            resources.ApplyResources(this.GroupBox_Player1, "GroupBox_Player1");
            this.GroupBox_Player1.Name = "GroupBox_Player1";
            this.GroupBox_Player1.TabStop = false;
            // 
            // Label_1P
            // 
            resources.ApplyResources(this.Label_1P, "Label_1P");
            this.Label_1P.Name = "Label_1P";
            // 
            // Label_HPBar1
            // 
            this.Label_HPBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Label_HPBar1.ForeColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.Label_HPBar1, "Label_HPBar1");
            this.Label_HPBar1.Name = "Label_HPBar1";
            this.Label_HPBar1.Value = 35;
            // 
            // Text_1PInfo
            // 
            this.Text_1PInfo.Cursor = System.Windows.Forms.Cursors.No;
            resources.ApplyResources(this.Text_1PInfo, "Text_1PInfo");
            this.Text_1PInfo.Name = "Text_1PInfo";
            this.Text_1PInfo.ReadOnly = true;
            // 
            // PB_1P
            // 
            resources.ApplyResources(this.PB_1P, "PB_1P");
            this.PB_1P.Name = "PB_1P";
            this.PB_1P.TabStop = false;
            // 
            // Timer_Process
            // 
            this.Timer_Process.Enabled = true;
            this.Timer_Process.Interval = 50;
            this.Timer_Process.Tick += new System.EventHandler(this.Timer_Process_Tick);
            // 
            // GroupBox_Player2
            // 
            this.GroupBox_Player2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GroupBox_Player2.Controls.Add(this.Label_2P);
            this.GroupBox_Player2.Controls.Add(this.Label_HPBar2);
            this.GroupBox_Player2.Controls.Add(this.Text_2PInfo);
            this.GroupBox_Player2.Controls.Add(this.PB_2P);
            resources.ApplyResources(this.GroupBox_Player2, "GroupBox_Player2");
            this.GroupBox_Player2.Name = "GroupBox_Player2";
            this.GroupBox_Player2.TabStop = false;
            // 
            // Label_2P
            // 
            resources.ApplyResources(this.Label_2P, "Label_2P");
            this.Label_2P.Name = "Label_2P";
            // 
            // Label_HPBar2
            // 
            this.Label_HPBar2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Label_HPBar2.ForeColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.Label_HPBar2, "Label_HPBar2");
            this.Label_HPBar2.Name = "Label_HPBar2";
            this.Label_HPBar2.Value = 35;
            // 
            // Text_2PInfo
            // 
            this.Text_2PInfo.Cursor = System.Windows.Forms.Cursors.No;
            resources.ApplyResources(this.Text_2PInfo, "Text_2PInfo");
            this.Text_2PInfo.Name = "Text_2PInfo";
            this.Text_2PInfo.ReadOnly = true;
            // 
            // PB_2P
            // 
            resources.ApplyResources(this.PB_2P, "PB_2P");
            this.PB_2P.Name = "PB_2P";
            this.PB_2P.TabStop = false;
            // 
            // GroupBox_Player3
            // 
            this.GroupBox_Player3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GroupBox_Player3.Controls.Add(this.Label_3P);
            this.GroupBox_Player3.Controls.Add(this.Label_HPBar3);
            this.GroupBox_Player3.Controls.Add(this.Text_3PInfo);
            this.GroupBox_Player3.Controls.Add(this.PB_3P);
            resources.ApplyResources(this.GroupBox_Player3, "GroupBox_Player3");
            this.GroupBox_Player3.Name = "GroupBox_Player3";
            this.GroupBox_Player3.TabStop = false;
            // 
            // Label_3P
            // 
            resources.ApplyResources(this.Label_3P, "Label_3P");
            this.Label_3P.Name = "Label_3P";
            // 
            // Label_HPBar3
            // 
            this.Label_HPBar3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Label_HPBar3.ForeColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.Label_HPBar3, "Label_HPBar3");
            this.Label_HPBar3.Name = "Label_HPBar3";
            this.Label_HPBar3.Value = 35;
            // 
            // Text_3PInfo
            // 
            this.Text_3PInfo.Cursor = System.Windows.Forms.Cursors.No;
            resources.ApplyResources(this.Text_3PInfo, "Text_3PInfo");
            this.Text_3PInfo.Name = "Text_3PInfo";
            this.Text_3PInfo.ReadOnly = true;
            // 
            // PB_3P
            // 
            resources.ApplyResources(this.PB_3P, "PB_3P");
            this.PB_3P.Name = "PB_3P";
            this.PB_3P.TabStop = false;
            // 
            // GroupBox_Player4
            // 
            this.GroupBox_Player4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GroupBox_Player4.Controls.Add(this.Label_4P);
            this.GroupBox_Player4.Controls.Add(this.Label_HPBar4);
            this.GroupBox_Player4.Controls.Add(this.Text_4PInfo);
            this.GroupBox_Player4.Controls.Add(this.PB_4P);
            resources.ApplyResources(this.GroupBox_Player4, "GroupBox_Player4");
            this.GroupBox_Player4.Name = "GroupBox_Player4";
            this.GroupBox_Player4.TabStop = false;
            // 
            // Label_4P
            // 
            resources.ApplyResources(this.Label_4P, "Label_4P");
            this.Label_4P.Name = "Label_4P";
            // 
            // Label_HPBar4
            // 
            this.Label_HPBar4.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Label_HPBar4.ForeColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.Label_HPBar4, "Label_HPBar4");
            this.Label_HPBar4.Name = "Label_HPBar4";
            this.Label_HPBar4.Value = 35;
            // 
            // Text_4PInfo
            // 
            this.Text_4PInfo.Cursor = System.Windows.Forms.Cursors.No;
            resources.ApplyResources(this.Text_4PInfo, "Text_4PInfo");
            this.Text_4PInfo.Name = "Text_4PInfo";
            this.Text_4PInfo.ReadOnly = true;
            // 
            // PB_4P
            // 
            resources.ApplyResources(this.PB_4P, "PB_4P");
            this.PB_4P.Name = "PB_4P";
            this.PB_4P.TabStop = false;
            // 
            // Text_DiceNumber
            // 
            this.Text_DiceNumber.Cursor = System.Windows.Forms.Cursors.No;
            resources.ApplyResources(this.Text_DiceNumber, "Text_DiceNumber");
            this.Text_DiceNumber.Name = "Text_DiceNumber";
            this.Text_DiceNumber.ReadOnly = true;
            // 
            // Text_GameInfo
            // 
            this.Text_GameInfo.Cursor = System.Windows.Forms.Cursors.No;
            resources.ApplyResources(this.Text_GameInfo, "Text_GameInfo");
            this.Text_GameInfo.Name = "Text_GameInfo";
            this.Text_GameInfo.ReadOnly = true;
            // 
            // Button_Test
            // 
            this.Button_Test.BackColor = System.Drawing.Color.Coral;
            this.Button_Test.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Button_Test, "Button_Test");
            this.Button_Test.Name = "Button_Test";
            this.Button_Test.UseVisualStyleBackColor = false;
            this.Button_Test.Click += new System.EventHandler(this.Button_Test_Click);
            // 
            // TB_input
            // 
            resources.ApplyResources(this.TB_input, "TB_input");
            this.TB_input.Name = "TB_input";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // PB_nothing
            // 
            this.PB_nothing.Image = global::Pro_02.Properties.Resources.AU_Test;
            resources.ApplyResources(this.PB_nothing, "PB_nothing");
            this.PB_nothing.Name = "PB_nothing";
            this.PB_nothing.TabStop = false;
            this.PB_nothing.Click += new System.EventHandler(this.PB_nothing_Click);
            // 
            // PictureBox_Map
            // 
            this.PictureBox_Map.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.PictureBox_Map, "PictureBox_Map");
            this.PictureBox_Map.Name = "PictureBox_Map";
            this.PictureBox_Map.TabStop = false;
            this.PictureBox_Map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_Map_MouseMove);
            // 
            // PictureBox_Zoom
            // 
            this.PictureBox_Zoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PictureBox_Zoom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.PictureBox_Zoom, "PictureBox_Zoom");
            this.PictureBox_Zoom.Name = "PictureBox_Zoom";
            this.PictureBox_Zoom.TabStop = false;
            this.PictureBox_Zoom.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Zoom_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.TB_input);
            this.groupBox1.Controls.Add(this.Button_Test);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Peru;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Name = "label2";
            // 
            // Button_Leave
            // 
            this.Button_Leave.BackColor = System.Drawing.Color.Brown;
            this.Button_Leave.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Button_Leave, "Button_Leave");
            this.Button_Leave.ForeColor = System.Drawing.Color.White;
            this.Button_Leave.Name = "Button_Leave";
            this.Button_Leave.UseVisualStyleBackColor = false;
            this.Button_Leave.Click += new System.EventHandler(this.Button_Leave_Click);
            // 
            // Button_Help
            // 
            this.Button_Help.BackColor = System.Drawing.Color.Gold;
            this.Button_Help.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Button_Help, "Button_Help");
            this.Button_Help.ForeColor = System.Drawing.Color.Red;
            this.Button_Help.Name = "Button_Help";
            this.Button_Help.UseVisualStyleBackColor = false;
            this.Button_Help.Click += new System.EventHandler(this.Button_Help_Click);
            // 
            // Button_Restart
            // 
            this.Button_Restart.BackColor = System.Drawing.Color.Gold;
            this.Button_Restart.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Button_Restart, "Button_Restart");
            this.Button_Restart.ForeColor = System.Drawing.Color.Red;
            this.Button_Restart.Name = "Button_Restart";
            this.Button_Restart.UseVisualStyleBackColor = false;
            this.Button_Restart.Click += new System.EventHandler(this.Button_Restart_Click);
            // 
            // Button_Close
            // 
            this.Button_Close.BackColor = System.Drawing.Color.Gold;
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Button_Close, "Button_Close");
            this.Button_Close.ForeColor = System.Drawing.Color.Red;
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.UseVisualStyleBackColor = false;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // PB_nothing2
            // 
            this.PB_nothing2.Image = global::Pro_02.Properties.Resources.AU_Test02;
            resources.ApplyResources(this.PB_nothing2, "PB_nothing2");
            this.PB_nothing2.Name = "PB_nothing2";
            this.PB_nothing2.TabStop = false;
            this.PB_nothing2.DoubleClick += new System.EventHandler(this.PB_nothing2_DoubleClick);
            // 
            // Map
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Controls.Add(this.PB_nothing2);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.Button_Restart);
            this.Controls.Add(this.Button_Help);
            this.Controls.Add(this.Button_Leave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PictureBox_Zoom);
            this.Controls.Add(this.PB_nothing);
            this.Controls.Add(this.Text_GameInfo);
            this.Controls.Add(this.Text_DiceNumber);
            this.Controls.Add(this.GroupBox_Player4);
            this.Controls.Add(this.GroupBox_Player3);
            this.Controls.Add(this.GroupBox_Player2);
            this.Controls.Add(this.GroupBox_Player1);
            this.Controls.Add(this.Button_End);
            this.Controls.Add(this.Button_Dice);
            this.Controls.Add(this.PictureBox_Map);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Map";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox_Player1.ResumeLayout(false);
            this.GroupBox_Player1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_1P)).EndInit();
            this.GroupBox_Player2.ResumeLayout(false);
            this.GroupBox_Player2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_2P)).EndInit();
            this.GroupBox_Player3.ResumeLayout(false);
            this.GroupBox_Player3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_3P)).EndInit();
            this.GroupBox_Player4.ResumeLayout(false);
            this.GroupBox_Player4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_4P)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_nothing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Zoom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_nothing2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_Map;
        private System.Windows.Forms.Button Button_Dice;
        private System.Windows.Forms.Button Button_End;
        private System.Windows.Forms.GroupBox GroupBox_Player1;
        private System.Windows.Forms.PictureBox PB_1P;
        private System.Windows.Forms.RichTextBox Text_1PInfo;
        private System.Windows.Forms.Timer Timer_Process;
        private System.Windows.Forms.GroupBox GroupBox_Player2;
        private System.Windows.Forms.RichTextBox Text_2PInfo;
        private System.Windows.Forms.PictureBox PB_2P;
        private System.Windows.Forms.GroupBox GroupBox_Player3;
        private System.Windows.Forms.RichTextBox Text_3PInfo;
        private System.Windows.Forms.PictureBox PB_3P;
        private System.Windows.Forms.GroupBox GroupBox_Player4;
        private System.Windows.Forms.RichTextBox Text_4PInfo;
        private System.Windows.Forms.PictureBox PB_4P;
        private System.Windows.Forms.TextBox Text_DiceNumber;
        private System.Windows.Forms.RichTextBox Text_GameInfo;
        private System.Windows.Forms.Button Button_Test;
        private System.Windows.Forms.TextBox TB_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PB_nothing;
        private System.Windows.Forms.PictureBox PictureBox_Zoom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label Label_1P;
        private System.Windows.Forms.Label Label_2P;
        private System.Windows.Forms.Label Label_3P;
        private System.Windows.Forms.Label Label_4P;
        private System.Windows.Forms.Button Button_Leave;
        public System.Windows.Forms.ProgressBar Label_HPBar1;
        public System.Windows.Forms.ProgressBar Label_HPBar2;
        public System.Windows.Forms.ProgressBar Label_HPBar3;
        public System.Windows.Forms.ProgressBar Label_HPBar4;
        private System.Windows.Forms.Button Button_Help;
        private System.Windows.Forms.Button Button_Restart;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.PictureBox PB_nothing2;
    }
}

