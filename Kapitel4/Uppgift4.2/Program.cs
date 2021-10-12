using System;

namespace Uppgift4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programmet ska skriva ut tal 50 till 1 i varsin rad");
            int tal = 51;
            while(tal >1)
            {
                tal--; //Minskar variabeln med 1 varje gång loopen körs
                Console.WriteLine(tal);
            }
        }
    }
}
