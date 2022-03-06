using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Null_Conditional_Operator_nutzen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Debugger.Break();

            ClassA instance1 = new ClassA();
            ClassA instance2 = new ClassA()
            {
                SingleB = new ClassB(),
                MultipleB = new ClassB[]
                {
                    new ClassB(), new ClassB(), new ClassB()

                }
            };

            Console.WriteLine("- instance1");
            dump(instance1);

            Console.WriteLine("- instance2");
            dump(instance2);

            void dump(ClassA classA)
            {
                // Ausgabe nur, wenn Instanz nicht classA nicht null ist "?." und SingleB nicht null ist
                Console.WriteLine($"Content: {classA?.SingleB?.Content}");

                for (int i = 0; i < classA?.MultipleB?.Length; i++)
                {
                    // Ausgabe nur, wenn Instanz nicht null
                    Console.WriteLine($"Content[{i}]: {classA.MultipleB[i].Content}");
                }
            }
        }
    }

    public class ClassA
    {
        public ClassB SingleB { get; set; }
        public ClassB[] MultipleB { get; set; }

    }

    public class ClassB
    {
        public ClassB()
        {
            Content = DateTime.Now.Ticks.ToString();
            Task.Delay(10).Wait();
        }

        public string Content { get; set; }
    }
}
