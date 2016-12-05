﻿using CILantro.Engine.Parser.CILASTNodes;
using Irony.Parsing;

namespace CILantro.Engine.Parser.CILASTBuilder
{
    public class CILASTPopInstructionNodeBuilder : ICILASTNodeBuilder<CILPopInstruction>
    {
        public CILPopInstruction BuildNode(ParseTreeNode parseNode)
        {
            return new CILPopInstruction();
        }
    }
}
