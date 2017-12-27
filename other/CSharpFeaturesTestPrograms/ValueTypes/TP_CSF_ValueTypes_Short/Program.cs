using System;

namespace TP_CSF_ValueTypes_Short
{
    /// <summary>
    /// DESC: Reads and writes out short integer.
    /// IN: n - short integer
    /// OUT: n
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());
            Console.WriteLine(n);
        }
    }
}