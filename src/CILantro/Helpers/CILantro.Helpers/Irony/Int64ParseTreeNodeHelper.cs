using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System;

namespace CILantro.Helpers.Irony
{
    public static class Int64ParseTreeNodeHelper
    {
        public static long GetValue(ParseTreeNode node)
        {
            var int64LexicalParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.LEXICALS_INT64);

            var int64HexLexicalParseTreeNode = int64LexicalParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.LEXICALS_INT64_HEX);
            if(int64HexLexicalParseTreeNode != null)
            {
                var hexValue = int64HexLexicalParseTreeNode.Token.ValueString;
                return Convert.ToInt64(hexValue, 16);
            }

            throw new ArgumentException("Cannot recognize int64 value.");
        }
    }
}