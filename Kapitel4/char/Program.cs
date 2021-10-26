using System;

namespace Char
{
    class Program
    {
        static void Main(string[] args)
        {
            string meddelande = "Hej på dig!";

            //skrib ut hela string
            Console.WriteLine(meddelande);

            //skriv ut första bokstaven
            Console.WriteLine(meddelande[0]);

            //skriv ut sista bokstaven
            Console.WriteLine(meddelande[10]);

            char bokstav = 'Z';
            //skkriv ut alla tecken
            for (int i = 0; i <11 ; i++)
            {
                Console.WriteLine($"index {i} {meddelande[i]}");
            }
        }
    }
}
