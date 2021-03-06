﻿using InputDataGenerator.Extensions;
using InputDataGenerator.Helpers;
using InputDataGenerator.InputDataCreators;
using System;
using System.Collections.Generic;

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

                case "TP_CSF_Strings_String":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextStandardString());
                    });

                case "TP_CSF_Strings_Concatenation":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextStandardString());
                        writer.WriteLine(rand.NextStandardString());
                        writer.WriteLine(rand.NextStandardString());
                    });

                case "TP_CSF_Strings_Length":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextStandardString());
                    });

                case "TP_CSF_Strings_Chars":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        var randomString = rand.NextStandardString();
                        writer.WriteLine(randomString);

                        var index = rand.Next(0, randomString.Length);
                        writer.WriteLine(index);
                    });

                case "TP_CSF_Decisions_StringSwitch":
                    var strings = new List<string> { "NORTH", "SOUTH", "EAST", "WEST", "NOTHING" };
                    return new EnumerableInputDataCreator(strings.SelectCreateInputActions(s => writer =>
                    {
                        writer.WriteLine(s);
                    }));

                case "TP_CSF_Comments_SingleLineComment":
                    return new EmptyInputDataCreator();

                case "TP_CSF_Comments_MultiLineComment":
                    return new EmptyInputDataCreator();

                case "TP_CSF_Loops_While":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        var count = rand.Next(0, 1001);
                        for(int i = 0; i < count; i++)
                        {
                            writer.WriteLine(rand.Next(1, 1001));
                        }
                        writer.WriteLine(0);
                    });

                case "TP_CSF_Loops_For":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.Next(0, 1001));
                    });

                case "TP_CSF_Loops_DoWhile":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        var count = rand.Next(0, 1001);
                        for (int i = 0; i < count; i++)
                        {
                            writer.WriteLine(rand.Next(1, 1001));
                        }
                        writer.WriteLine(0);
                    });

                case "TP_CSF_Loops_NestedLoops":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.Next(0, 31));
                        writer.WriteLine(rand.Next(0, 31));
                    });

                case "TP_CSF_Loops_BreakStatement":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        var count = rand.Next(0, 1001);
                        for (int i = 0; i < count; i++)
                        {
                            writer.WriteLine(rand.Next(1, 1001));
                        }
                        writer.WriteLine(0);
                    });

                case "TP_CSF_Loops_ContinueStatement":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        var count = rand.Next(0, 101);
                        writer.WriteLine(count);

                        for (int i = 0; i < count; i++) writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Identifiers_LettersOnly":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Identifiers_LettersAndDigits":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextShort());
                        writer.WriteLine(rand.NextShort());
                    });

                case "TP_CSF_Identifiers_LettersAndUnderscores":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Identifiers_LettersDigitsAndUnderscores":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Identifiers_UnderscoresAndLetters":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Identifiers_UnderscoresLettersAndDigits":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Identifiers_UnderscoresAndDigits":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Identifiers_UnderscoresOnly":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Arrays_1DArray":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        var n = rand.Next(1, 101);
                        writer.WriteLine(n);

                        for (int i = 0; i < n; i++) writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Arrays_1DArrayInitialization":
                    return new EnumerableInputDataCreator(ShortHelper.GetRange(0, 10).SelectCreateInputActions(n => writer =>
                    {
                        writer.WriteLine(n);
                    }));

                case "TP_CSF_Arrays_2DArray":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        var n = rand.Next(1, 11);
                        var m = rand.Next(1, 11);
                        writer.WriteLine(n);
                        writer.WriteLine(m);

                        for (int i = 0; i < n; i++)
                            for (int j = 0; j < m; j++)
                                writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Arrays_2DArrayInitialization":
                    return new EnumerableInputDataCreator(IntHelper.GetPairs(0, 7, 0, 7).SelectCreateInputActions(pair => writer =>
                    {
                        writer.WriteLine(pair.Item1);
                        writer.WriteLine(pair.Item2);
                    }));

                case "TP_CSF_Arrays_3DArray":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        var x = rand.Next(1, 6);
                        var y = rand.Next(1, 6);
                        var z = rand.Next(1, 6);
                        writer.WriteLine(x);
                        writer.WriteLine(y);
                        writer.WriteLine(z);

                        for (int i = 0; i < x; i++)
                            for (int j = 0; j < y; j++)
                                for(int k = 0; k < z; k++)
                                    writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Arrays_JaggedArray":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        var rows = rand.Next(1, 11);
                        writer.WriteLine(rows);

                        var cols = new int[rows];
                        for(int i = 0; i < rows; i++)
                        {
                            cols[i] = rand.Next(1, 11);
                            writer.WriteLine(cols[i]);
                        }

                        for (int i = 0; i < rows; i++)
                            for (int j = 0; j < cols[i]; j++)
                                writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Arrays_JaggedArrayInitialization":
                    return new EnumerableInputDataCreator(IntHelper.GetPairs(0, 9, 0, 12).SelectCreateInputActions(pair => writer =>
                    {
                        writer.WriteLine(pair.Item1);
                        writer.WriteLine(pair.Item2);
                    }));

                case "TP_CSF_IntegerLiterals_Decimal":
                    return new EmptyInputDataCreator();

                case "TP_CSF_IntegerLiterals_UnsignedDecimal":
                    return new EmptyInputDataCreator();

                case "TP_CSF_IntegerLiterals_LongDecimal":
                    return new EmptyInputDataCreator();

                case "TP_CSF_IntegerLiterals_UnsignedLongDecimal":
                    return new EmptyInputDataCreator();

                case "TP_CSF_IntegerLiterals_Hex":
                    return new EmptyInputDataCreator();

                case "TP_CSF_IntegerLiterals_UnsignedHex":
                    return new EmptyInputDataCreator();

                case "TP_CSF_IntegerLiterals_LongHex":
                    return new EmptyInputDataCreator();

                case "TP_CSF_IntegerLiterals_UnsignedLongHex":
                    return new EmptyInputDataCreator();

                case "TP_CSF_Loops_ForEach":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        var n = rand.Next(1, 101);
                        writer.WriteLine(n);

                        for (int i = 0; i < n; i++) writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_FloatingPointLiterals_Integers":
                    return new EmptyInputDataCreator();

                case "TP_CSF_FloatingPointLiterals_SimpleIntegers":
                    return new EmptyInputDataCreator();

                case "TP_CSF_FloatingPointLiterals_Doubles":
                    return new EmptyInputDataCreator();

                case "TP_CSF_FloatingPointLiterals_Floats":
                    return new EmptyInputDataCreator();

                case "TP_CSF_FloatingPointLiterals_Exp":
                    return new EmptyInputDataCreator();

                case "TP_CSF_Classes_EmptyClass":
                    return new EmptyInputDataCreator();

                case "TP_CSF_Classes_PublicFields":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextStandardString());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Classes_NoArgumentsConstructor":
                    return new EmptyInputDataCreator();

                case "TP_CSF_Classes_1ArgumentConstructor":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Classes_2ArgumentsConstructor":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextStandardString());
                    });

                case "TP_CSF_Classes_PublicStaticFields":
                    return new EnumerableInputDataCreator(IntHelper.GetRange(1, 100).SelectCreateInputActions(n => writer =>
                    {
                        writer.WriteLine(n);
                    }));

                case "TP_CSF_Classes_ManyConstructors":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        var n = rand.Next(1, 4);
                        writer.WriteLine(n);

                        var f1 = rand.NextInt();
                        writer.WriteLine(f1);

                        if (n > 1)
                        {
                            var f2 = rand.NextInt();
                            writer.WriteLine(f2);
                        }

                        if(n > 2)
                        {
                            var f3 = rand.NextInt();
                            writer.WriteLine(f3);
                        }
                    });

                case "TP_CSF_Methods_PrivateMethod":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Methods_PublicMethod":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Classes_PrivateFields":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextStandardString());
                    });

                case "TP_CSF_Classes_Destructor":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Classes_PrivateStaticFields":
                    return new EnumerableInputDataCreator(IntHelper.GetRange(1, 100).SelectCreateInputActions(n => writer =>
                    {
                        writer.WriteLine(n);
                    }));

                case "TP_CSF_Methods_PrivateStaticMethod":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Methods_PublicStaticMethod":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Methods_ManyMethods":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Methods_RecursiveMethod":
                    return new EnumerableInputDataCreator(IntHelper.GetRange(0, 99).SelectCreateInputActions(n => writer =>
                    {
                        writer.WriteLine(n);
                    }));

                case "TP_CSF_Methods_ManyRecursiveMethods":
                    return new EnumerableInputDataCreator(IntHelper.GetRange(0, 99).SelectCreateInputActions(n => writer =>
                    {
                        writer.WriteLine(n);
                    }));

                case "TP_CSF_Classes_InitFields":
                    return new EmptyInputDataCreator();

                case "TP_CSF_Classes_ConstructorWithCustomArguments":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Methods_CustomArguments":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Methods_Params":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        var n = rand.Next(0, 6);
                        writer.WriteLine(n);

                        for (int i = 0; i < n; i++) writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_ReferenceTypes_ExistingType":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextStandardString());
                        writer.WriteLine(rand.NextStandardString());
                    });

                case "TP_CSF_ReferenceTypes_CustomType":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_ReferenceTypes_DynamicType":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextStandardString());
                    });

                case "TP_CSF_ImplicitConv_ShortToInt":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextShort());
                    });

                case "TP_CSF_ImplicitConv_IntToLong":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_ImplicitConv_SByteToShort":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextSByte());
                    });

                case "TP_CSF_ImplicitConv_ByteToUShort":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextByte());
                    });

                case "TP_CSF_ImplicitConv_UShortToUInt":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextUShort());
                    });

                case "TP_CSF_ImplicitConv_UIntToULong":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextUInt());
                    });

                case "TP_CSF_ImplicitConv_FloatToDouble":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextFloat());
                    });

                case "TP_CSF_ImplicitConv_ShortToFloat":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextShort());
                    });

                case "TP_CSF_ImplicitConv_IntToDouble":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_ImplicitConv_LongToDecimal":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextLong());
                    });

                case "TP_CSF_ExplicitConv_IntToShort":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_ExplicitConv_ShortToSByte":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextShort());
                    });

                case "TP_CSF_ExplicitConv_LongToInt":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextLong());
                    });

                case "TP_CSF_Inheritance_SimpleInheritance":
                    return new EmptyInputDataCreator();

                case "TP_CSF_Inheritance_BaseClassMethod":
                    return new EmptyInputDataCreator();

                case "TP_CSF_Inheritance_BaseConstructor":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Inheritance_ProtectedField":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Inheritance_ProtectedConstructor":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Inheritance_ProtectedMethod":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Inheritance_InheritanceTree":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Inheritance_InheritanceChain":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Inheritance_AbstractClass":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                        writer.WriteLine(rand.NextInt(true));
                    });

                case "TP_CSF_Inheritance_InheritedAbstractMethod":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Inheritance_ExistingClassInheritance":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        var n = rand.Next(0, 101);
                        writer.WriteLine(n);

                        for (int i = 0; i < n; i++) writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Inheritance_ExistingClassInheritance2":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        var n = rand.Next(0, 101);
                        writer.WriteLine(n);

                        for (int i = 0; i < n; i++) writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Inheritance_ExistingAbstractClass":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextStandardString());
                        writer.WriteLine(rand.NextStandardString());
                    });

                case "TP_CSF_Polymorphism_MethodsInOneClass":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        var n = rand.Next(1, 4);
                        writer.WriteLine(n);

                        for (int i = 0; i < n; i++) writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Polymorphism_MethodsInRelatedClasses":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        var n = rand.Next(1, 4);
                        writer.WriteLine(n);

                        for (int i = 0; i < n; i++) writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Polymorphism_ClassWithVirtualMethod":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                    });

                case "TP_CSF_Polymorphism_ExistingClassWithVirtualMethod":
                    return new RandomInputDataCreator((writer, rand) =>
                    {
                        writer.WriteLine(rand.NextInt());
                    });

                default:
                    throw new ArgumentException("Cannot recognize program name.");
            }
        }
    }
}