using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Petter");
            Person p2 = new Person("Erik");
            Person p3 = new Person("Daniel");
            Person p4 = new Person("Hampus");


            Klocka k1 = new Klocka(9);
            Klocka k3 = new Klocka(11);

            k1.Alarm += p1.Vakna;
            k1.Alarm += p3.Vakna;
            k3.Alarm += p4.Vakna;

            k1.BytTimme();
            k3.BytTimme();
            k1.BytTimme();
            k3.BytTimme();
            k1.BytTimme();
            k3.BytTimme();
            k1.BytTimme();
            k3.BytTimme();
            k1.BytTimme();
            k3.BytTimme();
            k1.BytTimme();
            k3.BytTimme();
            k1.BytTimme();
            k3.BytTimme();


            Console.ReadKey();
        }
    }
}
