using CILantro.AST.HelperClasses;
using CILantro.Grammar;
using Irony.Parsing;
using System;
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

        public static string GetCompQstringValue(this ParseTreeNode node)
        {
            var lexicalsQstringParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.LEXICALS_QSTRING);
            return lexicalsQstringParseTreeNode.Token.ValueString;
        }

        public static string GetIdValue(this ParseTreeNode node)
        {
            var lexicalsIdParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.LEXICALS_ID);
            return lexicalsIdParseTreeNode.Token.ValueString;
        }

        public static string GetName1Value(this ParseTreeNode node)
        {
            var idParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.id);
            if(idParseTreeNode != null)
            {
                return idParseTreeNode.GetIdValue();
            }

            var name1ParseTreeNodes = node.GetAllChildsWithGrammarName(GrammarNames.name1);
            if(name1ParseTreeNodes != null)
            {
                return string.Join(".", name1ParseTreeNodes.Select(n1 => n1.GetName1Value()));
            }

            throw new ArgumentException("Cannot get name1 value.");
        }

        public static string GetSlashedNameValue(this ParseTreeNode node)
        {
            var name1ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.name1);
            return name1ParseTreeNode.GetName1Value();
        }

        public static CILTypeSpecification GetTypeSpecificationValue(this ParseTreeNode node)
        {
            var classNameParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.className);

            var name1ParseTreeNode = classNameParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.name1);
            var assemblyName = name1ParseTreeNode.GetName1Value();

            var slashedNameParseTreeNode = classNameParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.slashedName);
            var className = slashedNameParseTreeNode.GetSlashedNameValue();

            return new CILTypeSpecification
            {
                AssemblyName = assemblyName,
                ClassName = className
            };
        }

        public static string GetMethodNameValue(this ParseTreeNode node)
        {
            var dotCtorParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.dotCtor);
            if(dotCtorParseTreeNode != null)
            {
                return ".ctor";
            }

            var name1ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.name1);
            if(name1ParseTreeNode != null)
            {
                return name1ParseTreeNode.GetName1Value();
            }

            throw new ArgumentException("Cannot get method name value.");
        }
    }
}