using System;

namespace Resource_mit_using_Declarations_freigeben
{
    internal class Program
    {
        const string FILENAME = "Content.txt";

        static void Main(string[] args)
        {
            Debugger.Break();

            // Ohne using-Block
            // read();

            // mit using-Block
            // readUsingDeclaration();



        }

        private static void read()
        {
            char[] result;
            StreamReader reader = File.OpenText(FILENAME);
            result = new char[reader.BaseStream.Length];
            reader.Read(result, 0, (int)reader.BaseStream.Length);

            // Länge ausgeben
            Console.WriteLine($"{nameof(result.Length)} = {result.Length:N0}");

            //Datei verändern, hier als Beispiel löschen
            File.Delete(FILENAME);

            // Problem hierbei ist, dass die Datei geöffnet worden ist, aber nirgendswo geschlossen um dann die Datei zu löschen. Deswegen kommt hier eine System.IO.IOException
        }

        private static void readUsingDeclaration()
        {
            char[] result;

            if (true)
            {
                using (StreamReader reader = File.OpenText(FILENAME))
                result = new char[reader.BaseStream.Length];
                reader.Read(result, 0, (int)reader.BaseStream.Length);

                // externe Ressource so schnell wie möglich wieder freigeben, welches durch die beiden {} im if fertig ist, um andere Zugriff zulassen zu können
            }

            // Länge ausgeben
            Console.WriteLine($"{nameof(result.Length)} = {result.Length:N0}");

            //Datei verändern, hier als Beispiel löschen. Jetzt klappt es, weil die using Block fertig ist und somit die Resource geschlossen wird.
            File.Delete(FILENAME);
        }
    }
}
