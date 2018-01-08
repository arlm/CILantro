using System;

namespace TP_CSF_Operators_RelationalOperators_GreaterOrEqual
{
    /// <summary>
    /// DESC: Reads two integers and writes out "True" if the first one is greater than or equal to the second one, "False" otherwise.
    /// 
    /// IN:
    /// a - integer
    /// b - integer
    /// 
    /// OUT:
    /// "True" if a >= b, "False" otherwise
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            var result = a >= b;

            Console.WriteLine(result);
        }
    }
}