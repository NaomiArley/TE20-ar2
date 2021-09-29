using System;

namespace Uppgift3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många poäng fick du på NP");
            int poäng = int.Parse(Console.ReadLine());

            if (poäng < 55)
            {
                Console.WriteLine("Du fick B");
            }
            else if(poäng < 46)
            {
                Console.WriteLine("Du fick C");
            }
            else if(poäng < 35)
            {
                Console.WriteLine("Du fick D");
            }
            else if(poäng <27 )
            {
                Console.WriteLine("Du fick E");
            }
            else if(poäng < 18)
            {
                Console.WriteLine("Du fick F");
            }
            else
            {
                Console.WriteLine("DU fick A!");
            }

        }
    }
}
