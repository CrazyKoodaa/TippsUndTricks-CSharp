using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace Switch_Anweisung_mit_Typen_erstellen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Debugger.Break();

            //Werte Liste erzeugen
            IEnumerable<object> values = new List<object>()
            {
                "1", 2, 3, 4.0m,
                new List<object>()
                {
                    "5", 6, 7.0m
                }
            };

            // Aufsummieren
            int result = SumUp(values);
            Console.WriteLine($"{nameof(result)}? {result:N0}");

        }

        private static int SumUp(IEnumerable<object> values)
        {
            int sum = 0;

            foreach (object value in values)
            {
                switch (value)
                {
                    case null:
                    case 0: //Kein Wert oder 0
                        break;
                    case int i: // integer
                        sum += i;
                        break;
                    case IEnumerable<object> list when list.Any(): //Liste mit Inhalt
                        sum += SumUp(list);
                        break;
                    case IEnumerable<object> _: //Liste ohne Inhalt
                        break;
                    case decimal d when d != 0.0m: // Decimal ungleich 0.0
                        sum += (int)d;
                        break;
                    case string s when int.TryParse(s, out int parsed): //Integer als String
                        sum += parsed;
                        break;

                }
            }


            return sum;

        }
    }
}
