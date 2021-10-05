 using System;

namespace GissaEttTal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("SPel- Gissa ett tal mellan 1 och 100");
        
            //Spela flera gånger
            while (true)
            {
            //slumpa fram ett tal
             Random tärning = new Random(); 
            int slumptal = tärning.Next(1,101);
        
             //Upprepa frågan
             int räknare = 0;
            while (true)
            {
            //antal gissningar
            räknare ++ ;

            Console.Write("Gissa ett tal (1-100)");
            int gissning = int.Parse(Console.ReadLine());

            //är gissningen rätt?
            if (gissning== slumptal)
            {
            Console.WriteLine("Nice");
            Console.WriteLine($"Bra gissat! Du gjorde på {räknare} försök");
            break;60
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
            }
            }
         
       
        
            
            
    }    
}}
