using System.Collections.Generic;
using System.Linq;

namespace InputDataGenerator.Helpers
{
    public static class ShortHelper
    {
        public static IEnumerable<short> GetRange(short min, short max)
        {
            return Enumerable.Range(min, max - min + 1).Select(x => (short)x);
        }
    }
}