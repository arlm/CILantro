using System;

namespace TP_CSF_Classes_EmptyClass
{
    class EmptyClass { }

    /// <summary>
    /// DESC: Writes out text: 'It works!'
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var emptyClass = new EmptyClass();

            Console.WriteLine("It works!");
        }
    }
}