// TODO - REFAKTORING

namespace CILantro.AST.HelperClasses
{
    public class CILClassName
    {
        public string AssemblyName { get; set; }

        public string ClassName { get; set; }

        public string UniqueName => $"[{AssemblyName}]{ClassName}";
    }
}