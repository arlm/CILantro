using InputDataGenerator.InputDataCreators;

namespace InputDataGenerator
{
    public static class InputDataCreatorFactory
    {
        private const int NUMBER_OF_FILES = 100;

        public static IInputDataCreator CreateInputDataCreator(string programName)
        {
            switch(programName)
            {
                case "TP_CSF_Basics_HelloWorld":
                    return new EmptyInputDataCreator();

                case "TP_CSF_ValueTypes_Int":
                    return new IntInputDataCreator(NUMBER_OF_FILES);

                case "TP_CSF_ValueTypes_Long":
                    return new LongInputDataCreator(NUMBER_OF_FILES);

                case "TP_CSF_ValueTypes_Short":
                    return new ShortInputDataCreator(NUMBER_OF_FILES);

                case "TP_CSF_ValueTypes_UInt":
                    return new UIntInputDataCreator(NUMBER_OF_FILES);

                case "TP_CSF_ValueTypes_ULong":
                    return new ULongInputDataCreator(NUMBER_OF_FILES);

                case "TP_CSF_ValueTypes_UShort":
                    return new UShortInputDataCreator(NUMBER_OF_FILES);

                default:
                    return null;
            }
        }
    }
}