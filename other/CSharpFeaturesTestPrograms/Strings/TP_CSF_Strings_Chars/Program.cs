using System;

namespace TP_CSF_Strings_Chars
{
    /// <summary>
    /// DESC: Reads string and integer (n) and writes out n-th char of the string.
    /// 
    /// IN:
    /// s - string
    /// n - integer
    /// 
    /// OUT:
    /// n-th char of s
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());

            var character = s[n];

            Console.WriteLine(character);
        }
    }
}