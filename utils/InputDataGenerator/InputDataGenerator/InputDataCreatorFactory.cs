using InputDataGenerator.Extensions;
using InputDataGenerator.Helpers;
using InputDataGenerator.InputDataCreators;
using System;

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
                    return new EnumerableInputDataCreator(BoolHelper.GetAllValues().SelectCreateInputActions(b => writer =>
                    {
                        writer.WriteLine(b);
                    }));

                case "TP_CSF_ValueTypes_Byte":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextByte());
                    });

                case "TP_CSF_ValueTypes_Char":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextStandardChar());
                    });

                case "TP_CSF_ValueTypes_Decimal":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextDecimal());
                    });

                case "TP_CSF_ValueTypes_Double":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextDouble());
                    });

                case "TP_CSF_ValueTypes_Float":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextFloat());
                    });

                case "TP_CSF_ValueTypes_Int":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_ValueTypes_Long":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextLong());
                    });

                case "TP_CSF_ValueTypes_SByte":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextSByte());
                    });

                case "TP_CSF_ValueTypes_Short":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextShort());
                    });

                case "TP_CSF_ValueTypes_UInt":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextUInt());
                    });

                case "TP_CSF_ValueTypes_ULong":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextULong());
                    });

                case "TP_CSF_ValueTypes_UShort":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextUShort());
                    });

                case "TP_CSF_Operators_ArithmeticOperators_Add":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Operators_ArithmeticOperators_Subtract":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                default:
                    throw new ArgumentException("Cannot recognize program name.");
            }
        }
    }
}