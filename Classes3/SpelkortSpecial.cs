using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes3
{
    class SpelkortSpecial : Spelkort
    {
        public SpelkortSpecial(string f, int v) : base(f, v)
        {
        }

        public void Surprise()
        {
            Console.WriteLine("Surpriiiiiise!");
        }
    }
}
