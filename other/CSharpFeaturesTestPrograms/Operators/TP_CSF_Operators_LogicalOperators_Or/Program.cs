﻿using System;

namespace TP_CSF_Operators_LogicalOperators_Or
{
    /// <summary>
    /// DESC: Reads two booleans and writes out its disjunction.
    /// 
    /// IN:
    /// a - bool
    /// b - bool
    /// 
    /// OUT:
    /// a || b
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var a = bool.Parse(Console.ReadLine());
            var b = bool.Parse(Console.ReadLine());

            var result = a || b;
            Console.WriteLine(result);
        }
    }
}