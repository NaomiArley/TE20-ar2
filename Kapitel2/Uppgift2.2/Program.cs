using System;

namespace Uppgift2._2
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Vilket årtal lever du på");
            string årtalText = Console.ReadLine();
            int årtal = int.Parse(årtalText);
            int årtalSenare = årtal + 20;
            
            Console.WriteLine("Om 5 år, det är år " + årtalSenare);

            //

        }
    }
}
