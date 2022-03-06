using System;
using System.Globalization;
using System.Diagnostics;

namespace CultureInfo_praktisch_einsetzen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo currentCI = CultureInfo.CurrentCulture;
            dumpCultureInfo(currentCI);

            CultureInfo deCI = new CultureInfo("en-US");
            dumpCultureInfo(deCI);
        }

        public static void dumpCultureInfo(CultureInfo cultureInfo)
        {
            Console.WriteLine($"{nameof(cultureInfo.Name)}: {cultureInfo.Name}");
            Console.WriteLine($"{nameof(cultureInfo.DisplayName)}: {cultureInfo?.DisplayName}");    

            Console.WriteLine($"{nameof(cultureInfo.DateTimeFormat.ShortDatePattern)}: {cultureInfo.DateTimeFormat.ShortDatePattern}");
            Console.WriteLine($"{nameof(cultureInfo.DateTimeFormat.LongDatePattern)}: {cultureInfo.DateTimeFormat.LongDatePattern}");

            Console.WriteLine($"{nameof(cultureInfo.DateTimeFormat.ShortTimePattern)}: {cultureInfo.DateTimeFormat.ShortTimePattern}");
            Console.WriteLine($"{nameof(cultureInfo.DateTimeFormat.LongTimePattern)}: {cultureInfo.DateTimeFormat.LongDatePattern}");

            Console.WriteLine($"{nameof(cultureInfo.NumberFormat.NumberDecimalSeparator)}: {cultureInfo.NumberFormat.NumberDecimalSeparator}");
            Console.WriteLine($"{nameof(cultureInfo.NumberFormat.CurrencyDecimalSeparator)}: {cultureInfo.NumberFormat.CurrencyDecimalSeparator}");

            Console.WriteLine($"{nameof(cultureInfo.NumberFormat.NumberDecimalDigits)}: {nameof(cultureInfo.NumberFormat.NumberDecimalDigits)}");


        }
    }
}
