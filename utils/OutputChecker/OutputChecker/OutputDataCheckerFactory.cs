﻿using OutputChecker.OutputDataCheckers;

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

                default:
                    return null;
            }
        }
    }
}