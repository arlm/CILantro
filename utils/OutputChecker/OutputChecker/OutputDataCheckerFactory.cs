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

                case "TP_CSF_ValueTypes_Byte":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ValueTypes_Int":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ValueTypes_Long":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ValueTypes_SByte":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ValueTypes_Short":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ValueTypes_UInt":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ValueTypes_ULong":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ValueTypes_UShort":
                    return new SameOutputsOutputDataChecker();

                default:
                    return null;
            }
        }
    }
}