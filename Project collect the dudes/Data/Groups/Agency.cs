using Collect_Dudes.Data.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect_Dudes.Data.Groups
{
    internal class Agency : IIdentifier, IName, IStarLevel
    {
        public byte starLevel { get; set; }
        public ushort id { get; set; }
        public string name { get; set; }

        public Squad squad { get; set; }
        public int money { get; set; }

        public Agency(ushort id, string name, Squad squad, int money, byte starLevel)
        {
            this.id = id;
            this.name = name;
            this.squad = squad;
            this.money = money;
            this.starLevel = starLevel;
        }
    }
}
