using System;

namespace TP_CSF_ValueTypes_Double
{
    /// <summary>
    /// DESC: Reads and writes out double.
    /// IN: n - double
    /// OUT: n
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine(n);
        }
    }
}