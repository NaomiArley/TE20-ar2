using System;

namespace Slumptal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("slumptal");
        
            //slumpgenerator
            Random generator = new Random();
            //slupa fram et ttal 1-10
            int slumptal = generator.Next(1,11);
            int slumptal2 = generator.Next(1,7);
            Console.WriteLine($"{slumptal}   {slumptal2}");
        }
    }
}
