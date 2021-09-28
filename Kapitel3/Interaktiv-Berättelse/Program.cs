using System;
using System.Text;

namespace Interaktiv_Berättelse
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.UTF8;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Du har gått vilse i skogen och det finns två vägar, vill du gå åt höger eller vänster?");
            string väg = Console.ReadLine() .ToLower();
            
            if (väg == "höger")//vad som händer om du skriver höger
            {
                Console.Write($"Du går åt {väg}, där finns det ett hus, går du in?");
                string hus = Console.ReadLine() .ToLower();

                // om du väljar att gå in i huset:
                if (hus == "ja")
                {
                    Console.Write("Du går in, där hittar du pengar, tar du något?  ");
                    string pengar = Console.ReadLine().ToLower();
                    if (pengar == "ja")
                    {
                        Console.WriteLine("Tjuv!! Först går du in i någons annan hus och sen tar du deras pengar!! ");
                        Console.Write("Du får skuldkänslor så fort du går ut ur huset, går du in och lämnar pengarna tillbaka? ");
                        string skuld = Console.ReadLine() .ToLower();
                        if (skuld == "ja")
                        {
                            Console.WriteLine("Ägaren ser dig och skriker och du tappar pengarna på ingången och springer iväg🤨");
                        }
                        else
                        {
                            Console.WriteLine("Du glömmer det och går och köper nåt😑 ");
                        }
                        
                    }
                    else //om du väljer att inte ta
                    {
                        Console.WriteLine("Du går ut ur huset direkt för du hörde nåt ljud och fortsätter att gå tills du hittar civilisationen");
                        
                    }
                }
                else if(hus == "nej") //avslutar programet om svaret är något annat än nej/ja
                Console.WriteLine("Du går förbi huset och fortsätter att gå din väg och är tillbaka vid centrumet");
                
            }
            else if (väg == "vänster") // avslutar programet om  svaret inte  är  höger/vänster
            {
                Console.WriteLine($"Du går åt {väg}, där finns det ett buske med bär, äter du en?");
                string bär = Console.ReadLine().ToLower();
                if (bär == "ja")
                {
                    Console.WriteLine("Den var giftig och du dör 💀. Game Over");
                }
                else if(bär== "nej") //avslutar programet om inte svaret blir ja/nej
                {
                    Console.WriteLine("Bra val, den var giftig och du skulle ha dött, du fortsätter att gå och hitar din väg till civilisationen");
                }
                
            }
            

            
        }
    }
}
