using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_Solution;
using System.ServiceModel;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting host...");
            ServiceSolutionRef.DB_ServiceClient host = new ServiceSolutionRef.DB_ServiceClient();
            host.Open();
            Console.WriteLine("Host Open!");


            List<string> lista = host.FetchThroughClassLibAndFromDBAsString().ToList();
            Console.WriteLine();
            Console.WriteLine("host.FetchThroughClassLibAndFromDBAsString().ToList(); Ok!");
            Console.WriteLine();
            foreach (string test in lista)
            {
                Console.WriteLine(test);
            }

            Console.WriteLine();

            List<Testitaulu> taulut = host.FetchThroughClassLibAndFromDBAsTable().ToList();
            Console.WriteLine("host.FetchThroughClassLibAndFromDBAsTable().ToList(); Ok!");
            Console.WriteLine();
            foreach (Testitaulu taulu in taulut)
            {
                Console.WriteLine("Id: " + taulu.Id + ", Nimi: " + taulu.Nimi);
            }
            Console.ReadLine();
        }
    }
}
