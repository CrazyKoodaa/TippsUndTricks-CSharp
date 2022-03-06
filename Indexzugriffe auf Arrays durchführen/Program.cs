using System;
using System.Diagnostics;

namespace Indexzugriffe_auf_Arrays_durchführen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Debugger.Break();

            string[] stringArray = "Hat der alte Hexenmeister sich doch einmal wegbeben!".Split(' ');

            // Indices
            string firstWord = stringArray[0]; //From begin
            string lastWord = stringArray[^1]; // From end
            Console.WriteLine($"firstWord={firstWord}, lastWord={lastWord}");

            // Ranges
            string[] allWords = stringArray[..]; // Alle Elemente
            Console.WriteLine($"allWords={string.Join(',', allWords)}");   

            string[] firstWords = stringArray[..4]; // Die erste (<=) 4 Elemente (0 bis 4)
            Console.WriteLine($"firstWords={string.Join(',', firstWords)}");

            string[] lastWords = stringArray[5..]; // (=>) 5 Elemente bis zum Ende
            Console.WriteLine($"lastWords={string.Join(',', lastWords)}");


            // Vars
            int i = 5;
            int j = 1;

            string index = stringArray[^j];
            string[] range = stringArray[..i];
            Console.WriteLine($"index={index}, range={string.Join(',', range)}");

            string[] range2 = stringArray[j..i];
            Console.WriteLine($"range2={string.Join(',', range2)}");




        }
    }
}
