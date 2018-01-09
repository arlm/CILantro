using System;

namespace TP_CSF_Decisions_IfElseIfElseIfElse
{
    /// <summary>
    /// DESC: reads integer and checks its remainder modulo 4.
    /// 
    /// IN: n - integer
    /// 
    /// OUT: "zero" if n % 4 == 0, "one" if n % 4 == 1, "two" if n % 4 == 2, "three" otherwise
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n % 4 == 0) Console.WriteLine("zero");
            else if (n % 4 == 1) Console.WriteLine("one");
            else if (n % 4 == 2) Console.WriteLine("two");
            else Console.WriteLine("three");
        }
    }
}