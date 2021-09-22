using System;

namespace Villkor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du");

            int ålder= int.Parse(Console.ReadLine());
        
            if (ålder >= 18)
            {
                Console.WriteLine("Du får skaffa körkort");
            }
            else
            {
             Console.WriteLine("Du är för ung för att skaffa körkort");   
            }
            
        }
    }
}
