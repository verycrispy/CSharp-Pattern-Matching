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

        public static bool ProcessConditionally(object item) =>
            item switch
            {
                SomeType someType when someType.SomeProperty <= 0 => false,
                SomeType someType => someType.SomeMethod(),
                SomeOtherType someOtherType => someOtherType.SomeOtherMethod(),
                _ => throw new NotImplementedException(),
            };
    }
}
