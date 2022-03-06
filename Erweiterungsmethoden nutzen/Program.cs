using System;
using System.Diagnostics;
using System.Linq;

namespace Erweiterungsmethoden_nutzen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CONTENT = "Hat der alte Hexenmeister";
            
            //Debugger.Break();

            // Aus...
            int c = CONTENT.CountLetters(true);
            // ..macht der Compiler
            // c = MyFunctionLibrary.CountLetters(CONTENT);

            Console.WriteLine($"Letter true = {CONTENT.CountLetters(true)}");
            Console.WriteLine($"Letter false = {CONTENT.CountLetters(false)}");
            Console.WriteLine($"Letter  = {CONTENT.CountLetters()}");
        }
    }

    public static class MyFunctioLibrary
    {
        public static int CountLetters(this string String, bool DistinctOnly = false)
        {
            // Alle Zeichen ermiiteln
            var query = String.Where(w => char.IsLetter(w));

            // Nur Eindeutige?
            if (DistinctOnly)
                query = query.Distinct();   

            // Anzahl liefern
            return query.Count();

        }
    }
}
