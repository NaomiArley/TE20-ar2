using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Räkna 1 till 10");

            // for (int i =1; i <11; i++ )   
            // {
            //     Console.WriteLine($"Loop nr {i}");    
            // }
            
            while (true)
            {
            //läs in ett meddelnade
            Console.WriteLine("Skriv ett mddelande");
            string meddelande = Console.ReadLine();
            
            //loopa igenom meddelandet
            for (int i = 0; i < meddelande.Length; i++)
            {
                Console.WriteLine(meddelande[i]);
            Console.WriteLine("________________________");
           
            Console.WriteLine(" vill du avbryta");
            string svar  = Console.ReadLine();
            ;
            if (svar == "ja")
            {
                break;
            }

            }

            }
        }
    }
}
