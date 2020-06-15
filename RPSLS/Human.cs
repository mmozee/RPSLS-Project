using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {   // member variable - Has 
       
        public Human()
        {
            //Game playerOne = new Game();
            //Game playerTwo = new Game();

            ChooseName();

        }

        public override void ChooseGesture()
        {
            bool isValid = false;
            while(isValid == false)
            {
                Console.WriteLine("What object do you want,  ?" + name);
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "rock")
                {
                    Console.WriteLine("You have thrown " + gestures[2]);
                    ChosenGesture = gestures[2];
                    isValid = true;
                   
                }

                else if (userInput == "paper")
                {
                    Console.WriteLine("You have thrown " + gestures[1]);
                    ChosenGesture = gestures[1];
                    isValid = true;
                }
                else if (userInput == "scissors")

                {
                    Console.WriteLine("You have thrown " + gestures[0]);
                    ChosenGesture = gestures[0];
                    isValid = true;
                }

                else if (userInput == "lizard")

                {
                    Console.WriteLine("You have thrown " + gestures[3]);
                    ChosenGesture = gestures[3];
                    isValid = true;
                }

                else if (userInput == "spock")

                {
                    Console.WriteLine("You have thrown " + gestures[4]);
                    ChosenGesture = gestures[4];
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Uhmmm, Really wrong answer!  Choose Again and let's get it right this time");


                }
            }
          
           
        }
 
        public override void ChooseName()

        {
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
        }
       
    }
}
