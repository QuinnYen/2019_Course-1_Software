using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_02
{
    class Block
    {
        private Point location;

        public Block()
        {
            Location = new Point(80, 20);
        }

        public Block(Point loc)
        {
            Location = loc;
        }

        public Point Location
        {
            get { return location; }
            set { location = value; }
        }

        public virtual void ExcecuteAction(Player p)
        {

        }
    }
}
