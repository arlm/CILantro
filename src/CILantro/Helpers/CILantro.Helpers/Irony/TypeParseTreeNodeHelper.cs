using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System;
using System.Reflection;

namespace CILantro.Helpers.Irony
{
    public static class TypeParseTreeNodeHelper
    {
        public static Type GetType(ParseTreeNode node)
        {
            var boolParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_bool);
            if (boolParseTreeNode != null) return typeof(bool);

            var float32ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_float32);
            if (float32ParseTreeNode != null) return typeof(float);

            var float64ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_float64);
            if (float64ParseTreeNode != null) return typeof(double);

            var int8ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_int8);
            if (int8ParseTreeNode != null) return typeof(sbyte);

            var int16ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_int16);
            if (int16ParseTreeNode != null) return typeof(short);

            var int32ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_int32);
            if (int32ParseTreeNode != null) return typeof(int);

            var int64ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_int64);
            if (int64ParseTreeNode != null) return typeof(long);

            var stringParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_string);
            if (stringParseTreeNode != null) return typeof(string);

            var uint8ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_uint8);
            if (uint8ParseTreeNode != null) return typeof(byte);

            var uint16ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_uint16);
            if (uint16ParseTreeNode != null) return typeof(ushort);

            var uint32ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_uint32);
            if (uint32ParseTreeNode != null) return typeof(uint);

            var uint64ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_uint64);
            if (uint64ParseTreeNode != null) return typeof(ulong);

            var voidParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_void);
            if (voidParseTreeNode != null) return typeof(void);

            var valuetypeParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_valuetype);
            if (valuetypeParseTreeNode != null) return GetValueType(node);

            throw new ArgumentException("Cannot recognize type.");
        }

        public static Type GetValueType(ParseTreeNode node)
        {
            var classNameParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.className);
            var className = ClassNameParseTreeNodeHelper.GetClassName(classNameParseTreeNode);

            var assembly = Assembly.Load(className.AssemblyName);
            var type = assembly.GetType(className.ClassName);
            if (type != null) return type;

            throw new ArgumentException("Cannot recognize value type.");
        }
    }
}