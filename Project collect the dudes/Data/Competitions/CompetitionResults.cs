using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect_Dudes.Data.Competitions
{
    internal class CompetitionResults
    {
        public ushort teamID { get; set; }

        public int wins { get; set; }
        public int draws { get; set; }
        public int losses { get; set; }
        public int points { get; set; }
        



        public CompetitionResults(ushort teamID)
        {
            this.teamID = teamID;
        }
    }
}