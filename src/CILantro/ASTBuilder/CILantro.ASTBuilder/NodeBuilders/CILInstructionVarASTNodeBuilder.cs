using CILantro.AST.CILASTNodes;
using CILantro.AST.CILASTNodes.CILInstructions;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using CILantro.Helpers.Irony;
using Irony.Parsing;
using System;

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILInstructionVarASTNodeBuilder : CILASTNodeBuilder<CILInstructionVar>
    {
        public override CILInstructionVar BuildNode(ParseTreeNode node)
        {
            var instrVarParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.INSTR_VAR);

            CILInstructionVar result = null;

            var ldlocsParseTreeNode = instrVarParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldlocs);
            if(ldlocsParseTreeNode != null)
            {
                result = new LoadLocalVariableShortInstruction();
            }

            var stlocsParseTreeNode = instrVarParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_stlocs);
            if(stlocsParseTreeNode != null)
            {
                result = new SetLocalVariableShortInstruction();
            }

            if(result != null)
            {
                var idParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.id);
                result.VariableId = IdParseTreeNodeHelper.GetValue(idParseTreeNode);

                return result;
            }

            throw new ArgumentException("Cannot recognize CIL instruction var.");
        }
    }
}