﻿using CILantro.Shared;
using System;

namespace CILantro.Engine.Parser.CILASTNodes
{
    public class CILLoadStringInstruction : CILInstruction
    {
        public string Value { get; set; }

        public override CILInstruction Execute(CILProgramRoot program, CILProgramState state)
        {
            state.Stack.Push(Value);

            return Method.GetNextInstruction(Order);
        }
    }
}
