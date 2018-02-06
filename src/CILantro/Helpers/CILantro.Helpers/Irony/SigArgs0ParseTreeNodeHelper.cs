using CILantro.AST.HelperClasses;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace CILantro.Helpers.Irony
{
    public static class SigArgs0ParseTreeNodeHelper
    {
        public static List<CILType> GetTypes(ParseTreeNode node)
        {
            var sigArgs1ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.sigArgs1);
            if (sigArgs1ParseTreeNode != null)
            {
                var result = SigArgs1ParseTreeNodeHelper.GetTypes(sigArgs1ParseTreeNode);
                return result;
            }

            return new List<CILType>();
        }

        public static List<string> GetNames(ParseTreeNode node)
        {
            var sigArgs1ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.sigArgs1);
            if (sigArgs1ParseTreeNode != null)
            {
                var result = SigArgs1ParseTreeNodeHelper.GetNames(sigArgs1ParseTreeNode);
                return result;
            }

            return new List<string>();
        }

        public static OrderedDictionary GetLocalsDictionary(ParseTreeNode node)
        {
            var sigArgs1ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.sigArgs1);
            if(sigArgs1ParseTreeNode != null)
            {
                var result = SigArgs1ParseTreeNodeHelper.GetLocalsDictionary(sigArgs1ParseTreeNode);
                return result;
            }

            return new OrderedDictionary();
        }
    }
}