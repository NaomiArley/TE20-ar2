using System;

namespace Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Clear();
           
            Console.Write("Hur mycket väger du? ");
            double vikt = double.Parse(Console.ReadLine());

            
            
        double viktLbs = vikt * 2.2;
        //formatera till en snygg utskrift
        string viktstring = viktLbs.ToString("0.##");
        Console.WriteLine($"Din vikt är {viktstring} Lbs");

        }
    }
}
