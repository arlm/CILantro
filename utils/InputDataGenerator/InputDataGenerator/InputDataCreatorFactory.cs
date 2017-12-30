using InputDataGenerator.InputDataCreators;
using InputDataGenerator.Specifications;

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

                case "TP_CSF_ValueTypes_Bool":
                    return new GenericInputDataCreator(InputDataSpec(
                        InputLine(AllValues<bool>())
                    ));

                case "TP_CSF_ValueTypes_Byte":
                    return new GenericInputDataCreator(InputDataSpec(
                        InputLine(RandomValue<byte>())
                    ));

                case "TP_CSF_ValueTypes_Char":
                    return new GenericInputDataCreator(InputDataSpec(
                        InputLine(RandomValue<char>())
                    ));

                case "TP_CSF_ValueTypes_Decimal":
                    return new GenericInputDataCreator(InputDataSpec(
                        InputLine(RandomValue<decimal>())
                    ));

                case "TP_CSF_ValueTypes_Double":
                    return new GenericInputDataCreator(InputDataSpec(
                        InputLine(RandomValue<double>())
                    ));

                case "TP_CSF_ValueTypes_Float":
                    return new GenericInputDataCreator(InputDataSpec(
                        InputLine(RandomValue<float>())
                    ));

                case "TP_CSF_ValueTypes_Int":
                    return new GenericInputDataCreator(InputDataSpec(
                        InputLine(RandomValue<int>())
                    ));

                case "TP_CSF_ValueTypes_Long":
                    return new GenericInputDataCreator(InputDataSpec(
                        InputLine(RandomValue<long>())
                    ));

                case "TP_CSF_ValueTypes_SByte":
                    return new GenericInputDataCreator(InputDataSpec(
                        InputLine(RandomValue<sbyte>())
                    ));

                case "TP_CSF_ValueTypes_Short":
                    return new GenericInputDataCreator(InputDataSpec(
                        InputLine(RandomValue<short>())
                    ));

                case "TP_CSF_ValueTypes_UInt":
                    return new GenericInputDataCreator(InputDataSpec(
                        InputLine(RandomValue<uint>())
                    ));

                case "TP_CSF_ValueTypes_ULong":
                    return new GenericInputDataCreator(InputDataSpec(
                        InputLine(RandomValue<ulong>())
                    ));

                case "TP_CSF_ValueTypes_UShort":
                    return new GenericInputDataCreator(InputDataSpec(
                        InputLine(RandomValue<ushort>())
                    ));

                default:
                    return null;
            }
        }

        private static InputDataSpec InputDataSpec(params InputLineSpec[] inputLineSpecs)
        {
            return new InputDataSpec(inputLineSpecs);
        }

        private static InputLine InputLine(params InputItemSpec[] inputItemSpecs)
        {
            return new InputLine(inputItemSpecs);
        }

        private static AllValuesInputItem<T> AllValues<T>()
        {
            return new AllValuesInputItem<T>();
        }

        private static RandomValueInputItem<T> RandomValue<T>()
        {
            return new RandomValueInputItem<T>(100);
        }
    }
}