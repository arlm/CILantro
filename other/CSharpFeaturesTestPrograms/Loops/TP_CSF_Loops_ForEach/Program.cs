using System;

namespace TP_CSF_Loops_ForEach
{
    /// <summary>
    /// DESC: Reads n and n numbers and writes them out.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var n = short.Parse(Console.ReadLine());

            var array = new int[n];

            for (int i = 0; i < n; i++) array[i] = int.Parse(Console.ReadLine());

            foreach(var element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}