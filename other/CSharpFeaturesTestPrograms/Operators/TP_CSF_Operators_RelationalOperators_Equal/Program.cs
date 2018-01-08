using System;

namespace TP_CSF_Operators_RelationalOperators_Equal
{
    /// <summary>
    /// DESC: Reads two integers and writes out "True" if they equals, "False" otherwise.
    /// 
    /// IN:
    /// a - integer
    /// b - integer
    /// 
    /// OUT: 
    /// "True" if a equals b, "False" otherwise.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            var result = a == b;

            Console.WriteLine(result);
        }
    }
}