using System;

namespace övning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("vad heter du? ");
            string namn = Console.ReadLine();
            Console.WriteLine("Hej " + namn );


            Console.Write("var bor du? ");
            string ort = Console.ReadLine();
            Console.WriteLine("ok " + ort);

            Console.Write("Hur gammal är du? ");
            string ålder = Console.ReadLine();
            Console.WriteLine($"DU ÄR {ålder}" );
            
            
        }
    }
}
