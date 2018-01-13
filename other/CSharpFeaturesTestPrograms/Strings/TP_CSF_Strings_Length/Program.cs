using System;

namespace TP_CSF_Strings_Length
{
    /// <summary>
    /// DESC: Reads a string and writes out its length.
    /// 
    /// IN: s
    /// 
    /// OUT: length of s
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(s.Length);
        }
    }
}