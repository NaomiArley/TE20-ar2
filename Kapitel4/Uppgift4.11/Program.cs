using System;

namespace Uppgift4._11
{
    class Program
    {
        static void Main(string[] args)
            //Skapa ett program där användaren får svara på frågan ”Vilket är Europas folkrikaste land?”. Användaren får maximalt 5 chanser på sig att svara. När användaren svarar rätt så ska programmet skriva ut att rätt svar angavs, därefter ska det avslutas. Utnyttja ett break någonstans i din loop.
        { 

            Console.WriteLine("Detta är ett program som frågar användaren vilket är Europas folkrikaste land");

            int chanser = 6;
            string svar = string.Empty .ToLower();

            //OM svaret är tyskland och användaren har chanser kvar då kör programmet, annars avslutas den
            while(svar != "tyskland" && chanser > 1)
            {
                chanser--;
                Console.WriteLine("Du har 5 chanser att svara rätt!!");
                Console.Write("Vad är Europas folkrikaste land?    ");
                svar = Console.ReadLine() .ToLower();
                if (svar == "kina")
                {
                    Console.WriteLine("Kina är VÄRLDENS folkrikaste land, vad är EUROPAS?");
                }
                Console.WriteLine($"Du har {chanser} chanser kvar!!");
                
            }
            Console.WriteLine("NICE");
        }
    }
}
