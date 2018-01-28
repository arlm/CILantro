using CILantro.AST.CILInstances;
using CILantro.State;
using System.Collections.Generic;
using System.IO;

namespace CILantro.Interpreter
{
    public class CILInterpreter
    {
        public void Interpret(CILProgramInstance programInstance, StreamReader inputStream, StreamWriter outputStrem)
        {
            var state = new CILProgramState();
            var callStack = new Stack<CILInstructionInstance>();

            var entryPointInstance = programInstance.CreateEntryPointInstance();

            var instructionInstance = entryPointInstance.GetFirstInstructionInstance();
            while(instructionInstance != null)
            {
                instructionInstance = instructionInstance.Execute(state, programInstance, callStack);
            }
        }
    }
}