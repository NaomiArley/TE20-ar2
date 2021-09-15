using System;

namespace UppgiftLucktext
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Detta är ett program där du skriver ett text");
            Console.Write("namnge din karaktär - ");
            string karaktär = Console.ReadLine();
            

            Console.Write($"Skriv {karaktär}s ålder - ");
            string ålder = Console.ReadLine();
            
            Console.Write($"Skriv vad {karaktär}s husdjur heter - ");
            string husdjur = Console.ReadLine();
            
            Console.WriteLine($"Idag var {karaktär}s födelsedag, {karaktär} fyllde {ålder} år. {karaktär} hade aldrig haft ett husdjur så mamma köpte en kattunge. {karaktär} bestämde sig för att nämna katten till {husdjur} ");
           
        }
    }
}
