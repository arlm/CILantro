using System;

namespace InputDataGenerator.Extensions
{
    public static class RandomExtensions
    {
        public static int NextInt(this Random random)
        {
            return random.Next(int.MinValue, int.MaxValue);
        }

        public static uint NextUInt(this Random random)
        {
            var uintBytes = new byte[4];
            random.NextBytes(uintBytes);
            return BitConverter.ToUInt32(uintBytes, 0);
        }
    }
}