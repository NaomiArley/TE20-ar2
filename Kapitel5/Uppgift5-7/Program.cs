using System;

namespace Uppgift5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa ett program som innehåller en array med minst 5 heltal. Beräkna summan av alla heltal i arrayen med hjälp av en foreach-loop.
            
            int[] heltal = {1,60,3,4,5};
            
            int summa = 0;
            foreach (var tal in heltal)
            {
                summa += tal;

            }
            Console.WriteLine($"Summan av alla heltar är {summa}");
        }
    }
}
