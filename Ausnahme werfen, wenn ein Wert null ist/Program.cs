using System;
using System.Diagnostics;

namespace Ausnahme_werfen__wenn_ein_Wert_null_ist
{
    internal class Program
    {
        private static string value;
        static void Main(string[] args)
        {
            Debugger.Break();

            // value = null;
            value = "Hallo";

            // Länge abfragen oder Exception werfen
            int length = (value ?? throw new ArgumentNullException(nameof(value))).Length;
            Console.WriteLine($"{nameof(length)}={length}");

            

        }
    }
}
