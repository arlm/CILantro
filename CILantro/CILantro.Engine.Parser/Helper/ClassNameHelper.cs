using CILantro.Engine.Parser.Extensions;
using Irony.Parsing;
using System.Collections.Generic;
using System.Linq;

namespace CILantro.Engine.Parser.Helper
{
    public static class ClassNameHelper
    {
        public static string GetAssemblyName(ParseTreeNode classNameNode)
        {
            var classNameNameNode = classNameNode.GetChildNameNode();
            var classNameIdNode = classNameNameNode.GetChildIdNode();
            var result = classNameIdNode.ChildNodes.First().Token.ValueString;
            return result;
        }

        public static string GetClassName(ParseTreeNode classNameNode)
        {
            var slashedNameNode = classNameNode.GetChildSlashedNameNode();
            var slashedNameNameNode = slashedNameNode.GetChildNameNode();

            var idNodes = new List<ParseTreeNode>();

            var firstNameNode = slashedNameNameNode.GetAllChildNameNodes().ToList()[0];
            var secondNameNode = slashedNameNameNode.GetAllChildNameNodes().ToList()[1];

            do
            {
                var firstIdNode = firstNameNode.GetChildIdNode();
                var secondIdNode = secondNameNode.GetChildIdNode();

                if (firstIdNode != null) idNodes.Add(firstIdNode);

                if (secondIdNode != null)
                {
                    idNodes.Add(secondIdNode);
                    secondNameNode = null;
                }
                else
                {
                    firstNameNode = secondNameNode.GetAllChildNameNodes().ToList()[0];
                    secondNameNode = secondNameNode.GetAllChildNameNodes().ToList()[1];
                }
            }
            while (secondNameNode != null);

            var result = string.Join(".", idNodes.Select(id => id.ChildNodes.First().Token.ValueString));

            return result;
        }
    }
}