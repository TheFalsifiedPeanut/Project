using Collect_Dudes.Data.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect_Dudes.Data.Groups
{
    internal class Agency : IIdentifier, IName
    {
        public ushort id { get; set; }
        public string name { get; set; }

        public Squad squad { get; set; }
        public int money { get; set; }

    }
}
