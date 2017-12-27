using System;

namespace TP_CSF_ValueTypes_Long
{
    /// <summary>
    /// DESC: Reads and writes out long integer.
    /// IN: n - long integer
    /// OUT: n
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(n);
        }
    }
}