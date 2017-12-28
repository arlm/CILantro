using InputDataGenerator.InputDataCreators;
using InputDataGenerator.Specifications;
using System;

namespace InputDataGenerator
{
    public static class InputDataCreatorFactory
    {
        private const int MAX_NUMBER_OF_FILES = 100;

        public static IInputDataCreator CreateInputDataCreator(string programName)
        {
            switch(programName)
            {
                case "TP_CSF_Basics_HelloWorld":
                    return new EmptyInputDataCreator();

                case "TP_CSF_ValueTypes_Bool":
                    return new GenericInputDataCreator(InputDataSpec(
                        InputLine(AllValues(typeof(bool)))
                    ));

                case "TP_CSF_ValueTypes_Byte":
                    return new GenericInputDataCreator(InputDataSpec(
                        InputLine(RandomValue(typeof(byte)))
                    ));

                case "TP_CSF_ValueTypes_Decimal":
                    return new GenericInputDataCreator(InputDataSpec(
                        InputLine(RandomValue(typeof(decimal)))
                    ));

                case "TP_CSF_ValueTypes_Double":
                    return new GenericInputDataCreator(InputDataSpec(
                        InputLine(RandomValue(typeof(double)))
                    ));

                case "TP_CSF_ValueTypes_Float":
                    return new GenericInputDataCreator(InputDataSpec(
                        InputLine(RandomValue(typeof(float)))
                    ));

                case "TP_CSF_ValueTypes_Int":
                    return new GenericInputDataCreator(InputDataSpec(
                        InputLine(RandomValue(typeof(int)))
                    ));

                case "TP_CSF_ValueTypes_Long":
                    return new GenericInputDataCreator(InputDataSpec(
                        InputLine(RandomValue(typeof(long)))
                    ));

                case "TP_CSF_ValueTypes_SByte":
                    return new GenericInputDataCreator(InputDataSpec(
                        InputLine(RandomValue(typeof(sbyte)))
                    ));

                case "TP_CSF_ValueTypes_Short":
                    return new GenericInputDataCreator(InputDataSpec(
                        InputLine(RandomValue(typeof(short)))
                    ));

                case "TP_CSF_ValueTypes_UInt":
                    return new GenericInputDataCreator(InputDataSpec(
                        InputLine(RandomValue(typeof(uint)))
                    ));

                case "TP_CSF_ValueTypes_ULong":
                    return new GenericInputDataCreator(InputDataSpec(
                        InputLine(RandomValue(typeof(ulong)))
                    ));

                case "TP_CSF_ValueTypes_UShort":
                    return new GenericInputDataCreator(InputDataSpec(
                        InputLine(RandomValue(typeof(ushort)))
                    ));

                default:
                    return null;
            }
        }

        private static InputDataSpec InputDataSpec(params InputLineSpec[] inputLineSpecs)
        {
            return new InputDataSpec(MAX_NUMBER_OF_FILES, inputLineSpecs);
        }

        private static InputLine InputLine(params InputItemSpec[] inputItemSpecs)
        {
            return new InputLine(inputItemSpecs);
        }

        private static AllValuesInputItem AllValues(Type itemType)
        {
            return new AllValuesInputItem(itemType);
        }

        private static RandomValueInputItem RandomValue(Type itemType)
        {
            return new RandomValueInputItem(itemType);
        }
    }
}