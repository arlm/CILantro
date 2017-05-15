using Irony.Parsing;
using System;

namespace CILantro.Engine.Parser.Extensions
{
    public static class ParseTreeNodeIntegerExtensions
    {
        public static int GetIntegerNodeValue(this ParseTreeNode integerNode)
        {
            var decIntegerNode = integerNode.GetChildDecIntegerNode();
            if(decIntegerNode != null)
            {
                return int.Parse(decIntegerNode.Token.ValueString);
            }

            throw new ArgumentException("Cannot recognize integer node.");
        }
    }
}
