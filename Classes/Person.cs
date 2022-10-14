using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Person
    {
        public int id;

        public string namn;
        public string nick;
        public string intresse;
        public int ålder;
        public int längd;
        public bool student;
        public string personnummer;
        public string adress;
        public int postnummer;
        public string ort;

        public void FyllÅr()
        {
            ålder = ålder + 1;
        }

        public string Beskrivning()
        {
            string b = $"Hej, jag heter {namn} och jag gillar {intresse}. Jag är {ålder} år gammal, och när jag gejmar så heter jag {nick}";
            return b;
        }
    }
}
