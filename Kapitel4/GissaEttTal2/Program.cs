using System;

namespace GissaEttTal2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("SPelet- gssa ett tal ");

           while (true)
           {
                //slumpa fram ett tal
            Random tärning = new Random();
            int slumptal = tärning.Next(1,51);
            //loopa 5 gågner
            int räknare = 0;
            while (true)
            {
              //räkna upp varv
              räknare++;

              //   bryt efter 5 varv
              if (räknare > 6)
              {
                  break;
              }
                 Console.Write("Gissa ett tal (1-100)");
            int gissning = int.Parse(Console.ReadLine());

            //är gissningen rätt?
            if (gissning== slumptal)
            {
            Console.WriteLine("Nice");
            Console.WriteLine($"Bra gissat! Du gjorde på {räknare} försök");
            break;
            }
         
            //jamför med slump tal
            if (gissning < slumptal)
            {
             Console.WriteLine("För lågt");
             
            }
            else 
            {
             Console.WriteLine("för högt");
            }
             
              
              int försök = 5;
              int försökkvar = försök - räknare;
              Console.WriteLine($"Du har {försökkvar}");
            } 
           }
        }
    }
}
