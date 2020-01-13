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
            string seeRules;
            do
            {
                Console.WriteLine("Please enter y or n");
                seeRules = Console.ReadLine();
            } while (seeRules != "y" && seeRules != "n") ;
            if (seeRules == "y")
            {
                DisplayTheRules();
            }
            else
            {
                Console.WriteLine("Great! You already know the rules!");
                Console.ReadLine();
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
            Console.ReadLine();
        }

        public void NumberOfUsers()
        {
            
            string numberUsers; //= Console.ReadLine();
            do
            {
                Console.WriteLine("Please choose 1 or 2");
                numberUsers = Console.ReadLine();
            } while (numberUsers != "1" && numberUsers != "2");
            if (numberUsers == "1")
            {
                Console.WriteLine("You've chosen single player game");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You've chosen multiplayer game");
                Console.ReadLine();
            }
        }

        public void ChooseGesture()
        {

        }
    }

    
}
