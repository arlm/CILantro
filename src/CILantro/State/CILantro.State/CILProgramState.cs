using System.Collections.Generic;

// TODO - REFAKTORING

namespace CILantro.State
{
    public class CILProgramState
    {
        public Stack<object> Stack { get; set; } = new Stack<object>();
    }
}