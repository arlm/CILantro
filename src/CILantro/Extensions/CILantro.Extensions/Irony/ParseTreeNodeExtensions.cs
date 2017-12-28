using Irony.Parsing;
using System.Collections.Generic;
using System.Linq;

namespace CILantro.Extensions.Irony
{
    public static class ParseTreeNodeExtensions
    {
        public static bool HasGrammarName(this ParseTreeNode node, string grammarName)
        {
            return node.Term.Name.Equals(grammarName);
        }

        public static ParseTreeNode GetFirstChildWithGrammarName(this ParseTreeNode node, string grammarName)
        {
            return node.ChildNodes.FirstOrDefault(cn => cn.HasGrammarName(grammarName));
        }

        public static List<ParseTreeNode> GetAllChildsWithGrammarName(this ParseTreeNode node, string grammarName)
        {
            return node.ChildNodes.Where(cn => cn.HasGrammarName(grammarName)).ToList();
        }
    }
}