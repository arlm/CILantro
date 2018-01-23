using CILantro.AST.CILASTNodes;
using CILantro.AST.CILASTNodes.CILInstructions;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using CILantro.Helpers.Irony;
using Irony.Parsing;
using System;

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILInstructionIASTNodeBuilder : CILASTNodeBuilder<CILInstructionI>
    {
        public override CILInstructionI BuildNode(ParseTreeNode node)
        {
            var instrIParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.INSTR_I);

            CILInstructionI result = null;

            var ldci4ParseTreeNode = instrIParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldci4);
            if(ldci4ParseTreeNode != null)
            {
                result = new LoadConstantIntInstruction();
            }

            var ldci4sParseTreeNode = instrIParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldci4s);
            if(ldci4sParseTreeNode != null)
            {
                result = new LoadConstantIntShortInstruction();
            }

            if(result != null)
            {
                var int32ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.int32);
                result.Value = Int32ParseTreeNodeHelper.GetValue(int32ParseTreeNode);

                return result;
            }

            throw new ArgumentException("Cannot recognize CIL instruction i.");
        }
    }
}