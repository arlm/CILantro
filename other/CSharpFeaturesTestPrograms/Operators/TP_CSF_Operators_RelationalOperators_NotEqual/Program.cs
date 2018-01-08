using System;

namespace TP_CSF_Operators_RelationalOperators_NotEqual
{
    /// <summary>
    /// DESC: Reads two integers and writes out "True" if they don't equal, "False" otherwise.
    /// 
    /// IN:
    /// a - integer
    /// b - integer
    /// 
    /// OUT:
    /// "True" if a != b, "False" otherwise
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            var result = a != b;

            Console.WriteLine(result);
        }
    }
}