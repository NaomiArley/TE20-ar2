using System;

namespace Uppgift4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program som skriver ut vart 5:e årtal på 1400 nedåt");

            for (int i = 1495; i > 1395; i-=5)
            {
             Console.WriteLine(i);   
            }
        }
    }
}
