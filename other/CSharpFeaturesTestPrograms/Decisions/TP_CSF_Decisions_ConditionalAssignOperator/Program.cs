using System;

namespace TP_CSF_Decisions_ConditionalAssignOperator
{
    /// <summary>
    /// DESC: Reads bool and check if it is true or false.
    /// 
    /// IN: b - bool
    /// 
    /// OUT: "It's true!" if b is True, "It's false!" otherwise
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var b = bool.Parse(Console.ReadLine());

            var result = b ? "It's true!" : "It's false!";
            Console.WriteLine(result);
        }
    }
}