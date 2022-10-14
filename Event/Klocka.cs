using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public delegate void AlarmDelegate();

    class Klocka
    {
        private int timme = 6;
        private int alarmTid;

        public event AlarmDelegate Alarm;

        public Klocka(int a)
        {
            alarmTid = a;
        }

        public void BytTimme()
        {
            timme++;

            Console.WriteLine("Klockan slår " + timme);

            if (timme == alarmTid)
            {
                Alarm();
            }
        }
    }
}
