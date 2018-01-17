using System;

namespace TP_CSF_Arrays_1DArray
{
    /// <summary>
    /// DESC: Reads n and n integers and writes them out.
    /// 
    /// IN:
    /// n - integer
    /// i1, i2, ..., in - integers
    /// 
    /// OUT:
    /// i1, i2, ..., in
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var numbers = new int[n];

            for (int i = 0; i < n; i++) numbers[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) Console.WriteLine(numbers[i]);
        }
    }
}