using System;

namespace TP_CSF_Decisions_IfElseIf
{
    /// <summary>
    /// DESC: Reads a character and checks if it is a digit, a letter or a symbol.
    /// 
    /// IN: c - char
    /// 
    /// OUT: "digit" if c is a digit, "letter" if c is a letter, "symbol" otherwise
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var c = char.Parse(Console.ReadLine());

            var result = "symbol";
            if (char.IsDigit(c)) result = "digit";
            else if (char.IsLetter(c)) result = "letter";

            Console.WriteLine(result);
        }
    }
}