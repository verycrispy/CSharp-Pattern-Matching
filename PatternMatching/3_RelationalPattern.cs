using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatching
{
    public class RelationalPattern
    {
        public static string Classify(double percentage) => percentage switch
        {
            < 0 => "Negative",
            > 100.0 => "Too high",
            double.NaN => "Unknown",
            _ => "Valid",
        };
    }
}
