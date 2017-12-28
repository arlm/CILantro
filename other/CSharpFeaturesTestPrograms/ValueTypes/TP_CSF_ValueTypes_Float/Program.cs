using System;

namespace TP_CSF_ValueTypes_Float
{
    /// <summary>
    /// DESC: Reads and writes out float.
    /// IN: n - float
    /// OUT: n
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            float n = float.Parse(Console.ReadLine());
            Console.WriteLine(n);
        }
    }
}