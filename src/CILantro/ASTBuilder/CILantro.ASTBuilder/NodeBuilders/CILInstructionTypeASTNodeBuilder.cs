using CILantro.AST.CILASTNodes;
using CILantro.AST.CILASTNodes.CILInstructions;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using CILantro.Helpers.Irony;
using Irony.Parsing;
using System;

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILInstructionTypeASTNodeBuilder : CILASTNodeBuilder<CILInstructionType>
    {
        public override CILInstructionType BuildNode(ParseTreeNode node)
        {
            var instrTypeParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.INSTR_TYPE);

            CILInstructionType result = null;

            var boxParseTreeNode = instrTypeParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_box);
            if(boxParseTreeNode != null)
            {
                result = new BoxInstruction();
            }

            var newarrParseTreeNode = instrTypeParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_newarr);
            if(newarrParseTreeNode != null)
            {
                result = new NewArrayInstruction();
            }

            var unboxanyParseTreeNode = instrTypeParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_unboxany);
            if(unboxanyParseTreeNode != null)
            {
                result = new UnboxAnyInstruction();
            }

            if(result != null)
            {
                var typeSpecParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.typeSpec);
                result.TypeSpecification = TypeSpecParseTreeNodeHelper.GetValue(typeSpecParseTreeNode);

                return result;
            }

            throw new ArgumentException("Cannot recognize CIL instruction type.");
        }
    }
}