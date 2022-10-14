using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MittTredje
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] prices = { 10, 20, 30 };

            Console.WriteLine(prices[0]+prices[1]+prices[2]);

            Console.ReadKey();

            return;


            string[,] board =
            {
                {"T", "H", "L", "D", "K", "L", "H", "T" },
                {"b", " ", "b", "b", "b", "b", "b", "b" },
                {" ", "b", " ", " ", " ", " ", " ", " " },
                {" ", " ", " ", " ", " ", " ", " ", " " },
                {" ", " ", " ", " ", "b", " ", " ", " " },
                {" ", " ", "H", " ", " ", " ", " ", " " },
                {"b", "b", "b", "b", " ", "b", "b", "b" },
                {"T", " ", "L", "D", "K", "L", "H", "T" },
            };

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Console.Write("[" + board[x, y] + "]");
                }
                Console.WriteLine();
            }

            board[2, 2] = board[0, 1];
            board[0, 1] = " ";

            Console.WriteLine();
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Console.Write("[" + board[x, y] + "]");
                }
                Console.WriteLine();
            }



            Console.ReadKey();

        }
    }
}
