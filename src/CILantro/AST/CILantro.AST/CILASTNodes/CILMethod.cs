using CILantro.AST.CILInstances;
using CILantro.AST.HelperClasses;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace CILantro.AST.CILASTNodes
{
    public class CILMethod : CILASTNode
    {
        public string MethodName { get; set; }

        public List<CILInstruction> Instructions { get; set; }

        public List<string> InstructionsLabels { get; set; }

        public bool IsEntryPoint { get; set; }

        public List<CILType> LocalsTypes { get; set; }

        public List<Guid> LocalsAddresses { get; set; }

        public OrderedDictionary Locals { get; set; }

        public CILClass ParentClass { get; set; }

        public bool IsConstructor => MethodName.Equals(".ctor");

        public CILInstruction GetNextInstruction(CILInstruction currentInstruction)
        {
            var currentIndex = Instructions.IndexOf(currentInstruction);
            var nextIndex = currentIndex + 1;

            if (nextIndex >= Instructions.Count) return null;
            return Instructions[nextIndex];
        }

        public CILInstruction GetInstructionByBranchTarget(string label)
        {
            var instructionIndex = InstructionsLabels.IndexOf(label);
            return Instructions[instructionIndex];
        }

        public Guid GetLocalAddress(string localId)
        {
            var localIndex = -1;
            var i = -1;
            foreach(var localKey in Locals.Keys)
            {
                i++;
                if (localKey.Equals(localId)) localIndex = i;
            }

            return LocalsAddresses[localIndex];
        }

        public object GetLocalByAddress(Guid address)
        {
            var localIndex = LocalsAddresses.IndexOf(address);
            return Locals[localIndex];
        }

        public CILMethodInstance CreateInstance()
        {
            var classInstance = ParentClass.CreateInstance();
            return new CILMethodInstance(this, classInstance);
        }
    }
}