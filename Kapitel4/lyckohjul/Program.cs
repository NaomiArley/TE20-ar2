using System;

namespace lyckohjul
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lyckohjul progrm");

            // Skapa ett program som ska fungera som ett lyckohjul
            Random generator = new Random();
            int lyckohjul = generator.Next(1,11);
            for (int i = 3; i > 0; i--)
            {
                
            
            
                
            Console.Write("Gissa vilket tal lyckohjulet kommer stanna på (1-10)  ");
            int gissning = int.Parse(Console.ReadLine());
            

            // Slumpa därefter fram ett tal från 1 till 10 och säg till användaren vilket tal det blev

            // Berätta också för användaren om hen vann eller förlorade
            if (gissning == lyckohjul)
            {
                Console.WriteLine("Grattis du vann");
                break;
            }
            else
            {
                Console.WriteLine($"Testa igen du har {i} försök");
            }
            }
            Console.WriteLine($"Hjulet stannade på {lyckohjul}   ");
            // När användaren kör programmet får hen välja ett tal från 1 till 10 som hen tror att lyckohjulet kommer att stanna på
            // Användaren får 3 försök!
          

        }
    }
}
