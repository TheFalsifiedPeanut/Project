using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect_Dudes.Data.Competitions
{
    internal class CompetitionResults
    {
        ushort teamID { get; set; }

        int wins { get; set; }
        int draws { get; set; }
        int losses { get; set; }
        int points { get; set; }
        



        public CompetitionResults(ushort teamID)
        {
            this.teamID = teamID;
        }
    }
}
