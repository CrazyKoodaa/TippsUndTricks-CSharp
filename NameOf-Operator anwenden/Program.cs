using System;
using System.Diagnostics;

namespace NameOf_Operator_anwenden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Debugger.Break();

            int variabel1;

            Console.WriteLine(nameof(Main));
            Console.WriteLine(nameof(variabel1));
            Console.WriteLine(nameof(Program));

            methode(null);
        }

        private static void methode(string parameter)
        {
            if (parameter is null)
                throw new ArgumentNullException(nameof(parameter));
        }
    }
}
