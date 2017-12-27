using System;

namespace TP_CSF_ValueTypes_UInt
{
    /// <summary>
    /// DESC: Reads and writes out unsigned integer.
    /// IN: n - unsigned integer
    /// OUT: n
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine(n);
        }
    }
}