using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ringklocka
{
    class Hund
    {
        private string namn;

        public Hund(string n)
        {
            namn = n;
        }

        public void DetRinger(int antalRingningar)
        {
            // skapa en textvariabel med namnet på hunden och kolon
            string text = namn + ":";

            // plussa på "vov " så många gånger som vi har ringningar
            for (int i = 1; i <= antalRingningar; i++)
            {
                text = text + " vov";
            }

            // Lägg till ett utropstecken på slutet
            text = text + "!";

            // Skriv ut det på konsolen
            Console.WriteLine(text);
        }

    }
}
