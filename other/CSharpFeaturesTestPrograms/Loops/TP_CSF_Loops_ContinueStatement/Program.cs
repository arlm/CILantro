using System;

namespace TP_CSF_Loops_ContinueStatement
{
    /// <summary>
    /// DESC: Reads n integers and writes only those which are even.
    /// 
    /// IN:
    /// n - integer
    /// n integers
    /// 
    /// OUT:
    /// all the integers which are even
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                var x = int.Parse(Console.ReadLine());
                if (x % 2 == 1) continue;

                Console.WriteLine(x);
            }
        }
    }
}