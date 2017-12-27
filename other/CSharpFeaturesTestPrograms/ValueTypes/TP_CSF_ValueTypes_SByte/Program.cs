using System;

namespace TP_CSF_ValueTypes_SByte
{
    /// <summary>
    /// DESC: Reads and writes out signed byte.
    /// IN: n - signed byte
    /// OUT: n
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            sbyte n = sbyte.Parse(Console.ReadLine());
            Console.WriteLine(n);
        }
    }
}