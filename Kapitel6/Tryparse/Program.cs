using System;

namespace Tryparse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gissa ett tal");

            //slumpgenerator
            Random generator = new Random();
            //slumpa fram ett tal
            int slumptal = generator.Next(1,101);
            int slumptal2 = generator.Next(1,11);

            //Be spelaren att gissa ett tal
            Console.Write("Gissa ett tal mellan 1-100  ");
           string gissning = Console.ReadLine();
           

            //försök översättta det inmatade till ett tal
            int gissningTal = 0;
            bool korrekt  = false;

            //loopa för att tving spelaaren att mata rätt 
            while (korrekt != true)
            {
                 Console.Write("Du måste mata in ett tal(1-100)  ");
                  gissning = Console.ReadLine();
                 korrekt = int.TryParse(gissning, out gissningTal);
            }
            
            //var gissning korrekt
            if (gissningTal == slumptal)
            {
                Console.WriteLine("rätt");
            }
            else{
                Console.WriteLine("fel");
            }
        }
    }
}
