using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ringklocka
{
    public delegate void RingerDelegate(int knapptryckningar);

    class Ringklocka
    {
        public event RingerDelegate Ring;

        public void RingPåDörren(int antal)
        {
            Console.WriteLine("*** RING ***");
            Ring(antal);
        }

    }
}
