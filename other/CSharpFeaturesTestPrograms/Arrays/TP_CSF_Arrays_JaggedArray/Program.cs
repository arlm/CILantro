using System;

namespace TP_CSF_Arrays_JaggedArray
{
    /// <summary>
    /// DESC: Reads and writes out a jagged array.
    /// 
    /// IN:
    /// n - number of rows
    /// m1, m2, ..., mn - number of elements in each row
    /// x1,1 x1,2 ... x1,m1
    /// ...
    /// xn,1 xn,2 ... xn,mn
    /// 
    /// OUT:
    /// jagged array
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var n = short.Parse(Console.ReadLine());
            var array = new int[n][];

            for(int i = 0; i < n; i++)
            {
                var m = short.Parse(Console.ReadLine());
                array[i] = new int[m];
            }

            for (int i = 0; i < n; i++)
                for (int j = 0; j < array[i].Length; j++)
                    array[i][j] = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                    Console.Write(array[i][j] + " ");
                Console.WriteLine();
            }
        }
    }
}