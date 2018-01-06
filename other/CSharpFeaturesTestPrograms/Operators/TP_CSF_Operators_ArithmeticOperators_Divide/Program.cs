using System;

namespace TP_CSF_Operators_ArithmeticOperators_Divide
{
    /// <summary>
    /// DESC: Reads two integers (a, b) and writes out their quotient.
    /// 
    /// IN:
    /// a - int
    /// b - int
    /// 
    /// OUT:
    /// a / b
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(a / b);
        }
    }
}