using System;

/*

.class private abstract auto ansi sealed beforefieldinit App
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Foo(int32 nr) cil managed
  {
App01.il
    //loads the argument at index 0 onto the evaluation stack
    IL_0000:  ldarg.0
    //calls the method indicated by the passed method descriptor
    IL_0001:  call       void [mscorlib]System.Console::Write(int32)
    //pushes a new object reference to a string literal stored in the metadata
    IL_0006:  ldstr      ", "
    IL_000b:  call       void [mscorlib]System.Console::Write(string)
    IL_0010:  ldarg.0
    //pushes the integer value of 1 onto the evaluation stack as an int32
    IL_0011:  ldc.i4.1
    //transfers control to a target instruction when two insigned integer values or unordered float values 
    //are not equal
    IL_0012:  bne.un.s   IL_001a
    IL_0014:  call       void [mscorlib]System.Console::WriteLine()
    IL_0019:  ret
    IL_001a:  ldarg.0
    IL_001b:  ldc.i4.2
    //divides two values and pushes the remainder onto the evaluation stack
    IL_001c:  rem
    //transfers control to a target instruction if value is true, not null, or non-zero
    IL_001d:  brtrue.s   IL_0028
    IL_001f:  ldarg.0
    IL_0020:  ldc.i4.2
    //divides two values and pushes the result as a floating-point (type F) or quotient (type int32) 
    //onto the evaluation stack 
    IL_0021:  div
    IL_0022:  call       void App::Foo(int32)
    IL_0027:  ret

    IL_0028:  ldarg.0
    IL_0029:  ldc.i4.3
    IL_002a:  mul
    IL_002b:  ldc.i4.1
    IL_002c:  add
    IL_002d:  call       void App::Foo(int32)
    IL_0032:  ret
*/

namespace TPC_07___AULA_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        
        public void Foo(int nr) 
        {
            Console.WriteLine(nr);
            Console.WriteLine(", ");
            if(nr == 1)
            {
                Console.WriteLine();
                return;
            }
            //int remainder = x % 1;
            if(!(nr % 1 > 0))
            {
                Foo(nr / 2);
                return;
            }
            Foo(nr * 3 + 1);
            return;
        }
    }
}
