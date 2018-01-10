﻿using CILantro.AST.CILASTNodes;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using CILantro.Helpers.Irony;
using Irony.Parsing;

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILClassFieldASTNodeBuilder : CILASTNodeBuilder<CILClassField>
    {
        public override CILClassField BuildNode(ParseTreeNode node)
        {
            var result = new CILClassField();

            var idParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.id);
            var fieldName = IdParseTreeNodeHelper.GetValue(idParseTreeNode);
            result.Name = fieldName;

            var typeParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.type);
            var fieldType = TypeParseTreeNodeHelper.GetType(typeParseTreeNode);
            result.Type = fieldType;

            var fieldAttrParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.fieldAttr);
            result.Attributes = FieldAttrParseTreeNodeHelper.GetAllAttributes(fieldAttrParseTreeNode);

            var initOptParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.initOpt);

            return result;
        }
    }
}