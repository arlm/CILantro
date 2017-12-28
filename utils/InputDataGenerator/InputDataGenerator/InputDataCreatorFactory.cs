using InputDataGenerator.InputDataCreators;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InputDataGenerator
{
    public static class InputDataCreatorFactory
    {
        private const int NUMBER_OF_FILES = 100;

        private static List<Type> BuildTypesLine(params Type[] types)
        {
            return types.ToList();
        }

        private static List<List<Type>> BuildTypesList(params List<Type>[] typeLines)
        {
            return typeLines.ToList();
        }

        public static IInputDataCreator CreateInputDataCreator(string programName)
        {
            switch(programName)
            {
                case "TP_CSF_Basics_HelloWorld":
                    return new EmptyInputDataCreator();

                case "TP_CSF_ValueTypes_Byte":
                    return new RandomInputDataCreator(NUMBER_OF_FILES, BuildTypesList(
                        BuildTypesLine(typeof(byte))
                    ));

                case "TP_CSF_ValueTypes_Float":
                    return new RandomInputDataCreator(NUMBER_OF_FILES, BuildTypesList(
                        BuildTypesLine(typeof(float))
                    ));

                case "TP_CSF_ValueTypes_Int":
                    return new RandomInputDataCreator(NUMBER_OF_FILES, BuildTypesList(
                        BuildTypesLine(typeof(int))
                    ));

                case "TP_CSF_ValueTypes_Long":
                    return new RandomInputDataCreator(NUMBER_OF_FILES, BuildTypesList(
                        BuildTypesLine(typeof(long))
                    ));

                case "TP_CSF_ValueTypes_SByte":
                    return new RandomInputDataCreator(NUMBER_OF_FILES, BuildTypesList(
                        BuildTypesLine(typeof(sbyte))
                    ));

                case "TP_CSF_ValueTypes_Short":
                    return new RandomInputDataCreator(NUMBER_OF_FILES, BuildTypesList(
                        BuildTypesLine(typeof(short))
                    ));

                case "TP_CSF_ValueTypes_UInt":
                    return new RandomInputDataCreator(NUMBER_OF_FILES, BuildTypesList(
                        BuildTypesLine(typeof(uint))
                    ));

                case "TP_CSF_ValueTypes_ULong":
                    return new RandomInputDataCreator(NUMBER_OF_FILES, BuildTypesList(
                        BuildTypesLine(typeof(ulong))
                    ));

                case "TP_CSF_ValueTypes_UShort":
                    return new RandomInputDataCreator(NUMBER_OF_FILES, BuildTypesList(
                        BuildTypesLine(typeof(ushort))
                    ));

                default:
                    return null;
            }
        }
    }
}