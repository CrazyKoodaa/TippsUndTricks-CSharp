using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Console_Spielspaß
{
    internal class Program

    {
        private static bool canceled = false;
        private static Random rnd = new Random();
        private static volatile bool _s_stop = false;

        static void Main(string[] args)
        {
            Console.Title = "Dots";


            Console.Clear();
            Console.CursorVisible = false;

            Console.CancelKeyPress += new ConsoleCancelEventHandler(Console_CancelKeyPress);
            while (!_s_stop)
            {
                        Console.Beep();
                for (int x = 0; x < Console.WindowWidth && !canceled; x++)
                {
                    for (int y = 0; y < Console.WindowHeight && !canceled; y++)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.BackgroundColor = (ConsoleColor)rnd.Next(0, 15);
                        Console.ForegroundColor = (ConsoleColor)rnd.Next(0, 15);

                        Console.Write('*');

                        //Task.Delay(10).Wait();


                    }
                }
            }

            Console.ReadKey();
        }
        static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            //you have 2 options here, leave e.Cancel set to false and just handle any
            //graceful shutdown that you can while in here, or set a flag to notify the other
            //thread at the next check that it's to shut down.  I'll do the 2nd option
            e.Cancel = true;
            _s_stop = true;
            Console.WriteLine("CancelKeyPress fired...");
        }
    }
}
