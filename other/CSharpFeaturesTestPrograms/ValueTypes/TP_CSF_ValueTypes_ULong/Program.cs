using System;

namespace TP_CSF_ValueTypes_ULong
{
    /// <summary>
    /// DESC: Reads and writes out unsigned long integer.
    /// IN: n - unsigned long integer
    /// OUT: n
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            Console.WriteLine(n);
        }
    }
}