using System;

namespace TP_CSF_Loops_While
{
    /// <summary>
    /// DESC: Reads sequence of integers with 0 at the end, writes out their sum.
    /// 
    /// IN: n1, n2, ..., nk, 0 - integers
    /// 
    /// OUT: n1 + n2 + ... + nk
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;

            var n = int.Parse(Console.ReadLine());
            while(n != 0)
            {
                sum += n;
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}