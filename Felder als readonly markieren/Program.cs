using System;

namespace Felder_als_readonly_markieren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myInstance = new ClassA("Thorsten Kansy", 4711);

            string name = myInstance.Name;
            // Die nächste Zeile geht nicht, da die Variabeln readonly sind
            // myInstance.Name = name;
        }
    }
    public class ClassA
    {
        public readonly string Name;
        public readonly int Code;

        public ClassA(string Name, int Code)
        {
            this.Name = Name;
            this.Code = Code;   
        }

    }
}
