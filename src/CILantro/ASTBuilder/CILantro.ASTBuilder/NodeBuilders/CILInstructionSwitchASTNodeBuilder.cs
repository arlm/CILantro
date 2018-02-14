using CILantro.AST.CILASTNodes;
using CILantro.AST.CILASTNodes.CILInstructions;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using CILantro.Helpers.Irony;
using Irony.Parsing;
using System;

// TODO - REFAKTORING

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILInstructionSwitchASTNodeBuilder : CILASTNodeBuilder<CILInstructionSwitch>
    {
        public override CILInstructionSwitch BuildNode(ParseTreeNode node)
        {
            var instructionSwitchParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.INSTR_SWITCH);

            CILInstructionSwitch result = null;

            var switchParseTreeNode = instructionSwitchParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_switch);
            if (switchParseTreeNode != null)
            {
                result = new SwitchInstruction();
            }

            if(result != null)
            {
                var labelsParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.labels);
                result.Labels = LabelsParseTreeNodeHelper.GetLabels(labelsParseTreeNode);

                return result;
            }

            throw new ArgumentException("Cannot recognize CIL instruction switch.");
        }
    }
}