using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_02
{
    public enum PlayerState
    {
        Normal,
        Dead
    }

    public enum GameState
    {
        Initial,
        Walking,
        Stopped,
        jail
    }
    
    public enum CellState
    {
        Yellow, Blue, Purple, Red,
        Swamp, Trap, Fox, Monkey, Lion, Man,
        Evented, Started
    }
}
