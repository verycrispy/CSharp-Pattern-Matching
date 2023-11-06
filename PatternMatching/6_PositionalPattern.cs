namespace PatternMatching
{
    public class PositionalPattern
    {
        public static decimal GetGroupTicketPriceDiscount(int groupSize, DateTime visitDate)
            => (groupSize, visitDate.DayOfWeek) switch
            {
                ( <= 0, _) => throw new ArgumentException("Group size must be positive."),
                (_, DayOfWeek.Saturday or DayOfWeek.Sunday) => 0.0m,
                ( >= 5 and < 10, DayOfWeek.Monday) => 20.0m,
                ( >= 10, DayOfWeek.Monday) => 30.0m,
                ( >= 5 and < 10, _) => 12.0m,
                ( >= 10, _) => 15.0m,
                _ => 0.0m,
            };
    }
}
