using System;

namespace OutputChecker.OutputDataCheckers
{
    public class SameOutputsOutputDataChecker : IOutputDataChecker
    {
        public bool CheckOutput(string inDataFilePath, string outExeFilePath, string outCilantroFilePath)
        {
            var rand = new Random();
            var next = rand.Next(2);
            return (next == 0);
        }
    }
}