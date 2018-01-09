using System;

namespace TP_CSF_Decisions_IfElse
{
    /// <summary>
    /// DESC: Reads a non-zero integer and checks if it is positive or negative.
    /// 
    /// IN: n - integer (n != 0)
    /// 
    /// OUT: "positive" if n is positive, "negative" otherwise
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n < 0) Console.WriteLine("negative");
            else Console.WriteLine("positive");
        }
    }
}