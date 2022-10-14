using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkel
{
    class Program
    {
        static void Main(string[] args)
        {

            Cirkel cirkel = new Cirkel(5);

            Console.WriteLine(cirkel.Radie);
            Console.WriteLine(cirkel.Omkrets());

            Console.ReadKey();
        }
    }
}
