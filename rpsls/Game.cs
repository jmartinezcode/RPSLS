using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpsls
{
    class Game
    {
        Player player1;
        Player player2;
        
        public Game()
        {
            WelcomeToTheGame();
            //DoesPlayerNeedToSeeRules();
            //ChooseNumberOfUsers();
            RunGame();
        }
        public void WelcomeToTheGame()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock");
            Console.WriteLine("");
            //Console.WriteLine("Do you need to see the rules? (y/n)");
            DisplayTheRules();
        }

        public void DisplayTheRules()
        {
            Console.WriteLine("The rules are simple:");
            Console.WriteLine("=============================");
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
            Console.WriteLine("");
            Console.ReadLine();
        }

        public string ChooseNumberOfUsers()
        {
            string numberUsers; //= Console.ReadLine();
            do
            {
                Console.WriteLine("Please choose 1 or 2 Users");
                numberUsers = Console.ReadLine();
            } while (numberUsers != "1" && numberUsers != "2");
            return numberUsers;            
        }
        public void SetPlayers(string numberUsers)
        {
            if (numberUsers == "1")
            {
                Console.WriteLine("You've chosen single player game");
                player1 = new Human();
                player2 = new AI();
                //player1.ChooseGesture();
                //player2.ChooseGesture();
                //Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You've chosen multiplayer game");
                player1 = new Human();
                player2 = new Human();
                //player1.ChooseGesture();
                //player2.ChooseGesture();
                //Console.ReadLine();
            }
        }
        public void RunGame()
        {
            string userInput = ChooseNumberOfUsers();
            SetPlayers(userInput);
            player1.ChooseGesture();
            player2.ChooseGesture();
            CompareGestures();
        }
        public void CompareGestures()
        {
            if (player1.choice == player2.choice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (player1.choice.losesTo.Contains(player2.choice.name))
            {
                Console.WriteLine("{0} beats {1}! Player 1 loses", player2.choice.name, player1.choice.name);
            }
            else
            {
                Console.WriteLine("{0} beats {1}! Player 2 loses", player1.choice.name, player2.choice.name);
            }
        }
        public void DisplayScore()
        {

        }
        public void CheckCurrentRound()
        {

        }
        public void DeclareWinner()
        {

        }

        //public void DoesPlayerNeedToSeeRules()
        //{
        //    string seeRules;
        //    do
        //    {
        //        Console.WriteLine("Please enter y or n");
        //        seeRules = Console.ReadLine();
        //    } while (seeRules != "y" && seeRules != "n") ;
        //    if (seeRules == "y")
        //    {
        //        DisplayTheRules();
        //    }
        //    else
        //    {
        //        Console.WriteLine("Great! You already know the rules!");
        //        Console.ReadLine();
        //    }
        //}


    }


}
