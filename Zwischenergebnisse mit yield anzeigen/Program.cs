using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Zwischenergebnisse_mit_yield_anzeigen
{
    internal class Program
    {
        public async static Task Main(string[] args)
        {
            //Debugger.Break();
            
            // Ab C# 8.0 auch asynchron möglich
            await foreach (int number in GenerateSequenceAsync())
                Console.WriteLine($"Asynchron: {number}");

            // Sequenz durchlaufen
            foreach (int number in GenerateSequence())
                Console.WriteLine($"Synchron: {number}");

        }

        public static IEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 20; i++)
            {
                // Zwischenergebnisse liefern
                yield return i;
            }
        }

        public static async IAsyncEnumerable<int> GenerateSequenceAsync()
        {
            for (int i = 0; i < 20; i++)
            {
                //Zwischenergebnisse liefern
                await Task.Delay(100);
                yield return i;
            }
        }
    }
}