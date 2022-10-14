using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] users = { "Petter", "Erik", "Daniel", "Hampus", "Leo", "Lina", "Skelettet", "En pizza slice", "🍕" };

            //for (int i = 0; i < users.Length; i++)
            //{
            //    Console.WriteLine("User " + (i + 1) + ": " + users[i]);
            //}

            //Console.WriteLine();

            //foreach (string u in users)
            //{
            //    Console.WriteLine(u);
            //}

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.ReadKey();

            string[] items = { "Solglasögon", "Vindruvor", "Energidryck", "🍕", "Coca Cola" };
            double[] prices = { 30, 46, 29.90, 10000.90, 34 };

            double total = 0;

            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i] + ": \t" + prices[i] + " kr.");
                total = total + prices[i];
            }

            Console.WriteLine();
            Console.WriteLine("Total kostnad: " + total + " kronor.");

            Console.ReadKey();
        }
    }
}
