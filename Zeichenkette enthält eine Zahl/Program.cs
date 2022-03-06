using System;
using System.Diagnostics;
using System.Globalization;

namespace Zeichenkette_enthält_eine_Zahl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string STRINGINT = "2342";
            const string STRINGDECIMAL = "23.04";
            const string STRINGDECIMALDE = "1.0099,99";
            const string STRINGNONUMBER = "XXX";


            Console.WriteLine($"STRINGINT.IsInteger({STRINGINT})={STRINGINT.IsInteger()}");
            Console.WriteLine($"STRINGDECIMAL.IsInteger({STRINGDECIMAL})={STRINGDECIMAL.IsInteger()}");
            Console.WriteLine($"STRINGDECIMAL.IsInteger({STRINGNONUMBER})={STRINGNONUMBER.IsInteger()}");
    
            Console.WriteLine($"STRINGINT.IsDecimal({STRINGINT})={STRINGINT.IsDecimal()}");
            Console.WriteLine($"STRINGDECIMAL.IsDecimal({STRINGDECIMAL})={STRINGDECIMAL.IsDecimal()}");
            Console.WriteLine($"STRINGDECIMAL.IsDecimal({STRINGNONUMBER})={STRINGNONUMBER.IsDecimal()}");

            Console.WriteLine($"STRINGDECIMALDE.IsDecimal({STRINGDECIMALDE})={STRINGDECIMALDE.IsDecimal()}");
            Console.WriteLine($"STRINGDECIMALDE.IsDecimal({STRINGDECIMALDE}, \"de-DE\")={STRINGDECIMALDE.IsDecimal()}");
            Console.WriteLine($"STRINGDECIMALDE.IsDecimal({STRINGDECIMALDE}, \"en-US\")={STRINGDECIMALDE.IsDecimal()}");



        }


    }

    public static class MyFunctionLibrary
    {
        public static bool IsDecimal(this string String, string Culture = "de-DE")
        {
            return decimal.TryParse(String, NumberStyles.Any, new CultureInfo(Culture), out decimal o);
        }
        public static bool IsInteger(this string String, string Culture = "de-DE")
        {
            return int.TryParse(String, NumberStyles.Any, new CultureInfo(Culture), out int o);
        }
    }
}
