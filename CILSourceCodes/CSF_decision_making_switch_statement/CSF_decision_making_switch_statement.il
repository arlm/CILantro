
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.6.1055.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly CSF_DecisionMaking_Switch
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 02 00 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 19 43 53 46 5F 44 65 63 69 73 69 6F 6E 4D   // ...CSF_DecisionM
                                                                                              61 6B 69 6E 67 5F 53 77 69 74 63 68 00 00 )       // aking_Switch..
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 19 43 53 46 5F 44 65 63 69 73 69 6F 6E 4D   // ...CSF_DecisionM
                                                                                                61 6B 69 6E 67 5F 53 77 69 74 63 68 00 00 )       // aking_Switch..
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 12 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                  20 32 30 31 37 00 00 )                            //  2017..
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 63 39 65 35 38 33 39 33 2D 65 30 35 39   // ..$c9e58393-e059
                                                                                                  2D 34 66 64 36 2D 62 36 36 63 2D 36 38 35 38 37   // -4fd6-b66c-68587
                                                                                                  33 34 30 61 35 30 65 00 00 )                      // 340a50e..
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1C 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 35 2E 32 01   // ,Version=v4.5.2.
                                                                                                        00 54 0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73   // .T..FrameworkDis
                                                                                                        70 6C 61 79 4E 61 6D 65 14 2E 4E 45 54 20 46 72   // playName..NET Fr
                                                                                                        61 6D 65 77 6F 72 6B 20 34 2E 35 2E 32 )          // amework 4.5.2
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module CSF_DecisionMaking_Switch.exe
// MVID: {53B72171-4601-4CC3-BCD2-D9EC575EACAA}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00020003    //  ILONLY 32BITPREFERRED
// Image base: 0x00940000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit CSF_DecisionMaking_Switch.Program
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       168 (0xa8)
    .maxstack  1
    .locals init ([0] int32 x)
    IL_0000:  call       string [mscorlib]System.Console::ReadLine()
    IL_0005:  call       int32 [mscorlib]System.Int32::Parse(string)
    IL_000a:  stloc.0
    IL_000b:  ldloc.0
    IL_000c:  switch     ( 
                          IL_003a,
                          IL_0045,
                          IL_0050,
                          IL_005b,
                          IL_0066,
                          IL_0071,
                          IL_007c,
                          IL_0087,
                          IL_0092,
                          IL_009d)
    IL_0039:  ret

    IL_003a:  ldstr      "zero"
    IL_003f:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0044:  ret

    IL_0045:  ldstr      "one"
    IL_004a:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_004f:  ret

    IL_0050:  ldstr      "two"
    IL_0055:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_005a:  ret

    IL_005b:  ldstr      "three"
    IL_0060:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0065:  ret

    IL_0066:  ldstr      "four"
    IL_006b:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0070:  ret

    IL_0071:  ldstr      "five"
    IL_0076:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_007b:  ret

    IL_007c:  ldstr      "six"
    IL_0081:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0086:  ret

    IL_0087:  ldstr      "seven"
    IL_008c:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0091:  ret

    IL_0092:  ldstr      "eight"
    IL_0097:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_009c:  ret

    IL_009d:  ldstr      "nine"
    IL_00a2:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_00a7:  ret
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

} // end of class CSF_DecisionMaking_Switch.Program


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file temp.res
