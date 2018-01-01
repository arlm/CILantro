using System;

namespace InputDataGenerator.Extensions
{
    public static class RandomExtensions
    {
        public static bool NextBool(this Random random)
        {
            return random.Next(2) == 1;
        }

        public static byte NextByte(this Random random)
        {
            var byteBytes = new byte[1];
            random.NextBytes(byteBytes);
            return byteBytes[0];
        }

        public static decimal NextDecimal(this Random random)
        {
            var scale = (byte)random.Next(29);
            var sign = random.NextBool();
            return new decimal(random.NextInt(), random.NextInt(), random.NextInt(), sign, scale);
        }

        public static double NextDouble(this Random random)
        {
            var doubleBytes = new byte[8];
            random.NextBytes(doubleBytes);
            return BitConverter.ToDouble(doubleBytes, 0);
        }

        public static float NextFloat(this Random random)
        {
            var floatBytes = new byte[4];
            random.NextBytes(floatBytes);
            return BitConverter.ToSingle(floatBytes, 0);
        }

        public static int NextInt(this Random random)
        {
            var firstBits = random.Next(0, 1 << 4) << 28;
            var lastBits = random.Next(0, 1 << 28);
            return firstBits | lastBits;
        }

        public static long NextLong(this Random random)
        {
            var longBytes = new byte[8];
            random.NextBytes(longBytes);
            return BitConverter.ToInt64(longBytes, 0);
        }

        public static sbyte NextSByte(this Random random)
        {
            var sByteValue = random.Next(sbyte.MinValue, sbyte.MaxValue + 1);
            return (sbyte)sByteValue;
        }

        public static short NextShort(this Random random)
        {
            var shortBytes = new byte[2];
            random.NextBytes(shortBytes);
            return BitConverter.ToInt16(shortBytes, 0);
        }

        public static char NextStandardChar(this Random random)
        {
            var charNumber = random.Next(20, 127);
            return (char)charNumber;
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

        public static ushort NextUShort(this Random random)
        {
            var uShortBytes = new byte[2];
            random.NextBytes(uShortBytes);
            return BitConverter.ToUInt16(uShortBytes, 0);
        }
    }
}