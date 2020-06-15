using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Scissors : Game_Object
    {
          public Scissors(string scissors, string cuts, string decapitates, string paper, string lizard)

            {
             name = scissors;
             action[0] = cuts;
             action[1] = decapitates;
             beats[0] = paper;
             beats[1] = lizard;
            }
    }
}

