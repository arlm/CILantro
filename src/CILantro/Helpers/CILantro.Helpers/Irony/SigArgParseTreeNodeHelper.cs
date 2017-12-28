using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System;

namespace CILantro.Helpers.Irony
{
    public static class SigArgParseTreeNodeHelper
    {
        public static Type GetType(ParseTreeNode node)
        {
            var typeParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.type);
            return TypeParseTreeNodeHelper.GetType(typeParseTreeNode);
        }
    }
}