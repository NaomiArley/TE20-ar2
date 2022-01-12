using System;

namespace Arrays_TP_frågor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SLumpa fram en fråga");
            //namge korten(array)
            string[] korten = {
            "När uppfördes Verdi?",
            "Vem vann fotbolls-EM1984?",
            "Vem skrev Frankenstein?",
            "Vad är 5+5",
            "När startades andra världskriget",
            "Vem är president i USA 2021?"
            };

            //kasta tärningen
            Random tärning= new Random();
            int slumptal = tärning.Next(0, 6);

            //skriver utslaget
            Console.WriteLine($"Tärningen slog {slumptal}");

            //skriv ut fråga 
            Console.WriteLine($"Fråga {slumptal}: {korten[slumptal]}");
        }
    }
}
