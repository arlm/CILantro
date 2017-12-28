using System;

namespace TP_CSF_ValueTypes_Bool
{
    /// <summary>
    /// DESC: Reads and writes out bool.
    /// IN: b - bool
    /// OUT: b
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            bool b = bool.Parse(Console.ReadLine());
            Console.WriteLine(b);
        }
    }
}