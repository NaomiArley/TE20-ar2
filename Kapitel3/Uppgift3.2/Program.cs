using System;

namespace Uppgift3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket land vann fotbolls-VM för damer år 2015?");
           string vinnare = Console.ReadLine().ToLower();
           
            if (vinnare == "usa")
            {
               Console.WriteLine("Du hade rätt"); 
            }

            
            else
            {

                Console.WriteLine("Du svarade fel, svaret är USA");
            }

        }
    }
}
