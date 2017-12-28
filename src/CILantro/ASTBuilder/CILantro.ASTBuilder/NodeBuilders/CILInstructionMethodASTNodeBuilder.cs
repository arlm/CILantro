using CILantro.AST.CILASTNodes;
using CILantro.AST.CILASTNodes.CILInstructions;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using CILantro.Helpers.Irony;
using Irony.Parsing;
using System;

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILInstructionMethodASTNodeBuilder : CILASTNodeBuilder<CILInstructionMethod>
    {
        public override CILInstructionMethod BuildNode(ParseTreeNode node)
        {
            CILInstructionMethod result = null;

            var instrMethodParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.INSTR_METHOD);

            var callParseTreeNode = instrMethodParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.call);
            if(callParseTreeNode != null)
            {
                result = new CallInstruction();
            }

            if(result != null)
            {
                var typeParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.type);
                result.MethodReturnType = TypeParseTreeNodeHelper.GetType(typeParseTreeNode);

                var typeSpecParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.typeSpec);
                result.TypeSpecification = typeSpecParseTreeNode.GetTypeSpecificationValue();

                var methodNameParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.methodName);
                result.MethodName = methodNameParseTreeNode.GetMethodNameValue();

                var sigArgs0ParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.sigArgs0);
                result.MethodArgumentTypes = SigArgs0ParseTreeNodeHelper.GetTypes(sigArgs0ParseTreeNode);

                return result;
            }

            throw new ArgumentException("Cannot recognize CIL instruction method.");
        }
    }
}