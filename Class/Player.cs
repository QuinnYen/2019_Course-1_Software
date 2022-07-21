using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_02
{
    class Player
    {
        private Point location;
        private PictureBox image;
        private PlayerState state;
        private int block_index;
        private int player_index;
        private bool is_rested;

        public Player()
        {
            State = PlayerState.Normal;
            BlockIndex = 0;
            PlayerIndex = 0;
            IsRested = false;
            image = new PictureBox();
            image.Size = new Size(40, 40);
            image.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public Player(Image path, int index)
        {
            State = PlayerState.Normal;
            BlockIndex = 0;
            PlayerIndex = index;
            IsRested = false;
            image = new PictureBox();
            image.Size = new Size(40, 40);
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            image.Image = path;
        }

        public Point Location
        {
            get { return location; }
            set
            {
                location = value;
                Image.Location = new Point(location.X + 80, location.Y + 20);
            }
        }
        public PictureBox Image
        {
            get { return image; }
        }

        public PlayerState State
        {
            get { return state; }
            set { state = value; }
        }

        public int BlockIndex
        {
            get { return block_index; }
            set { block_index = value; }
        }

        public int PlayerIndex
        {
            get { return player_index; }
            set { player_index = value; }
        }
        public bool IsRested
        {
            get { return is_rested; }
            set { is_rested = value; }
        }
    }
}
