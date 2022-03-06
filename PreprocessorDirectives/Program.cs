// Man kann hier bereits eine Directive erstellen
// Je nachdem ob man die nächste Zeile kommentiert oder nicht, sieht man im VS 2022, dass entweder das eine Ausgeführt wird oder das andere (das bunte wird ausgeführt)
#define SPECIAL

using System;



namespace PreprocessorDirectives
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

#pragma warning disable CS0168 // Variable is declared but never used
            int i;
#pragma warning restore CS0168 // Variable is declared but never used

#if SPECIAL
            Console.WriteLine("Ist Spezial");
#else
            Console.WriteLine("Kein SPECIAL");
#endif

#if DEBUG
            Console.WriteLine("DEBUG Modus an");
#endif

            // Zeile vor dem Debugger verstecken:
            Console.WriteLine("WriteLine #1");
#line hidden
            Console.WriteLine("WriteLine #2");
#line default
            Console.WriteLine("WriteLine #3");

#error Refactoring angebracht!!!

#warning Man sollte Refactoren


        }
    }
}
