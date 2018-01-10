using System;

namespace TP_CSF_Enums_Enum
{
    public enum Color
    {
        Red,
        Green,
        Blue,
        Black,
        White,
        Yellow,
        Purple,
        Pink
    }

    /// <summary>
    /// DESC: Reads color code and writes out its color name.
    /// 
    /// IN: n - color number
    /// 
    /// OUT: the name of n-th color
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var e = Enum.Parse(typeof(Color), Console.ReadLine());
            Console.WriteLine(e);
        }
    }
}