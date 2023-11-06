using PatternMatching.Models;

namespace PatternMatching
{
    public class TypePattern
    {
        public static bool Process(object item) =>
            item switch
            {
                SomeType someType => someType.SomeMethod(),
                SomeOtherType someOtherType => someOtherType.SomeOtherMethod(),
                _ => throw new NotImplementedException(),
            };
    }
}
