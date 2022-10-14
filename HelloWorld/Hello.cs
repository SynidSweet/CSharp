using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {

            Console.Write("Ange namn: ");
            string name = Console.ReadLine();

            string ageInput;
            int age = 0;

            bool correct = false;
            
            while (correct == false)
            {
                try
                {
                    Console.Write("Ange ålder: ");
                    ageInput = Console.ReadLine();
                    age = Int32.Parse(ageInput);
                    age = age + 1;
                    correct = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            PG(name);
            PW(" är ");
            PG(age.ToString());
            PW(" år gammal om ett år.");

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.Write(name);

            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write(" är ");

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.Write(age);

            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write(" år gammal om ett år.");


            Console.ReadKey();

        }

        static void PG(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void PW(string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(text);
        }

    }
}
