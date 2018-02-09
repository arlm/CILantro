using System;

namespace CILantro.Helpers.Convertions
{
    public static class ConvertHelper
    {
        private static byte[] GetBytes(object value, int length)
        {
            var valueBytes = new byte[0];

            if (value is int) valueBytes = BitConverter.GetBytes((int)value);
            if (value is uint) valueBytes = BitConverter.GetBytes((uint)value);

            var resultBytes = new byte[length];
            Array.Copy(valueBytes, resultBytes, valueBytes.Length);

            return resultBytes;
        }

        public static uint ToUnsignedInt(object value)
        {
            var resultBytes = GetBytes(value, 4);
            return BitConverter.ToUInt32(resultBytes, 0);
        }

        public static long ToLong(object value)
        {
            var resultBytes = GetBytes(value, 8);
            return BitConverter.ToInt64(resultBytes, 0);
        }

        public static ulong ToUnsignedLong(object value)
        {
            var resultBytes = GetBytes(value, 8);
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