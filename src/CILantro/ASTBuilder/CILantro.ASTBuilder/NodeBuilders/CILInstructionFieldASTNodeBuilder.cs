using CILantro.AST.CILASTNodes;
using CILantro.AST.CILASTNodes.CILInstructions;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using CILantro.Helpers.Irony;
using Irony.Parsing;
using System;

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILInstructionFieldASTNodeBuilder : CILASTNodeBuilder<CILInstructionField>
    {
        public override CILInstructionField BuildNode(ParseTreeNode node)
        {
            CILInstructionField result = null;

            var instrFieldParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.INSTR_FIELD);

            var ldfldParseTreeNode = instrFieldParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldfld);
            if(ldfldParseTreeNode != null)
            {
                result = new LoadFieldInstruction();
            }

            var ldfldaParseTreeNode = instrFieldParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldflda);
            if(ldfldaParseTreeNode != null)
            {
                result = new LoadFieldAddressInstruction();
            }

            var ldsfldParseTreeNode = instrFieldParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldsfld);
            if(ldsfldParseTreeNode != null)
            {
                result = new LoadStaticFieldInstruction();
            }

            var stfldParseTreeNode = instrFieldParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_stfld);
            if(stfldParseTreeNode != null)
            {
                result = new SetFieldInstruction();
            }

            var stsfldParseTreeNode = instrFieldParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_stsfld);
            if(stsfldParseTreeNode != null)
            {
                result = new SetStaticFieldInstruction();
            }

            if(result != null)
            {
                var typeParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.type);
                result.FieldType = TypeParseTreeNodeHelper.GetType(typeParseTreeNode);

                var typeSpecParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.typeSpec);
                result.FieldOwnerTypeSpecification = TypeSpecParseTreeNodeHelper.GetValue(typeSpecParseTreeNode);

                var idParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.id);
                result.FieldName = IdParseTreeNodeHelper.GetValue(idParseTreeNode);

                return result;
            }

            throw new ArgumentException("Cannot recognize CIL instruction field.");
        }
    }
}