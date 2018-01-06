using System;

namespace TP_CSF_Variables_2Variables
{
    /// <summary>
    /// DESC: Reads 2 integers and writes sum.
    /// 
    /// IN:
    /// a - integer
    /// b - integer
    /// 
    /// OUT:
    /// a + b
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var sum = a + b;

            Console.WriteLine(sum);
        }
    }
}