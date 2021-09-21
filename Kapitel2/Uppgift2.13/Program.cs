using System;

namespace Uppgift2._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Du ska få veta medelönen för 3 anställda på ett företag");

            //samla in värde på lön variablerna
            Console.Write("Ange lönen på den första person--> ");
            int lön1 = int.Parse(Console.ReadLine());
            Console.Write("Ange lönen på den andra person--> ");
            int lön2 = int.Parse(Console.ReadLine());
            Console.Write("Ange lönen på den tredje person--> ");
            int lön3 = int.Parse(Console.ReadLine());

            //räkna ut medelvärdet
            double medelvärde = ((lön1 + lön2 + lön3)/3);
            Console.WriteLine($"MedelLönen på de anställda är {medelvärde} ");

        }
    }
}
