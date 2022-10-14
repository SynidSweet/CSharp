using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> lista = LäsInPersoner();

            foreach(Person p in lista)
            {
                Console.WriteLine(p.Beskrivning());
            }

            Console.ReadKey();

        }

        static List<Person> LäsInPersoner()
        {
            List<Person> personlista = new List<Person>();

            Person p1 = new Person();
            p1.namn = "Petter";
            p1.ålder = 36;
            p1.intresse = "melodisk techno";
            p1.nick = "Dreamish";
            p1.ort = "Stockholm";

            Person p2 = new Person();
            p2.namn = "Hampus";
            p2.ålder = 27;
            p2.intresse = "psytrance";
            p2.nick = "Hambre";
            p2.ort = "Uppsala";

            personlista.Add(p1);
            personlista.Add(p2);

            return personlista;
        }

    }
}
