using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace InputDataGenerator.Extensions
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<Action<StreamWriter>> SelectCreateInputActions<T>(this IEnumerable<T> enumerable, Func<T, Action<StreamWriter>> selector)
        {
            return enumerable.Select(selector);
        }
    }
}