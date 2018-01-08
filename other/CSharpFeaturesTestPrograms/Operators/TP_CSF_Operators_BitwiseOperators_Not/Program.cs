using System;

namespace TP_CSF_Operators_BitwiseOperators_Not
{
    /// <summary>
    /// DESC: Reads integer and writes out its bitwise negation.
    /// 
    /// IN: a - integer
    /// 
    /// OUT: ~a
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());

            var result = ~a;
            Console.WriteLine(result);
        }
    }
}