using System;

namespace TP_CSF_Decisions_StringSwitch
{
    /// <summary>
    /// DESC: Writes string of the direction of the world and writes out its shortcut or "---" if it is not a direction.
    /// 
    /// IN: s - string
    /// 
    /// OUT: short form of s (direction of the world) or "---"
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            switch(s)
            {
                case "NORTH":
                    Console.WriteLine("N");
                    break;
                case "SOUTH":
                    Console.WriteLine("S");
                    break;
                case "EAST":
                    Console.WriteLine("E");
                    break;
                case "WEST":
                    Console.WriteLine("W");
                    break;
                default:
                    Console.WriteLine("---");
                    break;
            }
        }
    }
}