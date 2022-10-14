using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ringklocka
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person("Petter");
            Person p2 = new Person("Per");
            Person p3 = new Person("Peter");
            Hund h1 = new Hund("Bustaro");

            Ringklocka klocka = new Ringklocka();

            klocka.Ring += p1.DetRinger;
            klocka.Ring += p3.DetRinger;
            klocka.Ring += h1.DetRinger;

            klocka.RingPåDörren(5);

            Console.ReadKey();
        }
    }
}
