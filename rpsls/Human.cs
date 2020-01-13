using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpsls
{
    class Human : Player
    {
        public Human()
        {

        }
        public override void ChooseGesture()
        {
            Console.WriteLine("Please Choose A Gesture:");
            for (int i = 1; i <= gestures.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, gestures[i - 1]);
            }
            string input; // = Console.ReadLine();
            do
            {
                Console.WriteLine("Please choose a number between 1 and 5");
                input = Console.ReadLine();
            } while (input != "1" && input != "2" && input != "3" && input != "4" && input != "5");
            Console.WriteLine("Player chose {0}", gestures[Int32.Parse(input)-1]);
            
        }
    }
}
