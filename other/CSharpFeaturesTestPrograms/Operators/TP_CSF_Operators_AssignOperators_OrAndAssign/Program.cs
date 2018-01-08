﻿using System;

namespace TP_CSF_Operators_AssignOperators_OrAndAssign
{
    /// <summary>
    /// DESC: Reads two integers and writes out their bitwise disjunction.
    /// 
    /// IN:
    /// a - integer
    /// b - integer
    /// 
    /// OUT:
    /// a | b
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var result = a;
            result |= b;
            Console.WriteLine(result);
        }
    }
}