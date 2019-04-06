using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;

namespace SalviniQuotes
{
    class Program
    {

        static async System.Threading.Tasks.Task Main(string[] args)
        {


            Console.WriteLine($"Hello Matteo, I'm just a poor  {Environment.NewLine}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Select  {Environment.NewLine}");
            Console.WriteLine($"black man / gay / communist  {Environment.NewLine}");
            Console.ForegroundColor = ConsoleColor.White;

            var tipo = Console.ReadLine();

            Console.WriteLine($"What 'm asking is   {Environment.NewLine}");
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine($"Select  {Environment.NewLine}");
            Console.WriteLine($"a job/ more rights / less racism  {Environment.NewLine}");
            Console.ForegroundColor = ConsoleColor.White;

            var ciòchechiedo = Console.ReadLine();




            Thread.Sleep(1000);

            Console.WriteLine($" Fuck you man, fuck you, you know what? { Environment.NewLine}");


            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("what?");

            Thread.Sleep(6000);


            await new FuckNiger(tipo, ciòchechiedo).WhoAreYou();




        }
    }
}
