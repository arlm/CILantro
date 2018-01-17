﻿using System;

namespace TP_CSF_Decisions_ByteSwitch
{
    /// <summary>
    /// DESC: Reads byte and writes out its name if it is a digit or "other" otherwise.
    /// 
    /// IN: b - byte
    /// 
    /// OUT: b's name if b is a digit, "other" otherwise
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var b = byte.Parse(Console.ReadLine());

            switch(b)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                default:
                    Console.WriteLine("other");
                    break;
            }
        }
    }
}