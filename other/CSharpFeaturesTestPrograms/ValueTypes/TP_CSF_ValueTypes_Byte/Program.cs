using System;

namespace TP_CSF_ValueTypes_Byte
{
    /// <summary>
    /// DESC: Reads and writes out byte.
    /// IN: n - byte
    /// OUT: n
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            Console.WriteLine(n);
        }
    }
}