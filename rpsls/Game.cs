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
            string userInput = ChooseNumberOfUsers();
            SetPlayers(userInput);
            CheckCurrentRound();
            DeclareWinner();
        }
        public void WelcomeToTheGame()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock");
            Console.WriteLine("");
            Console.WriteLine("We're going to play best of 3");
            Console.WriteLine("");
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
                player1.SetName();
                player2.SetName();
            }
            else
            {
                Console.WriteLine("You've chosen multiplayer game");
                player1 = new Human();
                player2 = new Human();
                player1.SetName();
                player2.SetName();
            }
        }
        public void RunGame()
        {
            player1.ChooseGesture();
            player2.ChooseGesture();
            CompareGestures();
            DisplayScore();
        }
        public void CompareGestures()
        {
            if (player1.choice.name == player2.choice.name)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (player1.choice.losesTo.Contains(player2.choice.name))
            {
                Console.WriteLine("{0} beats {1}! {2} won this round!", player2.choice.name, player1.choice.name, player2.name);
                player2.score++; 
            }
            else
            {
                Console.WriteLine("{0} beats {1}! {2} won this round!", player1.choice.name, player2.choice.name, player1.name);
                player1.score++;
            }
        }
        public void DisplayScore()
        {
            Console.WriteLine("The Score is {0} - {1}", player1.score, player2.score);
            Console.ReadLine();
        }
        public void CheckCurrentRound()
        {
            do
            {
                RunGame();
            } while (player1.score != 2 && player2.score != 2);
        }
        public void DeclareWinner()
        {
            if (player1.score == 2)
            {
                Console.WriteLine("{0} won! Great job", player1.name);
            }
            else if (player2.score == 2)
            {
                Console.WriteLine("{0} won!", player2.name);
            }
        }
        public void PlayAgainPrompt()
        {
            string playAgain;
            do
            {
                Console.WriteLine("Would you like to play again? (y or n)");
                playAgain = Console.ReadLine();
            } while (playAgain != "y" && playAgain != "n");
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
