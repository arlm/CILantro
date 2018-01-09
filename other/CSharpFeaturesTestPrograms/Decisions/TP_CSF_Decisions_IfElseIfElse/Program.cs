using System;

namespace TP_CSF_Decisions_IfElseIfElse
{
    /// <summary>
    /// DESC: Reads integer and checks if it is positive, negative or zero.
    /// 
    /// IN: n - integer
    /// 
    /// OUT: "positive" if n > 0, "negative" if n < 0, "zero" otherwise
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n < 0) Console.WriteLine("negative");
            else if (n == 0) Console.WriteLine("zero");
            else Console.WriteLine("positive");
        }
    }
}