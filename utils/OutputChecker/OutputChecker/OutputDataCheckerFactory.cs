using OutputChecker.OutputDataCheckers;

namespace OutputChecker
{
    public static class OutputDataCheckerFactory
    {
        public static IOutputDataChecker CreateOutputDataChecker(string programName)
        {
            switch(programName)
            {
                case "TP_CSF_Basics_HelloWorld":
                    return new SameOutputsOutputDataChecker();

                case "TP_FSF_Basics_HelloWorld":
                    return new SameOutputsOutputDataChecker();

                case "TP_VBF_Basics_HelloWorld":
                    return new SameOutputsOutputDataChecker();

                default:
                    return null;
            }
        }
    }
}