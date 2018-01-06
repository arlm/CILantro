using System;

namespace TP_CSF_Operators_ArithmeticOperators_Increment
{
    /// <summary>
    /// DESC: Reads integer and writes out increment operations results.
    /// 
    /// IN:
    /// n - integer
    /// 
    /// OUT:
    /// ++n
    /// n++
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(++n);
            Console.WriteLine(n++);
        }
    }
}