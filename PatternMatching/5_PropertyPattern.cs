﻿using PatternMatching.Models;

namespace PatternMatching
{
    public class PropertyPattern
    {
        public static string Classify(string name) => name switch
        {
            { Length: <= 3 } => "korte naam",
            { Length: > 3 and <= 8 } => "naam gemiddelde lengte",
            { Length: > 8 } => "lange naam",
            _ => "invalide",
        };

        public static decimal CalculateDiscount(Order order) => order switch
        {
            { Items.Length: > 10, Cost: > 1000.00m } => 0.10m,
            { Items.Length: > 5, Cost: > 500.00m } => 0.05m,
            { Cost: > 250.00m } => 0.02m,
            null => throw new ArgumentNullException(nameof(order), "Order can't be null"),
            _ => 0m,
        };
    }
}
