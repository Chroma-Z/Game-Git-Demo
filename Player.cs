using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Git_Demo
{
    class Player
    {
        public string Name { get; private set; }

        public Player(string name)
        {
            Name = name;
        }
    }
}
