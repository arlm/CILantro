
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.6.1055.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly CSF_DecisionMaking_IfElseIfElse
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 02 00 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 1F 43 53 46 5F 44 65 63 69 73 69 6F 6E 4D   // ...CSF_DecisionM
                                                                                              61 6B 69 6E 67 5F 49 66 45 6C 73 65 49 66 45 6C   // aking_IfElseIfEl
                                                                                              73 65 00 00 )                                     // se..
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 1F 43 53 46 5F 44 65 63 69 73 69 6F 6E 4D   // ...CSF_DecisionM
                                                                                                61 6B 69 6E 67 5F 49 66 45 6C 73 65 49 66 45 6C   // aking_IfElseIfEl
                                                                                                73 65 00 00 )                                     // se..
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 12 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                  20 32 30 31 37 00 00 )                            //  2017..
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 34 66 61 35 37 31 30 31 2D 31 31 37 30   // ..$4fa57101-1170
                                                                                                  2D 34 33 37 30 2D 39 63 37 63 2D 64 36 34 66 31   // -4370-9c7c-d64f1
                                                                                                  61 62 31 30 66 37 36 00 00 )                      // ab10f76..
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1C 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 35 2E 32 01   // ,Version=v4.5.2.
                                                                                                        00 54 0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73   // .T..FrameworkDis
                                                                                                        70 6C 61 79 4E 61 6D 65 14 2E 4E 45 54 20 46 72   // playName..NET Fr
                                                                                                        61 6D 65 77 6F 72 6B 20 34 2E 35 2E 32 )          // amework 4.5.2
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module CSF_DecisionMaking_IfElseIfElse.exe
// MVID: {9C9098D0-6AF8-4875-B52A-2221EC7CAAC1}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00020003    //  ILONLY 32BITPREFERRED
// Image base: 0x00FC0000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit CSF_DecisionMaking_IfElseIfElse.Program
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       51 (0x33)
    .maxstack  2
    .locals init ([0] int32 x)
    IL_0000:  call       string [mscorlib]System.Console::ReadLine()
    IL_0005:  call       int32 [mscorlib]System.Int32::Parse(string)
    IL_000a:  stloc.0
    IL_000b:  ldloc.0
    IL_000c:  ldc.i4.0
    IL_000d:  ble.s      IL_001a

    IL_000f:  ldstr      "positive"
    IL_0014:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0019:  ret

    IL_001a:  ldloc.0
    IL_001b:  brtrue.s   IL_0028

    IL_001d:  ldstr      "zero"
    IL_0022:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0027:  ret

    IL_0028:  ldstr      "negative"
    IL_002d:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0032:  ret
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

} // end of class CSF_DecisionMaking_IfElseIfElse.Program


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file temp.res
