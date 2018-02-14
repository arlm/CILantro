using CILantro.AST.CILASTNodes;
using CILantro.AST.CILASTNodes.CILInstructions;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System;

// TODO - REFAKTORING

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILInstructionNoneASTNodeBuilder : CILASTNodeBuilder<CILInstructionNone>
    {
        public override CILInstructionNone BuildNode(ParseTreeNode node)
        {
            var instrNoneParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.INSTR_NONE);

            var addParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_add);
            if(addParseTreeNode != null)
            {
                var addInstruction = new AddInstruction();
                return addInstruction;
            }

            var andParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_and);
            if(andParseTreeNode != null)
            {
                var andInstruction = new AndInstruction();
                return andInstruction;
            }

            var ceqParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ceq);
            if(ceqParseTreeNode != null)
            {
                var checkIfEqualInstruction = new CheckIfEqualInstruction();
                return checkIfEqualInstruction;
            }

            var cgtParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_cgt);
            if(cgtParseTreeNode != null)
            {
                var checkIfGreaterInstruction = new CheckIfGreaterInstruction();
                return checkIfGreaterInstruction;
            }

            var cltParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_clt);
            if(cltParseTreeNode != null)
            {
                var checkIfLessInstruction = new CheckIfLessInstruction();
                return checkIfLessInstruction;
            }

            var convi1ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_convi1);
            if(convi1ParseTreeNode != null)
            {
                var convertToSByteInstruction = new ConvertToSByteInstruction();
                return convertToSByteInstruction;
            }

            var convi2ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_convi2);
            if(convi2ParseTreeNode != null)
            {
                var convertToShortInstruction = new ConvertToShortInstruction();
                return convertToShortInstruction;
            }

            var convi4ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_convi4);
            if(convi4ParseTreeNode != null)
            {
                var convertToIntInstruction = new ConvertToIntInstruction();
                return convertToIntInstruction;
            }

            var convi8ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_convi8);
            if(convi8ParseTreeNode != null)
            {
                var convertToLongInstruction = new ConvertToLongInstruction();
                return convertToLongInstruction;
            }

            var convr4ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_convr4);
            if(convr4ParseTreeNode != null)
            {
                var convertToFloatInstruction = new ConvertToFloatInstruction();
                return convertToFloatInstruction;
            }

            var convr8ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_convr8);
            if(convr8ParseTreeNode != null)
            {
                var convertToDoubleInstruction = new ConvertToDoubleInstruction();
                return convertToDoubleInstruction;
            }

            var convu8ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_convu8);
            if(convu8ParseTreeNode != null)
            {
                var convertToUnsignedLongInstruction = new ConvertToUnsignedLongInstruction();
                return convertToUnsignedLongInstruction;
            }

            var divParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_div);
            if(divParseTreeNode != null)
            {
                var divideInstruction = new DivideInstruction();
                return divideInstruction;
            }

            var dupParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_dup);
            if(dupParseTreeNode != null)
            {
                var duplicateInstruction = new DuplicateInstruction();
                return duplicateInstruction;
            }

            var ldarg0ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldarg0);
            if(ldarg0ParseTreeNode != null)
            {
                var loadArgument0Instruction = new LoadArgument0Instruction();
                return loadArgument0Instruction;
            }

            var ldarg1ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldarg1);
            if(ldarg1ParseTreeNode != null)
            {
                var loadArgument1Instruction = new LoadArgument1Instruction();
                return loadArgument1Instruction;
            }

            var ldarg2ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldarg2);
            if(ldarg2ParseTreeNode != null)
            {
                var loadArgument2Instruction = new LoadArgument2Instruction();
                return loadArgument2Instruction;
            }

            var ldarg3ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldarg3);
            if(ldarg3ParseTreeNode != null)
            {
                var loadArgument3Instruction = new LoadArgument3Instruction();
                return loadArgument3Instruction;
            }

            var ldci40ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldci40);
            if(ldci40ParseTreeNode != null)
            {
                var loadConstantInt0Instruction = new LoadConstantInt0Instruction();
                return loadConstantInt0Instruction;
            }

            var ldci41ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldci41);
            if(ldci41ParseTreeNode != null)
            {
                var loadConstantInt1Instruction = new LoadConstantInt1Instruction();
                return loadConstantInt1Instruction;
            }

            var ldci42ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldci42);
            if(ldci42ParseTreeNode != null)
            {
                var loadConstantInt2Instruction = new LoadConstantInt2Instruction();
                return loadConstantInt2Instruction;
            }

            var ldci43ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldci43);
            if(ldci43ParseTreeNode != null)
            {
                var loadConstantInt3Instruction = new LoadConstantInt3Instruction();
                return loadConstantInt3Instruction;
            }

            var ldci44ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldci44);
            if(ldci44ParseTreeNode != null)
            {
                var loadConstantInt4Instruction = new LoadConstantInt4Instruction();
                return loadConstantInt4Instruction;
            }

            var ldci45ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldci45);
            if(ldci45ParseTreeNode != null)
            {
                var loadConstantInt5Instruction = new LoadConstantInt5Instruction();
                return loadConstantInt5Instruction;
            }

            var ldci46ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldci46);
            if(ldci46ParseTreeNode != null)
            {
                var loadConstantInt6Instruction = new LoadConstantInt6Instruction();
                return loadConstantInt6Instruction;
            }

            var ldci47ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldci47);
            if(ldci47ParseTreeNode != null)
            {
                var loadConstantInt7Instruction = new LoadConstantInt7Instruction();
                return loadConstantInt7Instruction;
            }

            var ldci48ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldci48);
            if(ldci48ParseTreeNode != null)
            {
                var loadConstantInt8Instruction = new LoadConstantInt8Instruction();
                return loadConstantInt8Instruction;
            }

            var ldci4m1ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldci4m1);
            if(ldci4m1ParseTreeNode != null)
            {
                var loadConstantIntMinus1Instruction = new LoadConstantIntMinus1Instruction();
                return loadConstantIntMinus1Instruction;
            }

            var ldelemi4ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldelemi4);
            if(ldelemi4ParseTreeNode != null)
            {
                var loadElementIntInstruction = new LoadElementIntInstruction();
                return loadElementIntInstruction;
            }

            var ldelemrefParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldelemref);
            if(ldelemrefParseTreeNode != null)
            {
                var loadElementRefInstruction = new LoadElementRefInstruction();
                return loadElementRefInstruction;
            }

            var ldlenParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldlen);
            if(ldlenParseTreeNode != null)
            {
                var loadLengthInstruction = new LoadLengthInstruction();
                return loadLengthInstruction;
            }

            var ldloc0ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldloc0);
            if(ldloc0ParseTreeNode != null)
            {
                var loadLocalVariable0Instruction = new LoadLocalVariable0Instruction();
                return loadLocalVariable0Instruction;
            }

            var ldloc1ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldloc1);
            if(ldloc1ParseTreeNode != null)
            {
                var loadLocalVariable1Instruction = new LoadLocalVariable1Instruction();
                return loadLocalVariable1Instruction;
            }

            var ldloc2ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldloc2);
            if(ldloc2ParseTreeNode != null)
            {
                var loadLocalVariable2Instruction = new LoadLocalVariable2Instruction();
                return loadLocalVariable2Instruction;
            }

            var ldloc3ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldloc3);
            if(ldloc3ParseTreeNode != null)
            {
                var loadLocalVariable3Instruction = new LoadLocalVariable3Instruction();
                return loadLocalVariable3Instruction;
            }

            var mulParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_mul);
            if(mulParseTreeNode != null)
            {
                var multiplyInstruction = new MultiplyInstruction();
                return multiplyInstruction;
            }

            var notParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_not);
            if(notParseTreeNode != null)
            {
                var notInstruction = new NotInstruction();
                return notInstruction;
            }

            var orParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_or);
            if(orParseTreeNode != null)
            {
                var orInstruction = new OrInstruction();
                return orInstruction;
            }

            var popParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_pop);
            if(popParseTreeNode != null)
            {
                var popInstruction = new PopInstruction();
                return popInstruction;
            }

            var remParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_rem);
            if(remParseTreeNode != null)
            {
                var remainderInstruction = new RemainderInstruction();
                return remainderInstruction;
            }

            var retParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ret);
            if(retParseTreeNode != null)
            {
                var returnInstruction = new ReturnInstruction();
                return returnInstruction;
            }

            var shlParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_shl);
            if(shlParseTreeNode != null)
            {
                var shiftLeftInstruction = new ShiftLeftInstruction();
                return shiftLeftInstruction;
            }

            var shrParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_shr);
            if(shrParseTreeNode != null)
            {
                var shiftRightInstruction = new ShiftRightInstruction();
                return shiftRightInstruction;
            }

            var stelemi4ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_stelemi4);
            if(stelemi4ParseTreeNode != null)
            {
                var setElementIntInstruction = new SetElementIntInstruction();
                return setElementIntInstruction;
            }

            var stelemrefParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_stelemref);
            if(stelemrefParseTreeNode != null)
            {
                var setElementRefInstruction = new SetElementRefInstruction();
                return setElementRefInstruction;
            }

            var stloc0ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_stloc0);
            if(stloc0ParseTreeNode != null)
            {
                var setLocalVariable0Instruction = new SetLocalVariable0Instruction();
                return setLocalVariable0Instruction;
            }

            var stloc1ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_stloc1);
            if(stloc1ParseTreeNode != null)
            {
                var setLocalVariable1Instruction = new SetLocalVariable1Instruction();
                return setLocalVariable1Instruction;
            }

            var stloc2ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_stloc2);
            if(stloc2ParseTreeNode != null)
            {
                var setLocalVariable2Instruction = new SetLocalVariable2Instruction();
                return setLocalVariable2Instruction;
            }

            var stloc3ParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_stloc3);
            if(stloc3ParseTreeNode != null)
            {
                var setLocalVariable3Instruction = new SetLocalVariable3Instruction();
                return setLocalVariable3Instruction;
            }

            var subParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_sub);
            if(subParseTreeNode != null)
            {
                var subtractInstruction = new SubtractInstruction();
                return subtractInstruction;
            }

            var xorParseTreeNode = instrNoneParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_xor);
            if(xorParseTreeNode != null)
            {
                var xorInstruction = new XorInstruction();
                return xorInstruction;
            }

            throw new ArgumentException("Cannot recognize CIL instruction none.");
        }
    }
}