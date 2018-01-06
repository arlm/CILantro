using System;

namespace TP_CSF_Variables_1Variable
{
    /// <summary>
    /// DESC: Reads 1 integer and writes sum.
    /// 
    /// IN:
    /// a - integer
    /// 
    /// OUT:
    /// a
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());

            var sum = a;

            Console.WriteLine(sum);
        }
    }
}