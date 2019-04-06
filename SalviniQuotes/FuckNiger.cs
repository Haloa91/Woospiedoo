using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SalviniQuotes
{
    public class FuckNiger
    {
        public string _tipo { get; set; }
        public string _ciòchechiedo { get; set; }

        public FuckNiger(string tipo, string ciòchechiedo)
        {
            _tipo = tipo;
            _ciòchechiedo = ciòchechiedo;
        }

        public async Task<bool> WhoAreYou()
        {
            List<Thread> listone = new List<Thread>();
            for (int i = 0; i < 180; i++)
            {
                Thread thread1 = new Thread(WhoAreYou);
                thread1.Start();

            }

            return true;
        }

        private void WhoAreYou(object obj)
        {
            Console.WriteLine($"hey, fucking {this._tipo} you will never have { this._ciòchechiedo}");

            Thread.Sleep(10000);


            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                if (i % 5 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                }
                if (i % 6 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                }
                if (i % 9 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                }
            }
        }
    }
}
