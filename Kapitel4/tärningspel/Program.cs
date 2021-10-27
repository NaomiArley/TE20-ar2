using System;

namespace tärningspel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa ett program som ska fungera som en tärningssimulator
            Console.WriteLine("Detta ska vara ett tärningspel");

            // När användaren startar programmet ska hen få säga hur många tärningar hen vill kasta och hur många sidor varje tärning ska ha
            Console.Write("Hur många tärningar vill du kasta?  ");
            int tärningskast = int.Parse(Console.ReadLine());
            Console.Write("Hur många sidor ska tärningen ha?  ");
            int tärningsidor = int.Parse(Console.ReadLine());

            
            // Simulera därefter det antal tärningskast som användaren vill göra med det antal sidor som användaren valde
            for (int i = tärningskast; i > 0; i--)
            {
                Random generator = new Random();
                int tärning = generator.Next(1,tärningsidor+1);
            // Skriv ut värdet av varje tärningskast
            Console.WriteLine($"Värdet av tärningen var {tärning} ");
            }
        }
    }
}
