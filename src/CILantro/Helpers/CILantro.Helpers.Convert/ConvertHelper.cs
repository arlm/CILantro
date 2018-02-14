using System;

// TODO - REFAKTORING

namespace CILantro.Helpers.Convertions
{
    public static class ConvertHelper
    {
        private static byte[] GetBytes(object value, int length, bool signedResult)
        {
            var valueBytes = new byte[0];
            var negativeValue = false;

            if (value is int)
            {
                valueBytes = BitConverter.GetBytes((int)value);
                negativeValue = ((int)value) < 0;
            }
            if (value is long)
            {
                valueBytes = BitConverter.GetBytes((long)value);
                negativeValue = ((long)value) < 0;
            }
            if (value is short)
            {
                valueBytes = BitConverter.GetBytes((short)value);
                negativeValue = ((short)value) < 0;
            }
            if (value is uint) valueBytes = BitConverter.GetBytes((uint)value);

            var itemsToCopy = Math.Min(length, valueBytes.Length);

            var resultBytes = new byte[length];
            if(negativeValue && signedResult)
            {
                for (int i = 0; i < resultBytes.Length; i++) resultBytes[i] = 0xFF;
            }

            Array.Copy(valueBytes, resultBytes, itemsToCopy);

            return resultBytes;
        }

        public static int ToInt(object value)
        {
            var resultBytes = GetBytes(value, 4, true);
            return BitConverter.ToInt32(resultBytes, 0);
        }

        public static long ToLong(object value)
        {
            var resultBytes = GetBytes(value, 8, true);
            return BitConverter.ToInt64(resultBytes, 0);
        }

        public static sbyte ToSByte(object value)
        {
            var resultBytes = GetBytes(value, 1, true);
            return (sbyte)resultBytes[0];
        }

        public static short ToShort(object value)
        {
            var resultBytes = GetBytes(value, 2, true);
            return BitConverter.ToInt16(resultBytes, 0);
        }

        public static uint ToUnsignedInt(object value)
        {
            var resultBytes = GetBytes(value, 4, false);
            return BitConverter.ToUInt32(resultBytes, 0);
        }

        public static ulong ToUnsignedLong(object value)
        {
            var resultBytes = GetBytes(value, 8, false);
            return BitConverter.ToUInt64(resultBytes, 0);
        }

        public static object ConvertIfPossible(object value, Type conversionType)
        {
            try
            {
                var result = Convert.ChangeType(value, conversionType);
                return result;
            }
            catch(Exception) {}

            if (conversionType == typeof(uint)) return ToUnsignedInt(value);
            if (conversionType == typeof(long)) return ToLong(value);
            if (conversionType == typeof(ulong)) return ToUnsignedLong(value);

            return value;
        }
    }
}