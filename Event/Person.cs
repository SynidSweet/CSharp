using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Person
    {
        public string namn;

        public Person(string n)
        {
            namn = n;
        }

        public void Vakna()
        {
            Console.WriteLine(namn + " säger: Jag är vaken!!");
        }
    }
}
