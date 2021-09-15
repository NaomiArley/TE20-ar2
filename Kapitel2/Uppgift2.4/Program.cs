using System;

namespace Uppgift2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ange ett tal");
            double talEtt = double.Parse(Console.ReadLine());
            Console.WriteLine("ange ett annat tal");
            double talTvå = double.Parse(Console.ReadLine());

            double summa = talEtt + talTvå;
            double produkt = talEtt * talTvå;
            Console.WriteLine("Summan av talen är " + summa);
            Console.WriteLine("Produkten av talen är " + produkt);
            


        }
    }
}
