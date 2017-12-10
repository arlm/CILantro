using CILantro.AST.CILASTNodes;
using CILantro.AST.CILASTNodes.CILInstructions;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System;

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILInstructionMethodASTNodeBuilder : CILASTNodeBuilder<CILInstructionMethod>
    {
        public override CILInstructionMethod BuildNode(ParseTreeNode node)
        {
            var instrMethodParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.INSTR_METHOD);

            var callParseTreeNode = instrMethodParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.call);
            if(callParseTreeNode != null)
            {
                var callInstruction = new CallInstruction();
                return callInstruction;
            }

            throw new ArgumentException("Cannot recognize CIL instruction method.");
        }
    }
}