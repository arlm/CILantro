using System;

namespace TP_CSF_Classes_2ArgumentsConstructor
{
    class TwoArgumentsConstructorClass
    {
        public int _intField;

        public string _stringField;

        public TwoArgumentsConstructorClass(int intField, string stringField)
        {
            _intField = intField;
            _stringField = stringField;
        }
    }

    /// <summary>
    /// DESC: Reads and writes out an integer and a string.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var s = Console.ReadLine();

            var instance = new TwoArgumentsConstructorClass(n, s);

            Console.WriteLine(instance._intField);
            Console.WriteLine(instance._stringField);
        }
    }
}