using System;

namespace Prov1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Uträkning av nettolön");
            

            while (true)
            {
            Console.WriteLine("----------------------");
            //matar navändarens namn
            Console.Write("Vad heter du?:  ");
            string namn = Console.ReadLine();

            //mattar in bruttolönen
            Console.Write("Ange din bruttolön i kronor:  ");
            int bruttolön = int.Parse(Console.ReadLine());
            //Avger felmeddelanden om bruttolön inte är mellan 10000 och 45000kr
            if (bruttolön < 10000)
            {
                Console.WriteLine($"{namn}, bruttolön ska vara > 10000 kr! ");
                Console.WriteLine("Varsågod försök igen");
                
            }
            else if (bruttolön > 45001)
            {
                Console.WriteLine($"{namn}, bruttolön måste vara < 45000 kr! ");
                Console.WriteLine("Varsågod försök igen");
            }
            //Om bruttolön är inom den tillåten värde då fortsåtter programmet
            else
            {
            //matar in skattesatsen
            Console.Write("Ange din skattesats i %:  ");
            int skattesats = int.Parse(Console.ReadLine());

            //Om skattesatsen inte är mellan 10 och 45 så ber programmet att börja om 
            if (skattesats < 10)
            {
                Console.WriteLine($"{namn}, skattesatsen måste vara > 10%");
                Console.WriteLine("Vänligen försök igen.");
            }
            else if (skattesats > 46)
            {
                Console.WriteLine($"{namn}, skattesatsen måste vara < 45%");
                Console.WriteLine("Vänligen försök igen.");
            }
            else //om värdena är inom den tillåtna värde så fortsätter programmet och gör beräkningen
            {
                int nettolön = bruttolön *(100 - skattesats)/100;
                Console.WriteLine("----------------------");
                Console.WriteLine($"{namn}, din nettolön blir {nettolön}.");
                Console.WriteLine($"Baserat på bruttolön {bruttolön}kr och skattesatsen {skattesats}%");
            }
            //Frågar användaren om hen vill starta programmet igen
            Console.WriteLine("Vill du göra en ny beräkning?(ja/nej)");
            string svar = Console.ReadLine().ToLower();
            Console.WriteLine("----------------------");
            //om ssvaret är nej så ska programmet avslutas
            if (svar == "nej")
            {
              break;
            }
            }
                 
            }
            
            
            
        }
    }
}
