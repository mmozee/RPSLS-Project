using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{  // member variable - Has A
    public class Game
    {
        Player playerOne;
        Player playerTwo;
 
        //constructor - Spawner
        public Game()
        {
 
        }


        public void ChoosePlayers()
        {
            Console.WriteLine("Is this one or two players");
            string userInput = Console.ReadLine();
            if (userInput == "one")
            {
                playerOne = new Human();
                playerTwo = new AI();
            }
            else if (userInput == "two")
            {
                playerOne = new Human();
                playerTwo = new Human();
            }

        }

        public void RunGame()
        {
            Welcome();
            ChoosePlayers();
           
            
            
            
            
            GamePlayLoop();
            WinnerWinnerChickenDinner();

        }
        //Gameplay loop{}

        public void WinnerWinnerChickenDinner()
        {
            if (playerOne.score >= 2)
            {
                Console.WriteLine("Great Job" + playerOne.name + "You Win");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Great Job" + playerTwo.name + "You Win");
                Console.ReadLine();

            }
        }
        public void Welcome()
        {
            Console.WriteLine("Welcome ya'll to the new improved Rock, Paper, Scissors Game\n I do need to mention this game is not for the faint of heart because it will be played to the\n DEATH!!");
        }



        public void CompareGestures()
        {   
            if (playerOne.ChosenGesture == "Rock" && playerTwo.ChosenGesture == "Scissors")
            {
                Console.WriteLine("Too bad " + playerTwo.name + " Rock CRUSHES Scissors\n You Lose!");
                Console.WriteLine("You have earned 1 point.");
                playerOne.score++;
            }
            else if (playerOne.ChosenGesture == "Rock" && playerTwo.ChosenGesture == "Lizard")
            {
                Console.WriteLine("Too bad " + playerTwo.name + " Rock CRUSHES Lizard\n You Lose!");
                Console.WriteLine("You have earned 1 point.");
                playerOne.score++;
            }
            else if (playerOne.ChosenGesture == "Rock" && playerTwo.ChosenGesture == "Paper")
            {
                Console.WriteLine("Uh Oh " + playerOne.name + " Paper COVERS Rock\n You Lose!");
                Console.WriteLine("You have earned 1 point.");
                playerTwo.score++;
            }
            else if (playerOne.ChosenGesture == "Rock" && playerTwo.ChosenGesture == "Spock")
            {
                Console.WriteLine("Uh Oh " + playerOne.name + " Spock VAPORIZES Rock\n You Lose!");
                Console.WriteLine("You have earned 1 point.");
                playerTwo.score++;
            }
            else if (playerOne.ChosenGesture == "Rock" && playerTwo.ChosenGesture == "Rock")
            {
                Console.WriteLine("Rats! Rock matches Rock\n We Tied!");
                Console.WriteLine("No Points!");

            }
            else if (playerOne.ChosenGesture == "Paper" && playerTwo.ChosenGesture == "Scissors")
            {
                Console.WriteLine("Uh Oh " + playerOne.name + " Scissors CUT Paper\n You Lose!");
                Console.WriteLine("You have earned 1 point.");
                playerTwo.score++;
            }
            else if (playerOne.ChosenGesture == "Paper" && playerTwo.ChosenGesture == "Lizard")
            {
                Console.WriteLine("Uh Oh " + playerOne.name + " Lizard EATS Paper\n You Lose!");
                Console.WriteLine("You have earned 1 point.");
                playerTwo.score++;
            }
            else if (playerOne.ChosenGesture == "Paper" && playerTwo.ChosenGesture == "Rock")
            {
                Console.WriteLine("Too bad " + playerTwo.name + " Paper COVERS Rock\n You Lose!");
                Console.WriteLine("You have earned 1 point.");
                playerOne.score++;
            }
            else if (playerOne.ChosenGesture == "Paper" && playerTwo.ChosenGesture == "Spock")
            {
                Console.WriteLine("Uh Oh " + playerOne.name + " Spock DISPROVES Paper\n You Lose!");
                Console.WriteLine("You have earned 1 point.");
                playerTwo.score++;
            }
            else if (playerOne.ChosenGesture == "Paper" && playerTwo.ChosenGesture == "Paper")
            {
                Console.WriteLine("Rats! Paper matches Paper\n We Tied!");
                Console.WriteLine("No Points!");

            }
            else if (playerOne.ChosenGesture == "Scissors" && playerTwo.ChosenGesture == "Paper")
            {
                Console.WriteLine("Too bad " + playerTwo.name + " Scissors CUT Paper\n You Lose!");
                Console.WriteLine("You have earned 1 point.");
                playerOne.score++;
            }
            else if (playerOne.ChosenGesture == "Scissors" && playerTwo.ChosenGesture == "Lizard")
            {
                Console.WriteLine("Too bad " + playerTwo.name + " Scissors DECAPITATES Lizard\n You Lose!");
                Console.WriteLine("You have earned 1 point.");
                playerOne.score++;
            }
            else if (playerOne.ChosenGesture == "Scissors" && playerTwo.ChosenGesture == "Rock")
            {
                Console.WriteLine("Uh Oh " + playerOne.name + " Rock CRUSHES Scissors\n You Lose!");
                Console.WriteLine("You have earned 1 point.");
                playerTwo.score++;
            }
            else if (playerOne.ChosenGesture == "Scissors" && playerTwo.ChosenGesture == "Spock")
            {
                Console.WriteLine("Uh Oh " + playerOne.name + " Spock SMASHES Scissors\n You Lose!");
                Console.WriteLine("You have earned 1 point.");
                playerTwo.score++;
            }
            else if (playerOne.ChosenGesture == "Scissors" && playerTwo.ChosenGesture == "Scissors")
            {
                Console.WriteLine("Rats! Scissors matches Scissors\n We Tied!");
                Console.WriteLine("No Points!");
            }
            else if (playerOne.ChosenGesture == "Lizard" && playerTwo.ChosenGesture == "Paper")
            {
                Console.WriteLine("Too bad " + playerTwo.name + " Lizard EATS Paper\n You Lose!");
                Console.WriteLine("You have earned 1 point.");
                playerOne.score++;
            }
            else if (playerOne.ChosenGesture == "Lizard" && playerTwo.ChosenGesture == "Scissors")
            {
                Console.WriteLine("Uh Oh " + playerOne.name + " Scissors DECAPITATES Lizard\n You Lose!");
                Console.WriteLine("You have earned 1 point.");
                playerTwo.score++;
            }
            else if (playerOne.ChosenGesture == "Lizard" && playerTwo.ChosenGesture == "Rock")
            {
                Console.WriteLine("Uh Oh " + playerOne.name + " Rock CRUSHES Lizard\n You Lose!");
                Console.WriteLine("You have earned 1 point.");
                playerTwo.score++;
            }
            else if (playerOne.ChosenGesture == "Lizard" && playerTwo.ChosenGesture == "Spock")
            {
                Console.WriteLine("Too bad " + playerTwo.name + " Lizard POISONS Spock\n You Lose!");
                Console.WriteLine("You have earned 1 point.");
                playerOne.score++;
            }
            else if (playerOne.ChosenGesture == "Lizard" && playerTwo.ChosenGesture == "Lizard")
            {
                Console.WriteLine("Rats! Lizard matches Lizard\n We Tied!");
                Console.WriteLine("No Points!");
            }
            else if (playerOne.ChosenGesture == "Spock" && playerTwo.ChosenGesture == "Paper")
            {
                Console.WriteLine("Too bad " + playerTwo.name + " Spock DISPROVES Paper\n You Lose!");
                Console.WriteLine("You have earned 1 point.");
                playerOne.score++;
            }
            else if (playerOne.ChosenGesture == "Spock" && playerTwo.ChosenGesture == "Scissors")
            {
                Console.WriteLine("Too bad " + playerTwo.name + " Spock SMASHES Scissors\n You Lose!");
                Console.WriteLine("You have earned 1 point.");
                playerOne.score++;
            }
            else if (playerOne.ChosenGesture == "Spock" && playerTwo.ChosenGesture == "Rock")
            {
                Console.WriteLine("Too bad " + playerTwo.name + " Spock VAPORIZES Rock\n You Lose!");
                Console.WriteLine("You have earned 1 point.");
                playerOne.score++;
            }
            else if (playerOne.ChosenGesture == "Spock" && playerTwo.ChosenGesture == "Lizard")
            {
                Console.WriteLine("Uh Oh " + playerOne.name + " Lizard POISONS Spock\n You Lose!");
                Console.WriteLine("You have earned 1 point.");
                playerTwo.score++;
            }
            else if (playerOne.ChosenGesture == "Spock" && playerTwo.ChosenGesture == "Spock")
            {
                Console.WriteLine("Rats! Spock matches Spock\n We Tied!");
                Console.WriteLine("No Points!");
            }
            else
            {
                Console.WriteLine("Wow! Someone screwed the pooch and put in the wrong info so ERROR!!! Choose again Special Person.");
            }
        }
        //member method - Can Do
        public void GamePlayLoop()
        {
            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();
                CompareGestures();
            }

        }




    }


}


//foreach (Player player in players)
//            {
//                Console.WriteLine(();

            

