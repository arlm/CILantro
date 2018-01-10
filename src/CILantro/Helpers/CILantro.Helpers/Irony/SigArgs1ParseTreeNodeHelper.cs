using CILantro.AST.HelperClasses;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using Irony.Parsing;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace CILantro.Helpers.Irony
{
    public static class SigArgs1ParseTreeNodeHelper
    {
        public static List<CILType> GetTypes(ParseTreeNode node)
        {
            var result = new List<CILType>();

            var sigArgs1ParseTreeNode = node;
            var sigArgParseTreeNode = sigArgs1ParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.sigArg);
            while(sigArgParseTreeNode != null)
            {
                var sigArgType = SigArgParseTreeNodeHelper.GetType(sigArgParseTreeNode);
                result.Add(sigArgType);

                sigArgs1ParseTreeNode = sigArgs1ParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.sigArgs1);
                sigArgParseTreeNode = sigArgs1ParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.sigArg);
            }

            result.Reverse();

            return result;
        }

        public static OrderedDictionary GetLocalsDictionary(ParseTreeNode node)
        {
            var types = GetTypes(node);
            var result = new OrderedDictionary(types.Count);

            var localsIds = new object[types.Count];

            var sigArgs1ParseTreeNode = node;
            var sigArgParseTreeNode = sigArgs1ParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.sigArg);
            while(sigArgParseTreeNode != null)
            {
                var sigArgId = SigArgParseTreeNodeHelper.GetId(sigArgParseTreeNode);

                var paramAttrParseTreeNode = sigArgParseTreeNode.GetFirstChildWithGrammarName(GrammarNames.paramAttr);
                var sigArgNumber = ParamAttrParseTreeNodeHelper.GetNumberAttribute(paramAttrParseTreeNode);

                localsIds[sigArgNumber] = sigArgId;

                sigArgs1ParseTreeNode = sigArgs1ParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.sigArgs1);
                sigArgParseTreeNode = sigArgs1ParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.sigArg);
            }

            foreach(var localId in localsIds)
            {
                result.Add(localId, null);
            }

            return result;
        }
    }
}