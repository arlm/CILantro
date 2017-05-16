
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.6.1055.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly Calculator
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 02 00 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 0A 43 61 6C 63 75 6C 61 74 6F 72 00 00 )    // ...Calculator..
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 0A 43 61 6C 63 75 6C 61 74 6F 72 00 00 )    // ...Calculator..
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 12 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                  20 32 30 31 37 00 00 )                            //  2017..
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 64 33 38 65 34 38 30 65 2D 66 65 62 62   // ..$d38e480e-febb
                                                                                                  2D 34 33 31 66 2D 39 35 30 37 2D 63 64 39 62 34   // -431f-9507-cd9b4
                                                                                                  33 65 36 63 37 66 36 00 00 )                      // 3e6c7f6..
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1C 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 35 2E 32 01   // ,Version=v4.5.2.
                                                                                                        00 54 0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73   // .T..FrameworkDis
                                                                                                        70 6C 61 79 4E 61 6D 65 14 2E 4E 45 54 20 46 72   // playName..NET Fr
                                                                                                        61 6D 65 77 6F 72 6B 20 34 2E 35 2E 32 )          // amework 4.5.2
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module Calculator.exe
// MVID: {74AAA102-91FE-47E6-8122-0CA1E622CC45}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00020003    //  ILONLY 32BITPREFERRED
// Image base: 0x00AB0000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit Calculator.Program
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       130 (0x82)
    .maxstack  2
    .locals init ([0] string operation,
             [1] int32 a,
             [2] int32 b,
             [3] int32 result)
    IL_0000:  call       string [mscorlib]System.Console::ReadLine()
    IL_0005:  stloc.0
    IL_0006:  call       string [mscorlib]System.Console::ReadLine()
    IL_000b:  call       int32 [mscorlib]System.Int32::Parse(string)
    IL_0010:  stloc.1
    IL_0011:  call       string [mscorlib]System.Console::ReadLine()
    IL_0016:  call       int32 [mscorlib]System.Int32::Parse(string)
    IL_001b:  stloc.2
    IL_001c:  ldc.i4.0
    IL_001d:  stloc.3
    IL_001e:  ldloc.0
    IL_001f:  ldstr      "add"
    IL_0024:  callvirt   instance bool [mscorlib]System.String::Equals(string)
    IL_0029:  brfalse.s  IL_0031

    IL_002b:  ldloc.1
    IL_002c:  ldloc.2
    IL_002d:  add
    IL_002e:  stloc.3
    IL_002f:  br.s       IL_007b

    IL_0031:  ldloc.0
    IL_0032:  ldstr      "sub"
    IL_0037:  callvirt   instance bool [mscorlib]System.String::Equals(string)
    IL_003c:  brfalse.s  IL_0044

    IL_003e:  ldloc.1
    IL_003f:  ldloc.2
    IL_0040:  sub
    IL_0041:  stloc.3
    IL_0042:  br.s       IL_007b

    IL_0044:  ldloc.0
    IL_0045:  ldstr      "mul"
    IL_004a:  callvirt   instance bool [mscorlib]System.String::Equals(string)
    IL_004f:  brfalse.s  IL_0057

    IL_0051:  ldloc.1
    IL_0052:  ldloc.2
    IL_0053:  mul
    IL_0054:  stloc.3
    IL_0055:  br.s       IL_007b

    IL_0057:  ldloc.0
    IL_0058:  ldstr      "div"
    IL_005d:  callvirt   instance bool [mscorlib]System.String::Equals(string)
    IL_0062:  brfalse.s  IL_006a

    IL_0064:  ldloc.1
    IL_0065:  ldloc.2
    IL_0066:  div
    IL_0067:  stloc.3
    IL_0068:  br.s       IL_007b

    IL_006a:  ldloc.0
    IL_006b:  ldstr      "mod"
    IL_0070:  callvirt   instance bool [mscorlib]System.String::Equals(string)
    IL_0075:  brfalse.s  IL_007b

    IL_0077:  ldloc.1
    IL_0078:  ldloc.2
    IL_0079:  rem
    IL_007a:  stloc.3
    IL_007b:  ldloc.3
    IL_007c:  call       void [mscorlib]System.Console::WriteLine(int32)
    IL_0081:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method Program::.ctor

} // end of class Calculator.Program


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file temp.res
