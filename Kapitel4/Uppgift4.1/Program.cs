using System;

namespace Uppgift4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string svar = string.Empty .ToLower();

            //Så länge svaret inte är kina så ska porgrammet fortsätta att köra om och om
            while(svar != "Kina")
            {
            Console.Write("Vilket är världens folkrikaste land?   > ");
            svar = Console.ReadLine();
            Console.WriteLine("Fel, försök igen");
            }
            Console.WriteLine("Nu är programmet slut");
        }
    }
}
