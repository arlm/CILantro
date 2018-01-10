using System;
using System.Linq;
using System.Reflection;

namespace CILantro.Reflection
{
    public static class RuntimeTypeManager
    {
        public static string DefaultAssemblyName { get; set; }

        public static Type GetRuntimeType(string className, string assemblyName)
        {
            Assembly assembly = null;

            if (!string.IsNullOrEmpty(assemblyName))
            {
                assembly = Assembly.Load(assemblyName);
            }
            else
            {
                var assemblyNameObject = new AssemblyName(DefaultAssemblyName);
                assembly = AppDomain.CurrentDomain.GetAssemblies().First(a => a.GetName().Name == assemblyNameObject.Name);
            }

            var type = assembly.GetType(className);
            if (type != null) return type;

            throw new ArgumentException("Cannot recognize type.");
        }
    }
}