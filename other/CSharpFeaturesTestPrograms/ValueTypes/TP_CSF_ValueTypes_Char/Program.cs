using System;

namespace TP_CSF_ValueTypes_Char
{
    /// <summary>
    /// DESC: Reads and writes out a character.
    /// IN: c - char
    /// OUT: c
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            char c = char.Parse(Console.ReadLine());
            Console.WriteLine(c);
        }
    }
}