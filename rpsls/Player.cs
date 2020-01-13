using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpsls
{
    abstract class Player
    {
        public List<string> gestures;
        public Player()
        {
            gestures = new List<string>() {"Rock", "Paper", "Scissors", "Lizard", "Spock"};

        }

        public abstract void ChooseGesture();

    }
}
