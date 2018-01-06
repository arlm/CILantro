using System;

namespace TP_CSF_Variables_7Variables
{
    /// <summary>
    /// DESC: Reads 7 integers and writes sum.
    /// 
    /// IN:
    /// a - integer
    /// b - integer
    /// c - integer
    /// d - integer
    /// e - integer
    /// f - integer
    /// g - integer
    /// 
    /// OUT:
    /// a + b + c + d + e + f + g
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var d = int.Parse(Console.ReadLine());
            var e = int.Parse(Console.ReadLine());
            var f = int.Parse(Console.ReadLine());
            var g = int.Parse(Console.ReadLine());

            var sum = a + b + c + d + e + f + g;

            Console.WriteLine(sum);
        }
    }
}