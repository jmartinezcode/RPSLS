using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpsls
{
    class Game
    {
        public Game()
        {
            WelcomeToTheGame();
            DoesPlayerNeedToSeeRules();
            NumberOfUsers();
        }
        public void WelcomeToTheGame()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock");
            Console.WriteLine("Do you need to see the rules? (y/n)");
        }

        public void DoesPlayerNeedToSeeRules()
        {
            string seeRules = Console.ReadLine();
            switch (seeRules.ToLower())
            {
                case "y":
                    DisplayTheRules();
                    break;
                case "n":
                    Console.WriteLine("Great! You already know the rules!");
                    break;
                default:
                    Console.WriteLine("Please enter y or n");
                    break;
            }     
        }
        public void DisplayTheRules()
        {
            Console.WriteLine("The rules are simple:");
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");                                 
        }

        public void NumberOfUsers()
        {
            Console.WriteLine("How many players? (1 or 2)?");

        }
    }

    
}
