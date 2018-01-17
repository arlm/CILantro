using System;

namespace TP_CSF_Loops_NestedLoops
{
    /// <summary>
    /// DESC: Reads two integers (n, m) and writes out all the pairs of natural numbers (i, j) such as i <= n and j <= m
    /// 
    /// IN:
    /// n - integer
    /// m - integer
    /// 
    /// OUT:
    /// (0, 0)
    /// (0, 1)
    /// ...
    /// (0, m)
    /// (1, 0)
    /// (1, 1)
    /// ...
    /// (1, m)
    /// ...
    /// (n, 0)
    /// (n, 1)
    /// ...
    /// (n, m)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());

            for(int i = 0; i <= n; i++)
            {
                for(int j = 0; j <= m; j++)
                {
                    Console.WriteLine(i.ToString() + " " + j.ToString());
                }
            }
        }
    }
}