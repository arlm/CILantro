using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System;
using System.Collections.Generic;

namespace CILantro.Helpers.Irony
{
    public static class SigArgs0ParseTreeNodeHelper
    {
        public static List<Type> GetTypes(this ParseTreeNode node)
        {
            var sigArgs1ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.sigArgs1);
            if (sigArgs1ParseTreeNode != null)
            {
                var result = SigArgs1ParseTreeNodeHelper.GetTypes(sigArgs1ParseTreeNode);
                return result;
            }

            return new List<Type>();
        }
    }
}