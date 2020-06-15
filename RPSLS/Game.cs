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
        Player playerName;
        

        public List<Player> players;





        //constructor - Spawner
        public Game()
        { playerName = new Human();
            playerName = new AI();

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
            CompareGestures();
            GamePlayLoop();
            WinnerWinnerChickenDinner();

        }
        //Gameplay loop{}

        public void WinnerWinnerChickenDinner()
        {
            if (playerOne.score >= 2)
            {
                Console.WriteLine("Great Job" + playerOne.name + "You Win");
            }
            else
            {
                Console.WriteLine("Great Job" + playerTwo.name + "You Win");
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
                Console.WriteLine("Too bad" + playerTwo + "Rock CRUSHES Scissors\n You Lose!");
                Console.WriteLine(playerOne + "You have earned 1 point.");
                playerOne.score++;
            }
            else if (playerOne.ChosenGesture == "Rock" && playerTwo.ChosenGesture == "Lizard");
            {
                Console.WriteLine("Too bad" + playerTwo + "Rock CRUSHES Lizard\n You Lose!");
                Console.WriteLine(playerOne + "You have earned 1 point.");
                playerOne.score++;
            }

        }
        



        //member method - Can Do
        public void GamePlayLoop()
        {
            while (playerOne.score <= 2 || playerTwo.score <= 2)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();
            }


        }
      
        
     
    }


}


//foreach (Player player in players)
//            {
//                Console.WriteLine(();

            

