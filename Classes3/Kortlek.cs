using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes3
{
    class Kortlek
    {
        public Random random = new Random();

        public List<Spelkort> kortlista = new List<Spelkort>();

        public Kortlek()
        {
            Reset();
        }

        public void Reset()
        {
            kortlista.Clear();

            string[] färger = { "Hjärter", "Ruter", "Spader", "Klöver" };

            foreach (string färg in färger)
            {
                for (int valör = 1; valör <= 13; valör++)
                {
                    Spelkort nyttKort = new Spelkort(färg, valör);
                    kortlista.Add(nyttKort);
                }
            }
        }

        public Spelkort DraÖversta()
        {
            Spelkort översta = kortlista[0];

            kortlista.RemoveAt(0);

            return översta;
        }

        public Spelkort DraSlump()
        {
            int index = random.Next(0, kortlista.Count - 1);

            Spelkort kort = kortlista[index];

            kortlista.RemoveAt(index);

            return kort;
        }

    }
}
