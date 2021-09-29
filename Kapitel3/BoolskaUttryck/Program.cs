using System;

namespace BoolskaUttryck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coronasymptom");
          

            Console.WriteLine("Har du feber? (j/n)");
            string feber = Console.ReadLine();

            Console.WriteLine("Hostar du? (j/n)");
            string hosta = Console.ReadLine();

            Console.WriteLine("Har du tappat smaken? (j/n)");
            string smak = Console.ReadLine();
            
            Console.WriteLine("Är du vaccinerad? (j/n)");
            string vaccin = Console.ReadLine();

/*             if (feber== "j" && hosta == "j" && smak == "j")
            {
                Console.WriteLine("Du har troligen Covid-19");
            }
            else if (hosta == "j" && smak == "j")
            {
                Console.WriteLine("Du har trolgen covid-19");
            }
            else if (feber == "j" && smak == "j")
            {
                Console.WriteLine("Du har trolgen covid-19");
            } */
             if (feber == "j" || hosta == "j" && smak == "j")
            {
                Console.WriteLine("du har covid");
            }
        }
    }
}
