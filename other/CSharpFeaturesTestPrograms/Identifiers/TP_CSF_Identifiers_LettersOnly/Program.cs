using System;

namespace TP_CSF_Identifiers_LettersOnly
{
    /// <summary>
    /// DESC: Reads two integers and writes out their sum.
    /// 
    /// IN:
    /// n - integer
    /// m - integer
    /// 
    /// OUT: n + m
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var thisIsAnIdentifierWhichContainsLettersOnly = int.Parse(Console.ReadLine());
            var thisIsAnotherIdentifierWhichContainsLettersOnly = int.Parse(Console.ReadLine());

            Console.WriteLine(thisIsAnIdentifierWhichContainsLettersOnly + thisIsAnotherIdentifierWhichContainsLettersOnly);
        }
    }
}