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
    public class CILInstructionI8ASTNodeBuilder : CILASTNodeBuilder<CILInstructionI8>
    {
        public override CILInstructionI8 BuildNode(ParseTreeNode node)
        {
            var instrI8ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.INSTR_I8);

            CILInstructionI8 result = null;

            var ldci8ParseTreeNode = instrI8ParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldci8);
            if(ldci8ParseTreeNode != null)
            {
                result = new LoadConstantLongInstruction();
            }

            if(result != null)
            {
                var int64ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.int64);
                result.Value = Int64ParseTreeNodeHelper.GetValue(int64ParseTreeNode);

                return result;
            }

            throw new ArgumentException("Cannot recognize CIL instruction i8.");
        }
    }
}
