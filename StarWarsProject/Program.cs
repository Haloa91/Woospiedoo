using System;

namespace StarWarsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string protagonist = Console.ReadLine();
            Console.Write(new CallerBrexit().Call(protagonist));
            Console.Read();
        }
    }
}
