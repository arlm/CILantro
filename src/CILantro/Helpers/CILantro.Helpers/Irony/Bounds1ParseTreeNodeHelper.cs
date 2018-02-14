using CILantro.AST.HelperClasses;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System.Collections.Generic;

// TODO - REFAKTORING

namespace CILantro.Helpers.Irony
{
    public static class Bounds1ParseTreeNodeHelper
    {
        public static List<CILBound> GetBounds(ParseTreeNode node)
        {
            var result = new List<CILBound>();

            var bounds1ParseTreeNode = node;
            while(bounds1ParseTreeNode != null)
            {
                var boundParseTreeNode = bounds1ParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.bound);
                result.Add(new CILBound());

                bounds1ParseTreeNode = bounds1ParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.bounds1);
            }

            return result;
        }
    }
}