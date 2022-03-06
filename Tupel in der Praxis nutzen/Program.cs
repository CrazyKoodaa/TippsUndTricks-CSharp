using System;
using System.Diagnostics;

namespace Tupel_in_der_Praxis_nutzen
{
    internal class Program
    {
        // Nuget Packet System.ValueTuple wird benötigt.
        // Integraler Bestandteil von .NET Core

        static void Main(string[] args)
        {
            Debugger.Break();

            // Man kann entweder var verwenden um den Compiler selbst zu entscheiden was er daraus machen soll
            var position1 = GetPosition();

            // oder man gibt in den Runden () bescheid, dass es 2 int sein soll
            (int p1, int p2) position2 = GetPosition();

            Console.WriteLine($"{nameof(position1.x)}={position1.x}");
            Console.WriteLine($"{nameof(position1.y)}={position1.y}");

            // Auch prinzipiell als OParameter, Eigenschaften, etc. geeignet.
            // Ob das allerdings die Lesbareit erhöht?

            var distance = Distance(position1, position2);
            Console.WriteLine($"{nameof(distance.x)}={distance.x}");
            Console.WriteLine($"{nameof(distance.y)}={distance.y}");


        }

        public static (int x, int y) GetPosition()
        {
            Random rnd = new Random();

            // Rückgabe erstellen
            // man muss wie beim aufrufen die () beachten und dann kann man mit x: oder mit y: die Werte zuweisen
            (int x, int y) result = (x: rnd.Next(1,100), y: rnd.Next(1,100));
            return result;
        }

        public static (int x, int y) Distance((int x, int y) pos1, (int x, int y) pos2)
        {
            // Berechnung durchführen
            (int x, int y) result = (x: pos1.x - pos2.x, y: pos1.y - pos2.y);

            return result;
        }
    }
}
