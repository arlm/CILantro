using CILantro.AST.CILASTNodes;
using CILantro.AST.CILASTNodes.CILInstructions;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using CILantro.Helpers.Irony;
using Irony.Parsing;
using System;

// TODO - REFAKTORING

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILInstructionRASTNodeBuilder : CILASTNodeBuilder<CILInstructionR>
    {
        public override CILInstructionR BuildNode(ParseTreeNode node)
        {
            var instrRParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.INSTR_R);

            CILInstructionR result = null;

            var ldcr4ParseTreeNode = instrRParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldcr4);
            if(ldcr4ParseTreeNode != null)
            {
                result = new LoadConstantFloatInstruction();
            }

            var ldcr8ParseTreeNode = instrRParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldcr8);
            if(ldcr8ParseTreeNode != null)
            {
                result = new LoadConstantDoubleInstruction();
            }

            if(result != null)
            {
                var float64ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.float64);
                result.Value = Float64ParseTreeNodeHelper.GetValue(float64ParseTreeNode);

                return result;
            }

            throw new ArgumentException("Cannot recognize CIL instruction r.");
        }
    }
}