using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ringklocka
{
    class Person
    {
        private string namn;

        public Person(string n)
        {
            namn = n;
        }

        public void DetRinger(int antalRingningar)
        {
            // skapa en textvariabel med namnet på personen och kolon
            string text = namn + ": ";

            // plussa på "vov " så många gånger som vi har ringningar
            for (int i = 1; i <= antalRingningar; i++)
            {
                text = text + "ja";
            }

            // Lägg till ett utropstecken på slutet
            text = text + ", jag öppnar!";

            // Skriv ut det på konsolen
            Console.WriteLine(text);
        }

    }
}
