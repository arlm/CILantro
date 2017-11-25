using System;
using Irony.Parsing;
using CILantro.Engine.AST.ASTNodes.Instructions;

namespace CILantro.Engine.Parser.CILASTConstruction.Instructions
{
    public class InstructionSwitchBuilder : CILASTNodeBuilder<InstructionSwitch>
    {
        public override InstructionSwitch BuildNode(ParseTreeNode node)
        {
            return new SwitchInstruction();
        }
    }
}