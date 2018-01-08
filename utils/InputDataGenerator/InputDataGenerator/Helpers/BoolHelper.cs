using System;
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

        public static IEnumerable<Tuple<bool, bool>> GetAllPairs()
        {
            var first = GetAllValues();
            var second = GetAllValues();

            var result = new List<Tuple<bool, bool>>();

            foreach(var f in first)
            {
                foreach(var s in second)
                {
                    result.Add(new Tuple<bool, bool>(f, s));
                }
            }

            return result;
        }
    }
}