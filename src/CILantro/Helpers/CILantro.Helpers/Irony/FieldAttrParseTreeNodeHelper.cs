using CILantro.AST.HelperEnums;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System.Collections.Generic;

// TODO - REFAKTORING

namespace CILantro.Helpers.Irony
{
    public static class FieldAttrParseTreeNodeHelper
    {
        public static List<CILClassFieldAttribute> GetAllAttributes(ParseTreeNode node)
        {
            var result = new List<CILClassFieldAttribute>();

            var fieldAttrParseTreeNode = node;
            while(fieldAttrParseTreeNode != null)
            {
                var literalParseTreeNode = fieldAttrParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.keyword_literal);
                if (literalParseTreeNode != null) result.Add(CILClassFieldAttribute.Literal);

                var publicParseTreeNode = fieldAttrParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.keyword_public);
                if (publicParseTreeNode != null) result.Add(CILClassFieldAttribute.Public);

                var staticParseTreeNode = fieldAttrParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.keyword_static);
                if (staticParseTreeNode != null) result.Add(CILClassFieldAttribute.Static);

                fieldAttrParseTreeNode = fieldAttrParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.fieldAttr);
            }

            return result;
        }
    }
}