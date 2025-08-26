namespace PatternMatching
{
    public class LogicalPattern
    {
        public static string Classify(decimal result) => result switch
        {
            < 3 => "Very poor",
            >= 3 and < 5.5M => "Insufficient",
            >= 5.5M and < 7 => "Pass",
            >= 7 and < 9 => "Good",
            >= 9 => "Excellent",
        };
    }
}
