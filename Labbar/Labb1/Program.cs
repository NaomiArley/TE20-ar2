using System;

namespace Labb1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Program som skriver ut ASCII");

            //matar in ett ord
            Console.Write("Ange ett ord   ");
            string ord = Console.ReadLine();

            Console.Write("Ange ett nyckel(1-9)");
            int nyckel = int.Parse(Console.ReadLine());

            string meddelandeKrypterad = "";
            //loopar igenom ordet som användaren skrevs bokstav för bokstav
            for (int i = 0; i < ord.Length; i++)
            {
                char bokstav = ord[i];
                if (bokstav == ' ') //om ord har mellanslag så ska det skriva ut ett mellanslag annars fortsätter programmet
                {
                    meddelandeKrypterad += " ";
                }
                else if (bokstav == 'ä')
                {
                    int kod = (int)bokstav;
                    char bokstavKrypterad = (char)(kod);
                    meddelandeKrypterad += bokstavKrypterad + nyckel ;
                }
                else
                {

                    int kod = (int)bokstav;
                    kod += nyckel;
                    char bokstavKrypterad = (char)(kod);
                    meddelandeKrypterad += bokstavKrypterad.ToString();
                }
            }
            Console.WriteLine($"{ord} blir : {meddelandeKrypterad} ");
        }

    }
}
