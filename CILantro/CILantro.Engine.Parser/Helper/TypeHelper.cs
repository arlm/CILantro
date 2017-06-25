using System;
using System.Reflection;

namespace CILantro.Engine.Parser.Helper
{
    public static class TypeHelper
    {
        public static Type GetTypeByName(string typeName, string assemblyName, string className)
        {
            switch(typeName)
            {
                case "bool":
                    return typeof(bool);
                case "char":
                    return typeof(char);
                case "class":
                    return GetTypeByAssemblyNameAndClassName(assemblyName, className);
                case "float32":
                    return typeof(float);
                case "float64":
                    return typeof(double);
                case "int32":
                    return typeof(int);
                case "int64":
                    return typeof(long);
                case "object":
                    return typeof(object);
                case "string":
                    return typeof(string);
                case "uint32":
                    return typeof(uint);
                case "uint64":
                    return typeof(ulong);
                case "valuetype":
                    return GetTypeByAssemblyNameAndClassName(assemblyName, className);
                default:
                    throw new ArgumentException("Cannot recognize type name.");
            }
        }

        private static Type GetTypeByAssemblyNameAndClassName(string assemblyName, string className)
        {
            var reflectedAssembly = Assembly.Load(assemblyName);
            var reflectedClass = reflectedAssembly.GetType(className);
            return reflectedClass;
        }
    }
}