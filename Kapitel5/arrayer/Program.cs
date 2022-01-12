
using System;

namespace arrayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("arrays");

            string[] ö = new string[3];

            ö[0] = "syros";
            ö[1] = "Naxos";
            ö[2] = "Kreta";

            //byt innehååll
            ö[0] = "Amorgos";

            Console.WriteLine(ö[0]);
            Console.WriteLine(ö[1]);

        }
    }
}
