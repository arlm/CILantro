using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CILantro.AST.CILCustomTypes
{
    public class CILantroMethodBody : MethodBody
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override IList<ExceptionHandlingClause> ExceptionHandlingClauses
        {
            get
            {
                return base.ExceptionHandlingClauses;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override byte[] GetILAsByteArray()
        {
            return base.GetILAsByteArray();
        }

        public override bool InitLocals
        {
            get
            {
                return base.InitLocals;
            }
        }

        public override int LocalSignatureMetadataToken
        {
            get
            {
                return base.LocalSignatureMetadataToken;
            }
        }

        public override IList<LocalVariableInfo> LocalVariables
        {
            get
            {
                return base.LocalVariables;
            }
        }

        public override int MaxStackSize
        {
            get
            {
                return base.MaxStackSize;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}