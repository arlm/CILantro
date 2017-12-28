using System;

namespace TP_CSF_ValueTypes_Decimal
{
    /// <summary>
    /// DESC: Reads and writes out decimal.
    /// IN: n - decimal
    /// OUT: n
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            Console.WriteLine(n);
        }
    }
}