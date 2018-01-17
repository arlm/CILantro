using System;

namespace TP_CSF_Identifiers_UnderscoresAndLetters
{
    /// <summary>
    /// DESC: Reads two integers and writes out their sum.
    /// 
    /// IN:
    /// n - integer
    /// m - integer
    /// 
    /// OUT:
    /// n + m
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var ___thisIsAnIdentifierWithUnderscoresAtTheBeginning = int.Parse(Console.ReadLine());
            var ___thisIsAnotherIdentifierWithUnderscoresAtTheBeginning = int.Parse(Console.ReadLine());

            Console.WriteLine(___thisIsAnIdentifierWithUnderscoresAtTheBeginning + ___thisIsAnotherIdentifierWithUnderscoresAtTheBeginning);
        }
    }
}