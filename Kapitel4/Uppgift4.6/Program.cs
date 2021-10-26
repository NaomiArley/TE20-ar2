using System;

namespace Uppgift4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string meddelande = "Hej på dig";

           

            for (int i =  meddelande.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(meddelande[i]);
            }
        }
    }
}
