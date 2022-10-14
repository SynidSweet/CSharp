using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes3
{
    class Spelkort
    {
        public string färg;
        public int valör;

        public Spelkort(string f, int v)
        {
            färg = f;
            valör = v;
        }

        public string KortNamn()
        {
            string kortnamn = färg + " ";

            switch (valör)
            {
                case 1:
                    kortnamn = kortnamn + "Ess";
                    break;
                case 11:
                    kortnamn = kortnamn + "Knekt";
                    break;
                case 12:
                    kortnamn = kortnamn + "Dam";
                    break;
                case 13:
                    kortnamn = kortnamn + "Kung";
                    break;
                default:
                    kortnamn = kortnamn + valör;
                    break;
            }
            return kortnamn;
        }
    }
}
