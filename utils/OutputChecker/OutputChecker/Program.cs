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
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(ex.Message);
            }
        }
    }
}