using PatternMatching.Models;

namespace PatternMatching
{
    public class VarPattern
    {
        public static Order TransformOrder(Order order) => order switch
        {
            var (items, cost) when items.Sum(i => i.Amount) > cost => order with { Cost = items.Sum(i => i.Amount) },
            var (items, cost) when items.Length == 0 => order with { Cost = 0 },
            null => throw new ArgumentNullException(nameof(order), "Order can't be null"),
            _ => order,
        };
    }
}
