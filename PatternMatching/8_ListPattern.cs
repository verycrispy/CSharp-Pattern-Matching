using PatternMatching.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatching
{
    public class ListPattern
    {
        public static void PrintNumberPatterns()
        {
            int[] numbers = { 1, 2, 3 };

            Console.WriteLine(numbers is [1, 2, 3]);  // True
            Console.WriteLine(numbers is [1, 2, 4]);  // False
            Console.WriteLine(numbers is [1, 2, 3, 4]);  // False
            Console.WriteLine(numbers is [0 or 1, <= 2, >= 3]);  // True
            Console.WriteLine(numbers is [_, <= 2, >= 3]);  // True
        }

        public static string ProcessName(string[] data) => data switch
        {
            ["Christian", "Peeters"] => "Auteur",
            [_, "de", .. ] => "Tussenvoegsel \"de\"",
            [_, .. var tussenvoegsels, _] => $"Meerdere tussenvoegsels: {string.Join(", ", tussenvoegsels)}",
            [] => "empty",
            not [] => "null",
        };

        public static decimal ProcessCSV(string data)
        {
            decimal balance = 0m;
            foreach (string transaction in data.Split(Environment.NewLine))
            {
                balance += transaction.Split(',', StringSplitOptions.TrimEntries) switch
                {
                    [_, "DEPOSIT", _, var amount] => decimal.Parse(amount, CultureInfo.InvariantCulture),
                    [_, "WITHDRAWAL", .., var amount] => -decimal.Parse(amount, CultureInfo.InvariantCulture),
                    [_, "INTEREST", var amount] => decimal.Parse(amount, CultureInfo.InvariantCulture),
                    [_, "FEE", var fee] => -decimal.Parse(fee, CultureInfo.InvariantCulture),
                    _ => throw new InvalidOperationException($"Record {string.Join(", ", transaction)} is not in the expected format!"),
                };
                Console.WriteLine($"New balance: {balance:C}");
            }
            return balance;
        }
    }
}
