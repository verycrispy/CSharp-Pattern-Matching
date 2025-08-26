namespace PatternMatching
{
    public class RelationalPattern
    {
        public static string Classify(double percentage) =>
            percentage switch
            {
                < 0 => "Negative",
                > 100.0 => "Too high",
                double.NaN => "Unknown",
                _ => "Valid",
            };
    }
}
