namespace PatternMatching
{
    public class SwitchNotation
    {

        public static string OriginalNotation(int number)
        {
            string outcome;
            switch (number)
            {
                case 1:
                    outcome = "one";
                    break;
                case 2:
                    outcome = "two";
                    break;
                default:
                    outcome = "unknown";
                    break;
            }
            return outcome;
        }

        public static string ModernNotationMethodBody(int number)
        {
            string outcome = number switch
            {
                1 => "one",
                2 => "two",
                _ => "unknown",
            };
            return outcome;
        }

        public static string ModernNotation(int number) =>
            number switch
            {
                1 => "one",
                2 => "two",
                _ => "unknown",
            };
    }
}
