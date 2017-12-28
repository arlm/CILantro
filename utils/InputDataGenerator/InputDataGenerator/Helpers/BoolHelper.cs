using System.Collections.Generic;

namespace InputDataGenerator.Helpers
{
    public static class BoolHelper
    {
        public static IEnumerable<bool> GetAllValues()
        {
            return new List<bool>
            {
                true,
                false
            };
        }
    }
}