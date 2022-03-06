using System;
using System.Diagnostics;

namespace Richtig_auf_Null_prüfen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Debugger.Break();
            ClassA instance = new ClassA();

            // == Operator
            // Problem mit einem == Operator ist, dass es überschrieben werden kann und dann unter umständen fehlerhaften Code ausführt und dadurch langsamer ist
            if (instance == null)
                Console.WriteLine($"{nameof(instance)} == null");
            else
                Console.WriteLine($"not {nameof(instance)} == null");

            // is Operator
            // kann angeblich nicht Überschrieben werden und daher sicherer, dass es "is null" ist
            if (instance is null)
                Console.WriteLine($"{nameof(instance)} is null");
            else
                Console.WriteLine($"not {nameof(instance)} is null");

        
        
        }

    }

    public class ClassA
    {
        public static bool operator ==(ClassA obj1, ClassA obj2)
        {
            return true;
        }

        public static bool operator !=(ClassA obj1, ClassA obj2)
        {
            return true;
        }

        public override bool Equals(object obj)
        {
            return true;
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}
