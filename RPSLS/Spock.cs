using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Spock : Game_Object

    {
        public Spock(string spock, string smashes, string vaporizes, string scissors, string rock)

        {
            name = spock;
            action[0] = smashes;
            action[1] = vaporizes;
            beats[0] = scissors;
            beats[1] = rock;
        }
    }

}
