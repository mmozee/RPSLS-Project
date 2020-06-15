using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Paper : Game_Object
    {   public Paper(string paper, string covers, string disproves, string rock, string spock)

        {
            name = paper;
            action[0] = covers;
            action[1] = disproves;
            beats[0] = rock;
            beats[1] = spock;
        }
    }
}
