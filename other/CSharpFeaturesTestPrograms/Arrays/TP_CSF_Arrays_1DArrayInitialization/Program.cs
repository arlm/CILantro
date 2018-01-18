using System;

namespace TP_CSF_Arrays_1DArrayInitialization
{
    /// <summary>
    /// DESC: Reads number (0 - 10) and writes out its name.
    /// 
    /// IN: n (0 - 10)
    /// 
    /// OUT: n's name
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var numberNames = new string[]
            {
                "zero",
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eight",
                "nine",
                "ten"
            };

            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(numberNames[n]);
        }
    }
}