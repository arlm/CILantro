using CILantro.Engine;
using System;
using System.IO;

namespace CILantro.UI.HiddenUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var cilantroEngine = new CILantroEngine(string.Empty);

            var consoleReader = new StreamReader(Console.OpenStandardInput());
            var consoleWriter = new StreamWriter(Console.OpenStandardOutput());
            consoleWriter.AutoFlush = true;

            cilantroEngine.Process(consoleReader, consoleWriter);
        }
    }
}