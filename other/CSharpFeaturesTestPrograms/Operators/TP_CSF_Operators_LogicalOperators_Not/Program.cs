using System;

namespace TP_CSF_Operators_LogicalOperators_Not
{
    /// <summary>
    /// DESC: Reads boolean and writes out its negation.
    /// 
    /// IN: b - bool
    /// 
    /// OUT: !b
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var b = bool.Parse(Console.ReadLine());
            var result = !b;
            Console.WriteLine(result);
        }
    }
}