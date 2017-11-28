using System;
using System.IO;

namespace OutputChecker.OutputDataCheckers
{
    public class SameOutputsOutputDataChecker : IOutputDataChecker
    {
        public bool CheckOutput(string inDataFilePath, string outExeFilePath, string outCilantroFilePath)
        {
            var outExeData = File.ReadAllText(outExeFilePath);
            var outCilantroData = File.ReadAllText(outCilantroFilePath);
            
            return outExeData.Equals(outCilantroData);
        }
    }
}