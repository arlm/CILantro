using System;

namespace InputDataGenerator.Extensions
{
    public static class RandomExtensions
    {
        public static byte NextByte(this Random random)
        {
            var byteBytes = new byte[1];
            random.NextBytes(byteBytes);
            return byteBytes[0];
        }

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

        public static short NextShort(this Random random)
        {
            var shortBytes = new byte[2];
            random.NextBytes(shortBytes);
            return BitConverter.ToInt16(shortBytes, 0);
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

        public static object NextOfType(this Random random, Type type)
        {
            if (type == typeof(byte)) return random.NextByte();
            if (type == typeof(int)) return random.NextInt();
            if (type == typeof(long)) return random.NextLong();
            if (type == typeof(short)) return random.NextShort();
            if (type == typeof(uint)) return random.NextUInt();
            if (type == typeof(ulong)) return random.NextULong();
            if (type == typeof(ushort)) return random.NextUShort();

            throw new ArgumentException($"Cannot generate next random value for type {type}.");
        }
    }
}