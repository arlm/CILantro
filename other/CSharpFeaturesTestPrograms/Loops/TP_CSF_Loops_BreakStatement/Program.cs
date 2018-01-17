using System;

namespace TP_CSF_Loops_BreakStatement
{
    /// <summary>
    /// DESC: Reads integers until 0 and writes out their sum.
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

            while(true)
            {
                var n = int.Parse(Console.ReadLine());
                sum += n;

                if (n == 0) break;
            }

            Console.WriteLine(sum);
        }
    }
}