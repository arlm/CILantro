using System;

namespace TP_CSF_Strings_Concatenation
{
    /// <summary>
    /// DESC: Reads three strings and writes out their concatenation result.
    /// 
    /// IN:
    /// s - string
    /// t - string
    /// u - string
    /// 
    /// OUT: s + t + u
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            string u = Console.ReadLine();

            var result = s + t + u;

            Console.WriteLine(result);
        }
    }
}