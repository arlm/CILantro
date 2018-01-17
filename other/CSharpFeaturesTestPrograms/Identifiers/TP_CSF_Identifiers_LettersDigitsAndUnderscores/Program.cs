using System;

namespace TP_CSF_Identifiers_LettersDigitsAndUnderscores
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
            var this_0_is_1_an_2_identifier_3_with_4_some_5_letters_6_digits_7_and_8_underscores = int.Parse(Console.ReadLine());
            var this_0_is_1_another_2_identifier_3_with_4_some_5_letters_6_digits_7_and_8_underscores = int.Parse(Console.ReadLine());

            Console.WriteLine(this_0_is_1_an_2_identifier_3_with_4_some_5_letters_6_digits_7_and_8_underscores + this_0_is_1_another_2_identifier_3_with_4_some_5_letters_6_digits_7_and_8_underscores);
        }
    }
}