using System;
using System.Diagnostics;

namespace Null_Forgiving_Operator_einsetzen
{
    // Null-Prüfung des Compilers einschalten. Dies kann auch über die Projekt-Datei geschehen.
    // Um das zu zeigen, befindet sich in der csproj-Datei dieses Projektes ein eintsprechender Kommentar
#nullable enable
    internal class Program
    {
        static void Main(string[] args)
        {
            Debugger.Break();

            string value = null;

            // Hier wird zwingend eine Ausnahme geworfen, so das der folgende Code nicht weiter analysiert wird.
            int length1 = value.Length;
            Console.WriteLine($"length1={length1}");

            if (isValid(value))
            {
                int length2 = value!.Length;
                Console.WriteLine($"length2={length2}");

            }
            bool isValid(string stringValue)
            {
                return !string.IsNullOrWhiteSpace(stringValue);
            }
        }
    }
}
