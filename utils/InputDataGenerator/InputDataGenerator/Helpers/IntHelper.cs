using System;
using System.Collections.Generic;
using System.Linq;

namespace InputDataGenerator.Helpers
{
    public static class IntHelper
    {
        public static IEnumerable<int> GetRange(int min, int max)
        {
            return Enumerable.Range(min, max - min + 1);
        }

        public static IEnumerable<Tuple<int, int>> GetPairs(int firstMin, int firstMax, int secondMin, int secondMax)
        {
            var firstCount = firstMax - firstMin + 1;
            var secondCount = secondMax - secondMin + 1;

            var firstRange = Enumerable.Range(firstMin, firstCount);
            var secondRange = Enumerable.Range(secondMin, secondCount);

            var result = new List<Tuple<int, int>>();
            foreach(var first in firstRange)
            {
                foreach(var second in secondRange)
                {
                    result.Add(new Tuple<int, int>(first, second));
                }
            }

            return result;
        }
    }
}