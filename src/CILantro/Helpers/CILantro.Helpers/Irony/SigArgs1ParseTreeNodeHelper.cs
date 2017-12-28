using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System;
using System.Collections.Generic;

namespace CILantro.Helpers.Irony
{
    public static class SigArgs1ParseTreeNodeHelper
    {
        public static List<Type> GetTypes(ParseTreeNode node)
        {
            var result = new List<Type>();

            var sigArgParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.sigArg);
            var sigArgType = SigArgParseTreeNodeHelper.GetType(sigArgParseTreeNode);
            result.Add(sigArgType);

            return result;
        }
    }
}