using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> maillist = new List<string>();

            maillist.Add("petter@nfi.se");
            maillist.Add("petter@aftonbladet.se");
            maillist.Add("petter@netelier.se");
            maillist.Add("petter@formulainfinity.se");
            maillist.Add("petter@glhf.beer");
            maillist.Add("petter@nasa.gov");
            maillist.Add("petter@mitt.space");

            maillist.Remove("petter@nasa.gov");

            maillist.RemoveAt(1);

            string allaAdresser = "";

            foreach(string barbapappa in maillist)
            {
                allaAdresser += barbapappa + "\n";
            }

            StreamWriter writer = new StreamWriter(@"C:\Users\Wanda\Desktop\Hambre.txt");
            writer.Write(allaAdresser);
            writer.Close();

            Console.ReadKey();

        }
    }
}
