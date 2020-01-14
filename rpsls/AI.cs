using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpsls
{
    class AI : Player
    {
        
        public AI()
        {
            SetName();
        }
        public override void ChooseGesture()
        {
            Random random = new Random();
            int aiChoice = random.Next(5);
            choice = gestures[aiChoice];
            Console.WriteLine("The AI has chosen {0}", choice.name);
            
        }

        public override void SetName()
        {
            // Set AI name
            name = "The AI";
        }
    }
}
