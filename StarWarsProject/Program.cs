using System;

namespace StarWarsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insert a small number");
            string protagonist = Console.ReadLine();
            Console.Write( "Brexit will be defeated by " + new CallerBrexit().Call(protagonist));
            Console.Read();
        }
    }
}
