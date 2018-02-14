using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System;
using System.Globalization;

// TODO - REFAKTORING

namespace CILantro.Helpers.Irony
{
    public static class LexicalsInt32ParseTreeNodeHelper
    {
        public static int GetValue(ParseTreeNode node)
        {
            var lexicalsInt32DecParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.LEXICALS_INT32_DEC);
            if(lexicalsInt32DecParseTreeNode != null)
            {
                var decLiteral = lexicalsInt32DecParseTreeNode.Token.ValueString;
                return int.Parse(decLiteral);
            }

            var lexicalsInt32HexParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.LEXICALS_INT32_HEX);
            if(lexicalsInt32HexParseTreeNode != null)
            {
                var hexLiteral = lexicalsInt32HexParseTreeNode.Token.ValueString;
                hexLiteral = hexLiteral.Substring(2);
                return int.Parse(hexLiteral, NumberStyles.HexNumber);
            }

            throw new ArgumentException("Cannot recognize int32 lexical.");
        }
    }
}