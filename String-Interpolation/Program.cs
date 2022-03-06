using System;
using System.Diagnostics;

namespace String_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Debugger.Break();

            Console.WriteLine($"Heute ist: {DateTime.Today:dd.MM.yyyy}");

            string date = $"{DateTime.Now:yyyy-MM-ddTHH\\:mm\\ss.fffffffzzz}";
            Console.WriteLine($"{nameof(date)}={date}");

            long fileSize = 2346273462387;
            Console.WriteLine($"{nameof(fileSize)}={fileSize:N0} bytes");

        }
    }
}
