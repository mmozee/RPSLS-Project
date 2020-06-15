using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;



namespace RPSLS
{
    public class AI : Player
    {
        public AI()

        {
            ChooseName();
        }

        public override void ChooseGesture()
        {
            Random RNG = new Random();

            int myRandom = RNG.Next(5);

          
            ChosenGesture = gestures[myRandom];
            Console.WriteLine("You have thrown: " + ChosenGesture);

            if (myRandom == 0)
            {
                Console.WriteLine("You have thrown" + gestures[0]);
            }


        }

        public override void ChooseName()
        {
            Console.WriteLine("Hello My name is Computerina");
            
        }
       
    }
}
