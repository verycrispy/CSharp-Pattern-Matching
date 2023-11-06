using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatching
{
    public class LogicalPattern
    {
        public static string Classify(decimal result) => result switch
        {
            < 3 => "Ruim onvoldoende",
            >= 3 and < 5.5M => "Onvoldoende",
            >= 5.5M and < 7 => "Voldoende",
            >= 7 => "Goed",
        };
    }
}
