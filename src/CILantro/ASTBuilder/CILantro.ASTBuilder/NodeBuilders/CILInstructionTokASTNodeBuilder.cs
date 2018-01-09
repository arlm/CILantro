using CILantro.AST.CILASTNodes;
using CILantro.AST.CILASTNodes.CILInstructions;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using CILantro.Helpers.Irony;
using Irony.Parsing;
using System;

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILInstructionTokASTNodeBuilder : CILASTNodeBuilder<CILInstructionTok>
    {
        public override CILInstructionTok BuildNode(ParseTreeNode node)
        {
            var instrTokHeadParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.instr_tok_head);
            var instrTokParseTreeNode = instrTokHeadParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.INSTR_TOK);

            CILInstructionTok result = null;

            var ldtokenParseTreeNode = instrTokParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.keyword_ldtoken);
            if(ldtokenParseTreeNode != null)
            {
                result = new LoadTokenInstruction();
            }

            if(result != null)
            {
                var ownerTypeParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.ownerType);
                result.OwnerType = OwnerTypeParseTreeNodeHelper.GetValue(ownerTypeParseTreeNode);

                return result;
            }

            throw new NotImplementedException();
        }
    }
}