using System;

namespace TP_CSF_Arrays_2DArray
{
    /// <summary>
    /// DESC: Reads (n, m) - integers and n * m integers and writes them out.
    /// 
    /// IN:
    /// n - integer
    /// m - integer
    /// x1,1
    /// x1,2
    /// ...
    /// x1,n
    /// x2,1
    /// x2,2
    /// ...
    /// x2,n
    /// ...
    /// xm,1
    /// xm,2
    /// ...
    /// xm,n
    /// 
    /// OUT:
    /// all the x integers
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());

            var numbers = new int[n, m];

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    numbers[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.Write(numbers[i, j]);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}
