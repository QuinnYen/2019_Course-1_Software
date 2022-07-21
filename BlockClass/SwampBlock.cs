using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_02
{
    class SwampBlock : Block
    {

        public SwampBlock(Point loc)
            : base(loc)
        {

        }

        public override void ExcecuteAction(Player p)
        {
            p.IsRested = true;
        }
    }
}
