using System;

namespace menyprogram
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Clear();
            Console.WriteLine("Enkelt menyprogram!");
            
            //skapa e slumpgenerator
            Random tärning = new Random();

            //programloop
            while (true)
            {
                //slumpa frm ett tal
                int slumptal = tärning.Next(1,4);
                 Console.WriteLine("Väl ett avv följande alternativ");

                 Console.WriteLine("Väljer du sten?(1)  ");
                 Console.WriteLine("Väljer du sax?(2)  ");
                 Console.WriteLine("Väljer du påse?(3)  ");
                 Console.WriteLine("Väljer du avsluta programet(4)  ");
                string valstring = Console.ReadLine();
                
                //vill användaren avsluta?
                if (valstring == "4")
                {
                    break;
                }


                int val = int.Parse(valstring);

                //är det rätt svar
                if (val == slumptal)
                {
                    Console.WriteLine("Lika!");
                }
                else if(val == 2 && slumptal == 1 || val == 3 && slumptal == 2)
                {
                    Console.WriteLine("Du förlorar!");
                }
                else
                {
                    Console.WriteLine("Du vinner");
                }
                
            }
        }
    }
}
