using System;
using System.Diagnostics;

namespace Getter_und_Setter_mit_unterschiedlichen_Rechten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var instanceA = new ClassA("Thorsten Kansy", 4711);

            string name = instanceA.Name;
            //instanceA.Name = "Hallo";

            // Ab C# 9.0
            var instanceB = new ClassB()
            {
                Name = "Thorsten Kansy",
                Code = 4711

            };


        }

        public class ClassA
        {
            // mit dem private set, kann man nur innerhalb der Klasse die Variable beschreiben. Jedoch nicht außerhalb
            public string Name { get; private set; }
            public int Code { get; private set; }
            public ClassA(string Name, int Code)
            {
                this.Name = Name;
                this.Code = Code;
            }


        }

        // Ab C# 9.0
        public class ClassB
        {
            public string Name { get; init; }
            public int Code { get; init; }
        }

    }
}
