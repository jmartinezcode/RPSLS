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
            Console.WriteLine("{0}, please choose a gesture:", name);
            for (int i = 1; i <= gestures.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, gestures[i - 1].name);
            }
            string input; // = Console.ReadLine();
            do
            {
                Console.WriteLine("Please choose a number between 1 and 5");
                input = Console.ReadLine();
            } while (input != "1" && input != "2" && input != "3" && input != "4" && input != "5");
            choice = gestures[Int32.Parse(input) - 1];
            Console.WriteLine("{0} chose {1}", name, choice.name);
        }
        public override void SetName()
        {
            //set Human Player Name
            Console.WriteLine("Please enter a name:");
            name = Console.ReadLine();
            Console.WriteLine("Hi, {0}, let's get started!", name);
        }
    }
}
