using System;

namespace Uppgift4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //skriv din summa tex 537
            Console.WriteLine("skriv din summa");
            string summaText = Console.ReadLine();
            
            int summa= 0;
            // Loopa igenom summaText
            for (int i = 0; i < summaText.Length; i++)
            {
                char siffra = summaText[i];
                Console.WriteLine(siffra);

                //omvandla char till int
                int siffraTal = int.Parse(siffra.ToString());

                summa += siffraTal;
            }
                Console.WriteLine($"Siffersumman av {summaText} är {summa}");



        }
    }
}
