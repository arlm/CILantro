using System;

namespace TP_CSF_ValueTypes_UShort
{
    /// <summary>
    /// DESC: Reads and writes out unsigned short integer.
    /// IN: n - unsigned short integer
    /// OUT: n
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ushort n = ushort.Parse(Console.ReadLine());
            Console.WriteLine(n);
        }
    }
}