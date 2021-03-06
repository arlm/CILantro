﻿using CILantro.AST.CILASTNodes;
using CILantro.AST.CILASTNodes.CILInstructions;
using CILantro.Extensions.Irony;
using CILantro.Grammar;
using CILantro.Helpers.Irony;
using Irony.Parsing;
using System;

// TODO - REFAKTORING

namespace CILantro.ASTBuilder.NodeBuilders
{
    public class CILInstructionStringASTNodeBuilder : CILASTNodeBuilder<CILInstructionString>
    {
        public override CILInstructionString BuildNode(ParseTreeNode node)
        {
            CILInstructionString result = null;

            var instrStringParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.INSTR_STRING);

            var ldstrParseTreeNode = instrStringParseTreeNode?.GetFirstChildWithGrammarName(GrammarNames.keyword_ldstr);
            if(ldstrParseTreeNode != null)
            {
                result = new LoadStringInstruction();
            }

            if (result != null)
            {
                var compQstringParseTreeNode = node.GetFirstChildWithGrammarName(GrammarNames.compQstring);
                result.StringValue = CompQstringParseTreeNodeHelper.GetValue(compQstringParseTreeNode);

                return result;
            }

            throw new ArgumentException("Cannot recognize CIL instruction string.");
        }
    }
}