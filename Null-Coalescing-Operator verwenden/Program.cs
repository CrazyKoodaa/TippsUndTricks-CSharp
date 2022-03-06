using System;
using System.Diagnostics;

namespace Null_Coalescing_Operator_verwenden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Debugger.Break();

            const string DEFAULTVALUE = "4711";
            string value = null;

            // ??-Operator
            // Standardwert verwenden, wenn der Wert null ist (was wohl der Fall ist)
            string currentValue = value ?? DEFAULTVALUE;
            Console.WriteLine($"{nameof(currentValue)}={currentValue}");

            Console.WriteLine($"{nameof(currentValue)}={value ?? DEFAULTVALUE}");

            // Kompaktere Version:
            // ??=-Operator
            currentValue = null;
            currentValue ??= DEFAULTVALUE;

            Console.WriteLine($"{nameof(currentValue)}= {currentValue ??= DEFAULTVALUE}"); // Achtung Seiteneffekt
        }
    }
}
