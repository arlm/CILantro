using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System;

// TODO - REFAKTORING

namespace CILantro.Helpers.Irony
{
    public static class IdParseTreeNodeHelper
    {
        public static string GetValue(ParseTreeNode node)
        {
            var lexicalsIdParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.LEXICALS_ID);
            if(lexicalsIdParseTreeNode != null)
                return lexicalsIdParseTreeNode.Token.ValueString;

            var lexicalsSqstringParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.LEXICALS_SQSTRING);
            if (lexicalsSqstringParseTreeNode != null)
                return lexicalsSqstringParseTreeNode.Token.ValueString;

            throw new ArgumentException("Canno recognize id.");
        }
    }
}