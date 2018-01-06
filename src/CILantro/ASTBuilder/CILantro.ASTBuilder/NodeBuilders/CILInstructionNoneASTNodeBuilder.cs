using CILantro.AST.CILASTNodes;
using CILantro.AST.CILASTNodes.CILInstructions;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System;

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

            throw new ArgumentException("Cannot recognize CIL instruction none.");
        }
    }
}