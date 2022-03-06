using System;
using System.Diagnostics;

namespace Mehrfachzuweisung_vornehmen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Debugger.Break();

            // Passender Type, mehrfache Zuweisung möglich
            int x, y, z;

#pragma warning disable IDE0059 // Unnecessary assignment of a value
            x = y = z = 0;
#pragma warning restore IDE0059 // Unnecessary assignment of a value

            // dashier geht nicht
            //string s;
            //ClassA c;

            //s = c = null;

        }
    }
}
