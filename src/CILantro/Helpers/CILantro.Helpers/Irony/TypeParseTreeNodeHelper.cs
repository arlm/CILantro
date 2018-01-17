using CILantro.AST.HelperClasses;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System;

namespace CILantro.Helpers.Irony
{
    public static class TypeParseTreeNodeHelper
    {
        public static CILType GetType(ParseTreeNode node)
        {
            var valuetypeParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_valuetype);
            if (valuetypeParseTreeNode != null) return GetValueType(node);

            var classParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_class);
            if (classParseTreeNode != null) return GetClassType(node);

            var typeParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.type);
            if (typeParseTreeNode != null) return GetArrayType(node);

            return GetSimpleType(node);
        }

        public static CILType GetSimpleType(ParseTreeNode node)
        {
            Type simpleType = null;

            var boolParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_bool);
            if (boolParseTreeNode != null) simpleType = typeof(bool);

            var charParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_char);
            if (charParseTreeNode != null) simpleType = typeof(char);

            var float32ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_float32);
            if (float32ParseTreeNode != null) simpleType = typeof(float);

            var float64ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_float64);
            if (float64ParseTreeNode != null) simpleType = typeof(double);

            var int8ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_int8);
            if (int8ParseTreeNode != null) simpleType = typeof(sbyte);

            var int16ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_int16);
            if (int16ParseTreeNode != null) simpleType = typeof(short);

            var int32ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_int32);
            if (int32ParseTreeNode != null) simpleType = typeof(int);

            var int64ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_int64);
            if (int64ParseTreeNode != null) simpleType = typeof(long);

            var stringParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_string);
            if (stringParseTreeNode != null) simpleType = typeof(string);

            var uint8ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_uint8);
            if (uint8ParseTreeNode != null) simpleType = typeof(byte);

            var uint16ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_uint16);
            if (uint16ParseTreeNode != null) simpleType = typeof(ushort);

            var uint32ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_uint32);
            if (uint32ParseTreeNode != null) simpleType = typeof(uint);

            var uint64ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_uint64);
            if (uint64ParseTreeNode != null) simpleType = typeof(ulong);

            var voidParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_void);
            if (voidParseTreeNode != null) simpleType = typeof(void);

            var objectParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.keyword_object);
            if (objectParseTreeNode != null) simpleType = typeof(object);

            if(simpleType != null)
            {
                return new CILType
                {
                    SimpleType = simpleType
                };
            }

            throw new ArgumentException("Cannot recognize simple type.");
        }

        public static CILType GetValueType(ParseTreeNode node)
        {
            var classNameParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.className);
            var className = ClassNameParseTreeNodeHelper.GetClassName(classNameParseTreeNode);

            return new CILType
            {
                ClassName = className
            };
        }

        public static CILType GetClassType(ParseTreeNode node)
        {
            var classNameParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.className);
            var className = ClassNameParseTreeNodeHelper.GetClassName(classNameParseTreeNode);

            return new CILType
            {
                ClassName = className
            };
        }

        public static CILType GetArrayType(ParseTreeNode node)
        {
            var typeParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.type);
            var elementsType = GetSimpleType(typeParseTreeNode);

            var arrayType = elementsType.SimpleType.MakeArrayType();

            return new CILType
            {
                SimpleType = arrayType
            };
        }
    }
}