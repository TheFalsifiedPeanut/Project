using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect_Dudes.Data.Information
{
    internal interface IAge
    {
        int day { get; set; }
        int month { get; set; }
        int year { get; set; }
    }
}
