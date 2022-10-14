using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kortlek lek = new Kortlek();
            Spelkort kort;

            kort = lek.DraSlump();
            Console.WriteLine($"Du drog {kort.KortNamn()}");
            kort = lek.DraSlump();
            Console.WriteLine($"Du drog {kort.KortNamn()}");
            kort = lek.DraSlump();
            Console.WriteLine($"Du drog {kort.KortNamn()}");
            kort = lek.DraSlump();
            Console.WriteLine($"Du drog {kort.KortNamn()}");
            kort = lek.DraSlump();
            Console.WriteLine($"Du drog {kort.KortNamn()}");

            Console.WriteLine();

            Spelkort kort2 = new Spelkort("Hjärter", 5);
            SpelkortSpecial kort2Spec = new SpelkortSpecial("Hjärter", 5);

            Console.WriteLine($"Du drog {kort2.KortNamn()}");
            Console.WriteLine($"Du drog {kort2Spec.KortNamn()}");

            kort2Spec.Surprise();

            Console.ReadKey();

        }
    }
}
