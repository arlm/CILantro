using InputDataGenerator.InputDataCreators;

namespace InputDataGenerator
{
    public static class InputDataCreatorFactory
    {
        private const int NUMBER_OF_FILES = 10;

        public static IInputDataCreator CreateInputDataCreator(string programName)
        {
            switch(programName)
            {
                case "TP_CSF_Basics_HelloWorld":
                    return new EmptyInputDataCreator();

                case "TP_CSF_ValueTypes_Int":
                    return new IntInputDataCreator(NUMBER_OF_FILES);

                default:
                    return null;
            }
        }
    }
}