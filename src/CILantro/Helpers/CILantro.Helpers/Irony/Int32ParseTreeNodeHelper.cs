using Irony.Parsing;
using System.Linq;

namespace CILantro.Helpers.Irony
{
    public static class Int32ParseTreeNodeHelper
    {
        public static int GetValue(ParseTreeNode node)
        {
            return (int)node.ChildNodes.First().ChildNodes.First().Token.Value;
        }
    }
}