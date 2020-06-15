using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Rock : Game_Object
    {
        public Rock(string rock, string crushes, string crushess, string scissors, string lizard)
        {
            name = rock;
            action[0] = crushes;
            action[1] = crushess;    
            beats[0] = scissors;
            beats[1] = lizard;
        }
    }
}
