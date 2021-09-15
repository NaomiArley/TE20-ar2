using System;

namespace Uppgift2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur högt kan du hoppa i höjdhopp i meter");
            string höjdText = Console.ReadLine();
            double höjd = double.Parse(höjdText);
            double skillnad = 2.45 - höjd;
            Console.WriteLine("Världsrekord är 4.45 och det är " + skillnad + " meter högre än din");
        }
    }
}
