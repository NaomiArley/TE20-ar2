using System;

namespace split
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange en mening");
            string mening = Console.ReadLine();
            
            //dela upp för att hitta ala ord
            string[] orden = mening.Split(' ');
            
            //skriv ut alla ord på var sin rad
            foreach (var ord in orden)
            {
                Console.WriteLine(ord);
            }
            //hur mpnga ord finns det i arrayen
            Console.WriteLine($"Antaal ord i meningen är {orden.Length}");
            //ätt samman mening
            string nyMening = string.Join('/', orden);

            Console.WriteLine(nyMening);
        }

    }
}
