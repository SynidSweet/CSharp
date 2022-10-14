using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "  hör ör en LÅNG mening om iNgEt sörskilt egentligen.    ";

            Console.WriteLine(text);

            text = text.Trim();
            Console.WriteLine(text);

            text = text.Replace('ö', 'ä');
            Console.WriteLine(text);

            text = char.ToUpper(text[0]) + text.Substring(1).ToLower();
            Console.WriteLine(text);

            Console.WriteLine("ordet \"lång\" börjar på index: " + text.IndexOf("lång"));

            Console.ReadKey();
        }
    }
}
