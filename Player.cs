using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

namespace Speakerbooth
{
    class Player
    {
        public string Name;
        public int Wins = 0;
        public int Life = 20;
        public int Poison = 0;

        public int Add1ToLife()
        {
            Life = Life + 1;
            return Life;
        }

        public int Add5ToLife()
        {
            Life = Life + 5;
            return Life;
        }

        public int Sub1FromLife()
        {
            Life = Life - 1;
            return Life;
        }

        public int Sub5FromLife()
        {
            Life = Life - 5;
            return Life;
        }
    }
}
