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

                case "TP_CSF_ValueTypes_Bool":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ValueTypes_Byte":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ValueTypes_Char":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ValueTypes_Decimal":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ValueTypes_Double":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ValueTypes_Float":
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

                case "TP_CSF_Operators_ArithmeticOperators_Add":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_ArithmeticOperators_Subtract":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_ArithmeticOperators_Multiply":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_ArithmeticOperators_Divide":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_ArithmeticOperators_Modulo":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_ArithmeticOperators_Increment":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_ArithmeticOperators_Decrement":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Variables_1Variable":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Variables_2Variables":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Variables_3Variables":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Variables_4Variables":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Variables_5Variables":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Variables_6Variables":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Variables_7Variables":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Variables_8Variables":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Variables_9Variables":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Variables_10Variables":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_RelationalOperators_Equal":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_RelationalOperators_NotEqual":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_RelationalOperators_Greater":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_RelationalOperators_Less":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_RelationalOperators_GreaterOrEqual":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_RelationalOperators_LessOrEqual":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_LogicalOperators_And":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_LogicalOperators_Or":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_LogicalOperators_Not":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_BitwiseOperators_And":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_BitwiseOperators_Or":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_BitwiseOperators_Xor":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_BitwiseOperators_Not":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_BitwiseOperators_LeftShift":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_BitwiseOperators_RightShift":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_AssignOperators_Assign":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_AssignOperators_AddAndAssign":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_AssignOperators_SubtractAndAssign":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_AssignOperators_MultiplyAndAssign":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_AssignOperators_DivideAndAssign":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_AssignOperators_ModuloAndAssign":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_AssignOperators_LShiftAndAssign":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_AssignOperators_RShiftAndAssign":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_AssignOperators_AndAndAssign":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_AssignOperators_XorAndAssign":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_AssignOperators_OrAndAssign":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Decisions_If":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Decisions_IfElse":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Decisions_IfElseIf":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Decisions_IfElseIfElse":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Decisions_IfElseIfElseIf":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Decisions_IfElseIfElseIfElse":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Decisions_NestedIf":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Decisions_CharSwitch":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Decisions_ConditionalAssignOperator":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Decisions_BoolSwitch":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Decisions_ShortSwitch":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_MiscOperators_TypeOf":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Operators_MiscOperators_SizeOf":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Enums_Enum":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Enums_ExistingEnum":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Enums_EnumWithAssignedValues":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Enums_EnumLong":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Enums_EnumByte":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Enums_EnumShort":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Decisions_ByteSwitch":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Decisions_IntSwitch":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Decisions_EnumSwitch":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Decisions_NestedSwitch":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Strings_String":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Strings_Concatenation":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Strings_Length":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Strings_Chars":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Decisions_StringSwitch":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Comments_SingleLineComment":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Comments_MultiLineComment":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Loops_While":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Loops_For":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Loops_DoWhile":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Loops_NestedLoops":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Loops_BreakStatement":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Loops_ContinueStatement":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Identifiers_LettersOnly":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Identifiers_LettersAndDigits":
                    return new SameOutputsOutputDataChecker();

                default:
                    return null;
            }
        }
    }
}