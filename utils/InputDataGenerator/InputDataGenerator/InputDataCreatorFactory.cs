﻿using InputDataGenerator.InputDataCreators;

namespace InputDataGenerator
{
    public static class InputDataCreatorFactory
    {
        public static IInputDataCreator CreateInputDataCreator(string programName)
        {
            switch(programName)
            {
                case "TP_CSF_Basics_HelloWorld":
                    return new EmptyInputDataCreator();

                case "TP_FSF_Basics_HelloWorld":
                    return new EmptyInputDataCreator();

                case "TP_VBF_Basics_HelloWorld":
                    return new EmptyInputDataCreator();

                default:
                    return null;
            }
        }
    }
}