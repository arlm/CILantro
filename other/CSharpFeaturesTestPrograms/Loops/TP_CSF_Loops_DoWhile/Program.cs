using System;

namespace TP_CSF_Loops_DoWhile
{
    /// <summary>
    /// DESC: Reads a sequence of integers with 0 at the end, writes out their sum.
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

            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
                sum += n;
            }
            while (n != 0);

            Console.WriteLine(sum);
        }
    }
}