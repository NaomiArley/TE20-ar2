using System;
using System.Text;

namespace EngFlowchart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
            Console.WriteLine("engineering Flowchart");
            Console.Write("Does it move? (yes/no) ");
            string answer1 = Console.ReadLine() .ToLower();
            if (answer1 == "yes")
            {
                Console.Write("Should it? (yes/no)  ");
                string answer2 = Console.ReadLine() .ToLower();
                
                if (answer2 == "no")
                {
                    Console.WriteLine("Use duct tape 😀");
                }
                else
                {
                    Console.WriteLine("No problem! 😀");
                }
            }
            else
            {
                Console.Write("Should it? (yes/no)  ");
                string answer3 = Console.ReadLine();
                if (answer3 == "no")
                {
                    Console.WriteLine("No problem!  😀");
                }
                else
                {
                    Console.WriteLine("Use WD-40 😂😂😂😂");
                }
            }
            


        }
    }
}
