using System;

namespace OutputChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var programName = args[0];
                var mode = args[1];

                if(mode == "GENERATE-ONLY")
                {
                    var outputDataChecker = OutputDataCheckerFactory.CreateOutputDataChecker(programName);
                    if (outputDataChecker == null) throw new ArgumentException("Cannot generate output data checker for program " + programName + ".");
                }
                else if(mode == "CHECK-ONLY")
                {
                    var inDataFilePath = args[2];
                    var outExeFilePath = args[3];
                    var outCilantroFilePath = args[4];

                    var outputDataChecker = OutputDataCheckerFactory.CreateOutputDataChecker(programName);
                    if (outputDataChecker == null) throw new ArgumentException("Cannot generate output data checker for program " + programName + ".");

                    var outputDataCheckerResult = outputDataChecker.CheckOutput(inDataFilePath, outExeFilePath, outCilantroFilePath);
                    if (!outputDataCheckerResult) throw new ArgumentException("Provided output is incorrect.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(ex.Message);
            }
        }
    }
}