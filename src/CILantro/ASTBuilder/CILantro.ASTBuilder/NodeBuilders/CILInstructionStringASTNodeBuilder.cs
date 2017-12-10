using CILantro.AST.CILASTNodes;
using CILantro.AST.CILASTNodes.CILInstructions;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System;

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILInstructionStringASTNodeBuilder : CILASTNodeBuilder<CILInstructionString>
    {
        public override CILInstructionString BuildNode(ParseTreeNode node)
        {
            var instrStringParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.INSTR_STRING);

            var ldstrParseTreeNode = instrStringParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.ldstr);
            if(ldstrParseTreeNode != null)
            {
                var loadStringInstruction = new LoadStringInstruction();
                return loadStringInstruction;
            }

            throw new ArgumentException("Cannot recognize CIL instruction string.");
        }
    }
}