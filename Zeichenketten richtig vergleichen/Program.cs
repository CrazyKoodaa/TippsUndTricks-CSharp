using System;
using System.Diagnostics;

namespace Zeichenketten_richtig_vergleichen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Debugger.Break();

            const string ACTIONKEY = "ADD";
            string action = "add";

            if (ACTIONKEY == action)
                Console.WriteLine("ACTIONKEY == action");

            // Möglich, aber nicht optimal. ToUpper erstellt neue Variable und kostet resourcen
            if (ACTIONKEY == action?.ToUpper())
                Console.WriteLine("ACTIONKEY == action?.ToUpper()");

            // Am besten dieses hier verwenden: true => Ignore Groß/Klein und gibt ein 0 raus, wenn es gleich ist. Vorteil kein neuer String wird erstellt
            if (string.Compare(ACTIONKEY, action, true) == 0)
                Console.WriteLine("string.Compare(ACTIONKEY, action, true) == 0");

            
        }
    }
}
