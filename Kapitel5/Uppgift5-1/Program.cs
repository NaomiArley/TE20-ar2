using System;

namespace Uppgift5_1
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Svenska städer");

            string[] stad = new string[3];

            stad[0] = "Stockholm";
            stad[1] = "Uppsala";
            Console.WriteLine($"Skriv in namnet på en svenska stad förutom {stad[0]} och {stad[1]}");
            //byt innehååll
            stad[2] = Console.ReadLine();
            

            Console.WriteLine($"Tre svenska städer = {stad[0]},{stad[1]} och {stad[2]}");

            string[] länder = {"Sverige", "Finland", "Norge", "Danmark"};

            //krib ut alla länder
            foreach (var land in länder)
            {
                Console.WriteLine(land);
            }

        }
    }
}

        