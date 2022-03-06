using System;
using System.Diagnostics;
using System.Linq;


namespace Richtig_auf_leere_Zeichenkette_prüfen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Debugger.Break();

            // um eine Variable als string zu bezeichnen, dass geht nur mit dem @ davor
            string @string = string.Empty; // => ""

            // Null oder String.Empty
            if (@string is null || @string == string.Empty)
                Console.WriteLine("Null oder String.Empty");

            if (string.IsNullOrEmpty(@string))
                Console.WriteLine("Null oder String.Empty mit IsNullOrEmpty()");

            // Null, String.Empty oder nur Leerzeichen abfrage
            if (@string is null || @string == string.Empty || @string.Where(w => w == ' ').Count() == @string.Length)
                Console.WriteLine("Null, String.Empty oder nur Leerzeichen");

            if (string.IsNullOrWhiteSpace(@string))
                Console.WriteLine("Null, String.Empty oder nur Leerzeichen");



            Console.WriteLine("Hello World!");
        }
    }
}
