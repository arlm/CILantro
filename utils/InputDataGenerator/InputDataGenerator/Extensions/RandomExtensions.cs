using System;

namespace InputDataGenerator.Extensions
{
    public static class RandomExtensions
    {
        public static int NextInt(this Random random)
        {
            return random.Next(int.MinValue, int.MaxValue);
        }

        public static long NextLong(this Random random)
        {
            var longBytes = new byte[8];
            random.NextBytes(longBytes);
            return BitConverter.ToInt64(longBytes, 0);
        }

        public static uint NextUInt(this Random random)
        {
            var uIntBytes = new byte[4];
            random.NextBytes(uIntBytes);
            return BitConverter.ToUInt32(uIntBytes, 0);
        }

        public static ulong NextULong(this Random random)
        {
            var uLongBytes = new byte[8];
            random.NextBytes(uLongBytes);
            return BitConverter.ToUInt64(uLongBytes, 0);
        }
    }
}