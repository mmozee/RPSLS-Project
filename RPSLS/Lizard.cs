using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Lizard : Game_Object

    {
        public Lizard(string lizard, string poisons, string eats, string spock, string paper)

        {
            name = lizard;
            action[0] = poisons;
            action[1] = eats;
            beats[0] = spock;
            beats[1] = paper;
        }
    }

}
