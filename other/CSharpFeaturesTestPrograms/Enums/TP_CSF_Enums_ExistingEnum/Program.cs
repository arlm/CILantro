using System;

namespace TP_CSF_Enums_ExistingEnum
{
    class Program
    {
        /// <summary>
        /// DESC: Reads PlatformID code and writes out platform name.
        /// 
        /// IN: e - platform ID
        /// 
        /// OUT: platform name
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var e = Enum.Parse(typeof(PlatformID), Console.ReadLine());
            Console.WriteLine(e);
        }
    }
}