using System;

namespace TP_CSF_Enums_EnumByte
{
    public enum ByteEnum : byte
    {
        Zero,
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten
    }

    /// <summary>
    /// DESC: Reads byte and writes appropriate enum value.
    /// 
    /// IN: b - byte
    /// 
    /// OUT: enum value for b
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var b = byte.Parse(Console.ReadLine());
            var e = Enum.Parse(typeof(ByteEnum), b.ToString());
            Console.WriteLine(e);
        }
    }
}