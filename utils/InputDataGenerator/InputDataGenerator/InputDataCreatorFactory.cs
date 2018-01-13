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

                case "TP_CSF_Operators_ArithmeticOperators_Multiply":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Operators_ArithmeticOperators_Divide":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt(true));
                    });

                case "TP_CSF_Operators_ArithmeticOperators_Modulo":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt(true));
                    });

                case "TP_CSF_Operators_ArithmeticOperators_Increment":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Operators_ArithmeticOperators_Decrement":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Variables_1Variable":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Variables_2Variables":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Variables_3Variables":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Variables_4Variables":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Variables_5Variables":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Variables_6Variables":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Variables_7Variables":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Variables_8Variables":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Variables_9Variables":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Variables_10Variables":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Operators_RelationalOperators_Equal":
                    return new EnumerableInputDataCreator(IntHelper.GetPairs(1, 10, 1, 10).SelectCreateInputActions(pair => writer =>
                    {
                        writer.WriteLine(pair.Item1);
                        writer.WriteLine(pair.Item2);
                    }));

                case "TP_CSF_Operators_RelationalOperators_NotEqual":
                    return new EnumerableInputDataCreator(IntHelper.GetPairs(1, 10, 1, 10).SelectCreateInputActions(pair => writer =>
                    {
                        writer.WriteLine(pair.Item1);
                        writer.WriteLine(pair.Item2);
                    }));

                case "TP_CSF_Operators_RelationalOperators_Greater":
                    return new EnumerableInputDataCreator(IntHelper.GetPairs(1, 10, 1, 10).SelectCreateInputActions(pair => writer =>
                    {
                        writer.WriteLine(pair.Item1);
                        writer.WriteLine(pair.Item2);
                    }));

                case "TP_CSF_Operators_RelationalOperators_Less":
                    return new EnumerableInputDataCreator(IntHelper.GetPairs(1, 10, 1, 10).SelectCreateInputActions(pair => writer =>
                    {
                        writer.WriteLine(pair.Item1);
                        writer.WriteLine(pair.Item2);
                    }));

                case "TP_CSF_Operators_RelationalOperators_GreaterOrEqual":
                    return new EnumerableInputDataCreator(IntHelper.GetPairs(1, 10, 1, 10).SelectCreateInputActions(pair => writer =>
                    {
                        writer.WriteLine(pair.Item1);
                        writer.WriteLine(pair.Item2);
                    }));

                case "TP_CSF_Operators_RelationalOperators_LessOrEqual":
                    return new EnumerableInputDataCreator(IntHelper.GetPairs(1, 10, 1, 10).SelectCreateInputActions(pair => writer =>
                    {
                        writer.WriteLine(pair.Item1);
                        writer.WriteLine(pair.Item2);
                    }));

                case "TP_CSF_Operators_LogicalOperators_And":
                    return new EnumerableInputDataCreator(BoolHelper.GetAllPairs().SelectCreateInputActions(pair => writer =>
                    {
                        writer.WriteLine(pair.Item1);
                        writer.WriteLine(pair.Item2);
                    }));

                case "TP_CSF_Operators_LogicalOperators_Or":
                    return new EnumerableInputDataCreator(BoolHelper.GetAllPairs().SelectCreateInputActions(pair => writer =>
                    {
                        writer.WriteLine(pair.Item1);
                        writer.WriteLine(pair.Item2);
                    }));

                case "TP_CSF_Operators_LogicalOperators_Not":
                    return new EnumerableInputDataCreator(BoolHelper.GetAllValues().SelectCreateInputActions(b => writer =>
                    {
                        writer.WriteLine(b);
                    }));

                case "TP_CSF_Operators_BitwiseOperators_And":
                    return new EnumerableInputDataCreator(IntHelper.GetPairs(1, 10, 1, 10).SelectCreateInputActions(pair => writer =>
                    {
                        writer.WriteLine(pair.Item1);
                        writer.WriteLine(pair.Item2);
                    }));

                case "TP_CSF_Operators_BitwiseOperators_Or":
                    return new EnumerableInputDataCreator(IntHelper.GetPairs(1, 10, 1, 10).SelectCreateInputActions(pair => writer =>
                    {
                        writer.WriteLine(pair.Item1);
                        writer.WriteLine(pair.Item2);
                    }));

                case "TP_CSF_Operators_BitwiseOperators_Xor":
                    return new EnumerableInputDataCreator(IntHelper.GetPairs(1, 10, 1, 10).SelectCreateInputActions(pair => writer =>
                    {
                        writer.WriteLine(pair.Item1);
                        writer.WriteLine(pair.Item2);
                    }));

                case "TP_CSF_Operators_BitwiseOperators_Not":
                    return new EnumerableInputDataCreator(IntHelper.GetRange(1, 100).SelectCreateInputActions(n => writer =>
                    {
                        writer.WriteLine(n);
                    }));

                case "TP_CSF_Operators_BitwiseOperators_LeftShift":
                    return new EnumerableInputDataCreator(IntHelper.GetPairs(1, 10, 1, 10).SelectCreateInputActions(pair => writer =>
                    {
                        writer.WriteLine(pair.Item1);
                        writer.WriteLine(pair.Item2);
                    }));

                case "TP_CSF_Operators_BitwiseOperators_RightShift":
                    return new EnumerableInputDataCreator(IntHelper.GetPairs(1, 10, 1, 10).SelectCreateInputActions(pair => writer =>
                    {
                        writer.WriteLine(pair.Item1);
                        writer.WriteLine(pair.Item2);
                    }));

                case "TP_CSF_Operators_AssignOperators_Assign":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Operators_AssignOperators_AddAndAssign":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Operators_AssignOperators_SubtractAndAssign":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Operators_AssignOperators_MultiplyAndAssign":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Operators_AssignOperators_DivideAndAssign":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Operators_AssignOperators_ModuloAndAssign":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Operators_AssignOperators_LShiftAndAssign":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Operators_AssignOperators_RShiftAndAssign":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Operators_AssignOperators_AndAndAssign":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Operators_AssignOperators_XorAndAssign":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Operators_AssignOperators_OrAndAssign":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Decisions_If":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Decisions_IfElse":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt(true));
                    });

                case "TP_CSF_Decisions_IfElseIf":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextStandardChar());
                    });

                case "TP_CSF_Decisions_IfElseIfElse":
                    return new EnumerableInputDataCreator(IntHelper.GetRange(-50, 49).SelectCreateInputActions(n => writer =>
                    {
                        writer.WriteLine(n);
                    }));

                case "TP_CSF_Decisions_IfElseIfElseIf":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Decisions_IfElseIfElseIfElse":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Decisions_NestedIf":
                    return new EnumerableInputDataCreator(IntHelper.GetPairs(-5, 4, -5, 4).SelectCreateInputActions(pair => writer =>
                    {
                        writer.WriteLine(pair.Item1);
                        writer.WriteLine(pair.Item2);
                    }));

                case "TP_CSF_Decisions_CharSwitch":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.Write(rand.NextStandardChar());
                    });

                case "TP_CSF_Decisions_ConditionalAssignOperator":
                    return new EnumerableInputDataCreator(BoolHelper.GetAllValues().SelectCreateInputActions(b => writer =>
                    {
                        writer.WriteLine(b);
                    }));

                case "TP_CSF_Decisions_BoolSwitch":
                    return new EnumerableInputDataCreator(BoolHelper.GetAllValues().SelectCreateInputActions(b => writer =>
                    {
                        writer.WriteLine(b);
                    }));

                case "TP_CSF_Decisions_ShortSwitch":
                    return new EnumerableInputDataCreator(ShortHelper.GetRange(-50, 49).SelectCreateInputActions(s => writer =>
                    {
                        writer.WriteLine(s);
                    }));

                case "TP_CSF_Operators_MiscOperators_TypeOf":
                    return new EmptyInputDataCreator();

                case "TP_CSF_Operators_MiscOperators_SizeOf":
                    return new EmptyInputDataCreator();

                case "TP_CSF_Enums_Enum":
                    return new EnumerableInputDataCreator(ShortHelper.GetRange(0, 7).SelectCreateInputActions(s => writer =>
                    {
                        writer.WriteLine(s);
                    }));

                case "TP_CSF_Enums_ExistingEnum":
                    return new EnumerableInputDataCreator(ShortHelper.GetRange(0, 6).SelectCreateInputActions(s => writer =>
                    {
                        writer.WriteLine(s);
                    }));

                case "TP_CSF_Enums_EnumWithAssignedValues":
                    return new EnumerableInputDataCreator(ShortHelper.GetRange(1, 7).SelectCreateInputActions(s => writer =>
                    {
                        writer.WriteLine(s);
                    }));

                case "TP_CSF_Enums_EnumLong":
                    return new EnumerableInputDataCreator(ShortHelper.GetRange(0, 49).SelectCreateInputActions(s => writer =>
                    {
                        writer.WriteLine(s);
                    }));

                case "TP_CSF_Enums_EnumByte":
                    return new EnumerableInputDataCreator(ShortHelper.GetRange(0, 49).SelectCreateInputActions(s => writer =>
                    {
                        writer.WriteLine(s);
                    }));

                case "TP_CSF_Enums_EnumShort":
                    return new EnumerableInputDataCreator(ShortHelper.GetRange(0, 49).SelectCreateInputActions(s => writer =>
                    {
                        writer.WriteLine(s);
                    }));

                case "TP_CSF_Decisions_ByteSwitch":
                    return new EnumerableInputDataCreator(ShortHelper.GetRange(0, 99).SelectCreateInputActions(s => writer =>
                    {
                        writer.WriteLine(s);
                    }));

                case "TP_CSF_Decisions_IntSwitch":
                    return new EnumerableInputDataCreator(ShortHelper.GetRange(-50, 49).SelectCreateInputActions(s => writer =>
                    {
                        writer.WriteLine(s);
                    }));

                case "TP_CSF_Decisions_EnumSwitch":
                    return new EnumerableInputDataCreator(ShortHelper.GetRange(-50, 49).SelectCreateInputActions(s => writer =>
                    {
                        writer.WriteLine(s);
                    }));

                case "TP_CSF_Decisions_NestedSwitch":
                    return new EnumerableInputDataCreator(IntHelper.GetPairs(0, 10, 0, 10).SelectCreateInputActions(pair => writer =>
                    {
                        writer.WriteLine(pair.Item1);
                        writer.WriteLine(pair.Item2);
                    }));

                default:
                    throw new ArgumentException("Cannot recognize program name.");
            }
        }
    }
}