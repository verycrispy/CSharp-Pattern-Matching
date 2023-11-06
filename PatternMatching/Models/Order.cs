namespace PatternMatching.Models
{
    public record Order(OrderDetail[] Items, decimal Cost);
    public record OrderDetail(string Product, int Amount);
}
