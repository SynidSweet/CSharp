using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        enum Kundtyp
        {
            Vanlig,
            Premium,
        }

        static void Main(string[] args)
        {

            double discount1 = Rabatt(10, 46.50, 300, 105, 700);
            double discount2 = Rabatt(100, 406.50, 3000, 1005, 570, 900);
            double discount3 = Rabatt("100");

            double siffra = Math.Min(10, 290);

            Console.WriteLine("rabatt 1: " + discount1);
            Console.WriteLine("rabatt 2: " + discount2);
            Console.WriteLine("rabatt 3: " + discount3);

            Console.ReadKey();
        }

        private static double Rabatt(params double[] priser)
        {
            double total = 0;
            foreach (double p in priser)
            {
                total = total + p;
            }

            return total * 0.25;
        }

        private static double Rabatt(params string[] priser)
        {
            double total = 0;
            foreach (string p in priser)
            {
                total = total + Int32.Parse(p);
            }

            return total * 0.25;
        }
    }
}
