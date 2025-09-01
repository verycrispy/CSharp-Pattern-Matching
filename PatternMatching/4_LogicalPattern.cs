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
        public static string IsItWeekend(DateTime dateTime) => dateTime.DayOfWeek switch
        {
            DayOfWeek.Saturday or DayOfWeek.Sunday => "It's weekend",
            DayOfWeek.Friday => "Almost weekend, hang in there",
            not DayOfWeek.Monday => "Nope! #LoveMyJob",
            _ => "Weekend just ended"
        };
    }
}
