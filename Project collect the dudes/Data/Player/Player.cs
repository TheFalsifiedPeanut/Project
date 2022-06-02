using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect_Dudes.Data.Player
{
    internal class Player
    {
        public string name;
        public int day;
        public int month;
        public int year;

        public Player(string name, int day, int month, int year)
        {
            this.name = name;
            this.day = day;
            this.month = month;
            this.year = year;
        }

    }
}
