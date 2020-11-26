using System;
using System.Collections.Generic;
using System.Text;

namespace AdditionFeatures310
{
    class Name
    {
        public Name(string player) : this(player, 10)
        {
        }

        public Name(string player, int number)
        {
            Player = player;
            Number = number;
        }
        public string Player;
        public int Number;
    }
}
