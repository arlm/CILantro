using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System;

// TODO - REFAKTORING

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

            var dotCctorParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_dotCctor);
            if(dotCctorParseTreeNode != null)
            {
                return ".cctor";
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