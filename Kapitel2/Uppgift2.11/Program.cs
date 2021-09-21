using System;

namespace Uppgift2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Detta program beräknar konstanen för att hyra en bil");

            int startavgift = 300;
            Console.Write("hur många dagar vill du hyra ");
            int Dagar =  int.Parse(Console.ReadLine());
            
            Console.Write("Hur många km tänker du köra ");
            int km = int.Parse(Console.ReadLine());
        

            int totalHyra = startavgift + (Dagar - 1) * 500 + km;
            Console.WriteLine($"Priset för att hyra bilen blir {totalHyra}");

        }
    }
}
