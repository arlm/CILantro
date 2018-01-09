using System;

namespace TP_CSF_Decisions_BoolSwitch
{
    /// <summary>
    /// DESC: Reads bool and converts it to "YES" or "NO"
    /// 
    /// IN: b - bool
    /// 
    /// OUT: "YES" if b is True, "NO" otherwise
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var b = bool.Parse(Console.ReadLine());

            switch(b)
            {
                case true:
                    Console.WriteLine("YES");
                    break;
                case false:
                    Console.WriteLine("NO");
                    break;
            }
        }
    }
}