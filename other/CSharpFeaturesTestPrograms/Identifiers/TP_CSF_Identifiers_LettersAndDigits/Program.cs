using System;

namespace TP_CSF_Identifiers_LettersAndDigits
{
    /// <summary>
    /// DESC: Reads two short integers and writes their sum.
    /// 
    /// IN:
    /// n - short
    /// m - short
    /// 
    /// OUT: n + m
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var this0Is1An2Identifier3With4Some5Letters6And7Digits = short.Parse(Console.ReadLine());
            var this0Is1Another2Identifier3With4Some5Letters6And7Digits = short.Parse(Console.ReadLine());

            Console.WriteLine(this0Is1An2Identifier3With4Some5Letters6And7Digits + this0Is1Another2Identifier3With4Some5Letters6And7Digits);
        }
    }
}