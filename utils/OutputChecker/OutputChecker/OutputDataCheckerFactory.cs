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

                case "TP_CSF_Identifiers_LettersAndUnderscores":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Identifiers_LettersDigitsAndUnderscores":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Identifiers_UnderscoresAndLetters":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Identifiers_UnderscoresLettersAndDigits":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Identifiers_UnderscoresAndDigits":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Identifiers_UnderscoresOnly":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Arrays_1DArray":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Arrays_1DArrayInitialization":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Arrays_2DArray":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Arrays_2DArrayInitialization":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Arrays_3DArray":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Arrays_JaggedArray":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Arrays_JaggedArrayInitialization":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_IntegerLiterals_Decimal":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_IntegerLiterals_UnsignedDecimal":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_IntegerLiterals_LongDecimal":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_IntegerLiterals_UnsignedLongDecimal":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_IntegerLiterals_Hex":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_IntegerLiterals_UnsignedHex":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_IntegerLiterals_LongHex":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_IntegerLiterals_UnsignedLongHex":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Loops_ForEach":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_FloatingPointLiterals_Integers":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_FloatingPointLiterals_SimpleIntegers":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_FloatingPointLiterals_Doubles":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_FloatingPointLiterals_Floats":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_FloatingPointLiterals_Exp":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Classes_EmptyClass":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Classes_PublicFields":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Classes_NoArgumentsConstructor":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Classes_1ArgumentConstructor":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Classes_2ArgumentsConstructor":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Classes_PublicStaticFields":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Classes_ManyConstructors":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Methods_PrivateMethod":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Methods_PublicMethod":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Classes_PrivateFields":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Classes_Destructor":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Classes_PrivateStaticFields":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Methods_PrivateStaticMethod":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Methods_PublicStaticMethod":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Methods_ManyMethods":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Methods_RecursiveMethod":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Methods_ManyRecursiveMethods":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Classes_InitFields":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Classes_ConstructorWithCustomArguments":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Methods_CustomArguments":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_Methods_Params":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ReferenceTypes_ExistingType":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ReferenceTypes_CustomType":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ReferenceTypes_DynamicType":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ImplicitConv_ShortToInt":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ImplicitConv_IntToLong":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ImplicitConv_SByteToShort":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ImplicitConv_ByteToUShort":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ImplicitConv_UShortToUInt":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ImplicitConv_UIntToULong":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ImplicitConv_FloatToDouble":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ImplicitConv_ShortToFloat":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ImplicitConv_IntToDouble":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ImplicitConv_LongToDecimal":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ExplicitConv_IntToShort":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ExplicitConv_ShortToSByte":
                    return new SameOutputsOutputDataChecker();

                case "TP_CSF_ExplicitConv_LongToInt":
                    return new SameOutputsOutputDataChecker();

                default:
                    return null;
            }
        }
    }
}