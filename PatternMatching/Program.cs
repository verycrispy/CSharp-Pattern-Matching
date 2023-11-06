﻿using PatternMatching;
using PatternMatching.Models;

Console.WriteLine(SwitchNotation.OriginalNotation(1));
Console.WriteLine(SwitchNotation.ModernNotation(1));

Console.WriteLine(SwitchNotation.OriginalNotation(3));
Console.WriteLine(SwitchNotation.ModernNotation(3));

Console.WriteLine(RelationalPattern.Classify(1));

Console.WriteLine(LogicalPattern.Classify(8.5M));

Console.WriteLine(PropertyPattern.Classify("Christian"));
Console.WriteLine(PropertyPattern.Classify(null));

Console.WriteLine(PropertyPattern.CalculateDiscount(new Order(new OrderDetail[] { new OrderDetail("Test", 1) }, 100)));
Console.WriteLine(PropertyPattern.CalculateDiscount(new Order(new OrderDetail[] { new OrderDetail("Test", 1) }, 500)));


Console.WriteLine(VarPattern.TransformOrder(new Order(new OrderDetail[0], 500)).Cost);
Console.WriteLine(VarPattern.TransformOrder(new Order(new OrderDetail[] { new OrderDetail("Test", 400), new OrderDetail("Test", 200) }, 500)).Cost);

ListPattern.PrintNumberPatterns();

//Autheur
Console.WriteLine(ListPattern.ProcessName(new string[] { "Christian", "Peeters" }));
// Tussenvoegsel "de"
Console.WriteLine(ListPattern.ProcessName(new string[] { "Christian", "de", "Vries" }));
// Meerdere tussenvoegsels: van, de
Console.WriteLine(ListPattern.ProcessName(new string[] { "Christian", "van", "de", "Ven" }));
// empty
Console.WriteLine(ListPattern.ProcessName(new string[0]));
// null
Console.WriteLine(ListPattern.ProcessName(null)); 

string crapyCsv = @"11-01-2023, DEPOSIT,     Initial deposit,            2250.00
                    11-15-2023, DEPOSIT,     Refund,                      125.65
                    11-18-2023, DEPOSIT,     Paycheck,                    825.65
                    11-22-2023, WITHDRAWAL,  Debit,           Groceries,  255.73
                    11-01-2023, WITHDRAWAL,  #1102,           Rent, apt, 2100.00
                    11-02-2023, INTEREST,                                   0.65
                    11-07-2023, WITHDRAWAL,  Debit,           Movies,      12.57
                    11-15-2023, FEE,                                       5.55";

Console.WriteLine(ListPattern.ProcessCSV(crapyCsv).ToString());