using System;

namespace Uppgift3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());
            if (ålder >= 50 )
            {
                Console.WriteLine("Du får vara med i  seniormästerskapen på golfklubben");
            }
            else
            {
                Console.WriteLine("Du måste vara minst 50 år för att vara med i seniormästerskapan");
            }
            
        }
    }
}
