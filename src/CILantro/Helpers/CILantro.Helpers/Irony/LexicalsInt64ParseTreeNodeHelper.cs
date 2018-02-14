using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System;
using System.Globalization;

// TODO - REFAKTORING

namespace CILantro.Helpers.Irony
{
    public static class LexicalsInt64ParseTreeNodeHelper
    {
        public static long GetValue(ParseTreeNode node)
        {
            var lexicalsInt64DecParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.LEXICALS_INT64_DEC);
            if (lexicalsInt64DecParseTreeNode != null)
            {
                var decLiteral = lexicalsInt64DecParseTreeNode.Token.ValueString;
                return long.Parse(decLiteral);
            }

            var lexicalsInt64HexParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.LEXICALS_INT64_HEX);
            if (lexicalsInt64HexParseTreeNode != null)
            {
                var hexLiteral = lexicalsInt64HexParseTreeNode.Token.ValueString;
                hexLiteral = hexLiteral.Substring(2);
                return long.Parse(hexLiteral, NumberStyles.HexNumber);
            }

            throw new ArgumentException("Cannot recognize int64 lexical.");
        }
    }
}