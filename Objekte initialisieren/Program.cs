using System;
using System.Diagnostics;

namespace Objekte_initialisieren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Debugger.Break();

            #region Vereinfachung bietet auch Visual Studio 2022 an
            List<string> names;
            names = new List<string>();
            names.Add("Hugo");
            names.Add("Anton");

            // Das würde VS daraus machen:
            //List<string> names;
            //names = new List<string>
            //{
            //    "Hugo",
            //    "Anton"
            //};
            #endregion

            // Aber Achtung!!!
            ClassA instance;

            try
            {
                instance = new ClassA();
                instance.Name = "Kansy"; //Könnte eine Ausnahme auslösen
                instance.Code = 711; // Oder hier

                // VS würde das hier vereinfachen wollen
                //intance = new ClassA
                //{
                //    Name = "Kansy",
                //    Code = 4711
                //};

                // Problem ist aber, dass der vereinfachte Bereich eine einzelne Anweisung ist und wenn es irgendwo bei den Wertzuweisung einen Fehler gibt, 
                // dann wird die Instance null sein. Bei der nicht vereinfachung, ist instance ein Objekt und die Fehlermeldung zeigt dann den richtigen Fehler an
                // Die Frage ist, ob man mit einer Teil initialisierten Klasse weiter arbeiten kann oder nicht
            }
            catch
            {
                // ...
            }

            // Welche Werte hat classA2

        }

        public class ClassA
        {

        }
    }
}
