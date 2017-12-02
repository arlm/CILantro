using CILantro.Engine;
using System;
using System.IO;

namespace CILantro.UI.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourceCodePath = args[0];
            var sourceCode = File.ReadAllText(sourceCodePath);

            var mode = ConsoleUIMode.Normal;
            if(args.Length > 1)
            {
                var modeString = args[1];
                switch (modeString.ToLower())
                {
                    case "parse-only":
                        mode = ConsoleUIMode.ParseOnly;
                        break;
                }
            }

            var cilantroEngine = new CILantroEngine(sourceCode);

            if (mode == ConsoleUIMode.Normal)
            {
                var consoleReader = new StreamReader(Console.OpenStandardInput());
                var consoleWriter = new StreamWriter(Console.OpenStandardOutput());
                consoleWriter.AutoFlush = true;

                cilantroEngine.Process(consoleReader, consoleWriter);
            }
            else if(mode == ConsoleUIMode.ParseOnly)
            {
                var programTree = cilantroEngine.Parse();
                if (programTree == null)
                    throw new ArgumentException("An error occurred while parsing the source code.");
            }
        }
    }
}