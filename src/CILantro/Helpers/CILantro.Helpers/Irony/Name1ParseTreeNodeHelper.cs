using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System;
using System.Linq;

// TODO - REFAKTORING

namespace CILantro.Helpers.Irony
{
    public static class Name1ParseTreeNodeHelper
    {
        public static string GetValue(ParseTreeNode node)
        {
            var idParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.id);
            if (idParseTreeNode != null)
            {
                return IdParseTreeNodeHelper.GetValue(idParseTreeNode);
            }

            var name1ParseTreeNodes = node.GetAllChildsWithGrammarName(GrammarNames.name1);
            if (name1ParseTreeNodes != null)
            {
                return string.Join(".", name1ParseTreeNodes.Select(n1 => GetValue(n1)));
            }

            throw new ArgumentException("Cannot get name1 value.");
        }
    }
}