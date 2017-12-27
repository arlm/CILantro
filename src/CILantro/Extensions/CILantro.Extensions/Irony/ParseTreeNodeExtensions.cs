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

        public static Type GetTypeType(this ParseTreeNode node)
        {
            var int16ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_int16);
            if (int16ParseTreeNode != null) return typeof(short);

            var int32ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_int32);
            if (int32ParseTreeNode != null) return typeof(int);

            var int64ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_int64);
            if (int64ParseTreeNode != null) return typeof(long);

            var stringParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_string);
            if (stringParseTreeNode != null) return typeof(string);

            var uint32ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_uint32);
            if (uint32ParseTreeNode != null) return typeof(uint);

            var uint64ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_uint64);
            if (uint64ParseTreeNode != null) return typeof(ulong);

            var voidParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_void);
            if (voidParseTreeNode != null) return typeof(void);

            throw new ArgumentException("Cannot get type type.");
        }

        public static Type GetSigArgType(this ParseTreeNode node)
        {
            var typeParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.type);
            return typeParseTreeNode.GetTypeType();
        }

        public static List<Type> GetSigArgs1Types(this ParseTreeNode node)
        {
            var result = new List<Type>();

            var sigArgParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.sigArg);
            var sigArgType = sigArgParseTreeNode.GetSigArgType();
            result.Add(sigArgType);

            return result;
        }

        public static List<Type> GetSigArgs0Types(this ParseTreeNode node)
        {
            var sigArgs1ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.sigArgs1);
            if(sigArgs1ParseTreeNode != null)
            {
                var result = sigArgs1ParseTreeNode.GetSigArgs1Types();
                return result;
            }

            return new List<Type>();
        }
    }
}