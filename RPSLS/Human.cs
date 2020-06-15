using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        public Human()
        {
            ChooseName();

        }

        public override void ChooseGesture()
        {
            Console.WriteLine("What object do you want?" + name);
            string userInput = Console.ReadLine();
            if (ChosenGesture == "Rock") 
            {
                Console.WriteLine("You have thrown" + gestures[2]);
            }

                //if (playerTwo == "Scissors")
                //{
                //    Console.WriteLine("Too bad Rock CRUSHES Scissors\n You Lose!");
                //    Console.WriteLine(P1 + "You have earned 1 point.");
                //    Console.WriteLine("You have" + score);
                //}
                //else if (P2 = "Lizard")
                //{
                //    Console.WriteLine("Too bad Rock CRUSHES Lizard\n You Lose!");
                //    Console.WriteLine(name + "You have earned 1 point.");
                //    Console.WriteLine("You have" + score);
                //}
                //else if (P2 = "Rock")
                //{
                //    Console.WriteLine("It's a Tie, choose again");
                //}
                //else
                //{
                //    Console.WriteLine("PlayerTwo wins and has earned 1 point.");
                //    Console.WriteLine("They have" + score);
                //    Console.WriteLine("It's Player Twos turn to select object");
                //}

            else if (ChosenGesture == "Paper") 
            {
                Console.WriteLine("You have thrown" + gestures[1]);
            }
                //if (playerTwo == "Rock")
                //{
                //    Console.WriteLine("Too bad Paper COVERS Rock\n You Lose!");
                //    Console.WriteLine(P1 + "You have earned 1 point.");
                //    Console.WriteLine("You have" + score);
                //}
                //else if (P2 = "Spock")
                //{
                //    Console.WriteLine("Too bad Paper DISPROVES Spock\n You Lose!");
                //    Console.WriteLine(name + "You have earned 1 point.");
                //    Console.WriteLine("You have" + score);
                //}
                //else if (P2 = "Paper")
                //{
                //    Console.WriteLine("It's a Tie, choose again");
                //}
                //else
                //{
                //    Console.WriteLine("PlayerTwo wins and has earned 1 point.");
                //    Console.WriteLine("They have" + score);
                //    Console.WriteLine("It's Player Twos turn to select object");
                //}


            else if (ChosenGesture == "Scissors")

            {
                Console.WriteLine("You have thrown" + gestures[0]);
            }
                //if (playerTwo == "Paper")
                //{
                //    Console.WriteLine("Too bad Scissors CUT Paper\n You Lose!");
                //    Console.WriteLine(P1 + "You have earned 1 point.");
                //    Console.WriteLine("You have" + score);
                //}
                //else if (P2 = "Lizard")
                //{
                //    Console.WriteLine("Too bad Scissors DECAPITATES Spock\n You Lose!");
                //    Console.WriteLine(name + "You have earned 1 point.");
                //    Console.WriteLine("You have" + score);
                //}
                //else if (P2 = "Scissors")
                //{
                //    Console.WriteLine("It's a Tie, choose again");
                //}
                //else
                //{
                //    Console.WriteLine("PlayerTwo wins and has earned 1 point.");
                //    Console.WriteLine("They have" + score);
                //    Console.WriteLine("It's Player Twos turn to select object");
                //}

            else if (ChosenGesture == "Lizard") 

            {
                Console.WriteLine("You have thrown" + gestures[1]);
            }

            //if (playerTwo == "Paper")
            //{
            //    Console.WriteLine("Too bad Lizard EATS Paper\n You Lose!");
            //    Console.WriteLine(P1 + "You have earned 1 point.");
            //    Console.WriteLine("You have" + score);
            //}
            //else if (P2 = "Spock")
            //{
            //    Console.WriteLine("Too bad Lizard POISONS Spock\n You Lose!");
            //    Console.WriteLine(name + "You have earned 1 point.");
            //    Console.WriteLine("You have" + score);
            //}
            //else if (P2 = "Lizard")
            //{
            //    Console.WriteLine("It's a Tie, choose again");
            //}
            //else
            //{
            //    Console.WriteLine("PlayerTwo wins and has earned 1 point.");
            //    Console.WriteLine("They have" + score);
            //    Console.WriteLine("It's Player Twos turn to select object");
            //}


            else if (ChosenGesture == "Spock") 

            {
                Console.WriteLine("You have thrown" + gestures[1]);
            }
            //if (playerTwo == "Rock")
            //{
            //    Console.WriteLine("Too bad Spock VAPORIZES Rock\n You Lose!");
            //    Console.WriteLine(P1 + "You have earned 1 point.");
            //    Console.WriteLine("You have" + score);
            //}
            //else if (P2 = "Scissors")
            //{
            //    Console.WriteLine("Too bad Spock SMASHES Scissors\n You Lose!");
            //    Console.WriteLine(name + "You have earned 1 point.");
            //    Console.WriteLine("You have" + score);
            //}
            //else if (P2 = "Spock")
            //{
            //    Console.WriteLine("It's a Tie, choose again");
            //}
            //else
            //{
            //    Console.WriteLine("PlayerTwo wins and has earned 1 point.");
            //    Console.WriteLine("They have" + score);
            //    Console.WriteLine("It's Player Twos turn to select object");

            //}
        }
 
        public override void ChooseName()

        {
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
        }
        public override void AssignmentOfNameToGame()
        {
            if (true)
            {

            }
        }
    }
}
