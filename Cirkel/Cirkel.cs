using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirkel
{
    class Cirkel
    {
        // A
        private double radie;

        // B
        public double Radie
        {
            get
            {
                return radie;
            }
            set
            {
                radie = value;
            }
        }

        // C
        public Cirkel(double radie)
        {
            this.radie = radie;
        }

        // D
        public double Omkrets()
        {
            return 2 * 3.14 * radie;
        }

    }
}
