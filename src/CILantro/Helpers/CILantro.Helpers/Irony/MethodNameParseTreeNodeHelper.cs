using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System;

namespace CILantro.Helpers.Irony
{
    public static class MethodNameParseTreeNodeHelper
    {
        public static string GetMethodName(ParseTreeNode node)
        {
            var dotCtorParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.dotCtor);
            if (dotCtorParseTreeNode != null)
            {
                return ".ctor";
            }

            var name1ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.name1);
            if (name1ParseTreeNode != null)
            {
                return Name1ParseTreeNodeHelper.GetValue(name1ParseTreeNode);
            }

            throw new ArgumentException("Cannot get method name value.");
        }
    }
}