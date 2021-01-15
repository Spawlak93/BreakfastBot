using BreakfastBot.BreakfastStuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakfastBot
{
    class BreakfastRobo
    {
        public Eggs CookEggs()
        {
            Console.WriteLine("Cracking Eggs", Console.ForegroundColor = ConsoleColor.Yellow);
            Task.Delay(5000).Wait();
            Console.WriteLine("Eggs are done", Console.ForegroundColor = ConsoleColor.Yellow);

            Console.ResetColor();
            return new Eggs();
        }

        public Eggs Toasttoast()
        {
            Console.WriteLine("Putting Toast in the toaster", Console.ForegroundColor = ConsoleColor.Cyan);
            Task.Delay(3000).Wait();
            Console.WriteLine("ToastPops", Console.ForegroundColor = ConsoleColor.Cyan);
            Console.ResetColor();
            return new Eggs();
        }

        public Eggs CookHashBrowns()
        {
            Console.WriteLine("Cooking Hashbrowns", Console.ForegroundColor = ConsoleColor.Blue);
            Task.Delay(3500).Wait();
            Console.WriteLine("Hashbrowns done", Console.ForegroundColor = ConsoleColor.Blue);

            Console.ResetColor();
            return new Eggs();
        }
    }
}
