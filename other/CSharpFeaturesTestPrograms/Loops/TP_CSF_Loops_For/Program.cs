using System;

namespace TP_CSF_Loops_For
{
    /// <summary>
    /// DESC: Reads n - integer and writes out the sum of all natural numbers less than or equal to n.
    /// 
    /// IN: n - integer
    /// 
    /// OUT: 0 + 1 + 2 + ... + n
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sum = 0;
            for(int i = 0; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine(sum);
        }
    }
}