using System;

namespace _21_an
{
    class Program
    {
        static void Main(string[] args)
        {
            // Både du och datorn får poäng genom att dra kort, varje kort är värt 1 – 10 poäng
            while (true)
            {
            Random generatorkort = new Random();
            int slumpkort = generatorkort.Next(1,11);
                 
            }
            // När spelet börjar dras två kort till både dig och datorn
            Console.WriteLine("21-an kortspel mot datorn!");
            int player = 0;
            int console = 0;

            while (console < 21 && player < 21)
            {
                 
            }
            
            // Varje omgång dras 1 kort till dig och till datorn
            // Du vinner om datorn får 21 eller mer
            // När du inte vill dra fler kort så kommer datorn att dra kort

        }
    }
}
