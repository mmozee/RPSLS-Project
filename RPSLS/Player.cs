﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {  // member variable - Has A
        public string name;
        public int score;
        public List<string> gestures;
        public string ChosenGesture;
       

        public Player()
        {  // constructor - Spawner
            gestures = new List<string>() { "Scissors", "Paper", "Rock", "Lizard", "Spock" };
            score = 0;
            



        }


        // member method - Can Do
        public abstract void ChooseGesture();
        public abstract void ChooseName();
       

     

    }
}       
        
    

