using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpsls
{
    class AI : Player
    {
        Random random;
        public AI()
        {
            random = new Random();
        }
        public override void ChooseGesture()
        {
            int aiChoice = random.Next(5);
            Console.WriteLine("The AI has chosen {0}", gestures[aiChoice]);
            
        }
    }
}
