using System;

namespace TP_CSF_Variables_3Variables
{
    /// <summary>
    /// DESC: Reads 3 integers and writes sum.
    /// 
    /// IN:
    /// a - integer
    /// b - integer
    /// c - integer
    /// 
    /// OUT:
    /// a + b + c
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            var sum = a + b + c;

            Console.WriteLine(sum);
        }
    }
}