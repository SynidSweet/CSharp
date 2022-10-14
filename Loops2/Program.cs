using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal = 0;

            while (tal < 20)
            {
                tal++;

                if (tal == 11 || tal == 13)
                {
                    // Do nothing
                }
                else
                {
                    Console.WriteLine(tal);
                }
            }

        }
    }
}
