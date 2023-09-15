using System;

namespace Uppgift2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket år är det?");
            int år = int.Parse(Console.ReadLine());
            Console.WriteLine("Det är " + (2100 - år) + " år kvar tills året 2100");
            Console.ReadKey();
        }
    }
}