using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpsls
{
    abstract class Player
    {
        public List<Gesture> gestures;
        public Gesture choice;
        public Player()
        {
            gestures = new List<Gesture>() {new Gesture("Rock", new List<string>(){ "Paper", "Spock" }), 
                new Gesture("Paper", new List<string>(){ "Scissors", "Lizard" }), 
                new Gesture("Scissors", new List<string>() { "Rock", "Spock" }), 
                new Gesture("Lizard", new List<string>() { "Rock", "Scissors" }), 
                new Gesture( "Spock", new List<string>() { "Lizard", "Paper" })};

        }

        public abstract void ChooseGesture();

    }
}
