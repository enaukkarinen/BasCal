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
            
            /*
            dbRepository repo = new dbRepository();
            List<string> nimet = repo.FetchDataAsString();

            Console.Write("Haetaan List<string>: ... ");
            Console.WriteLine("Ok!");
            foreach (var str in nimet)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("Paina <Enter>");
            Console.ReadLine();

            Console.Write("Haetaan IQueryable<Testitaulu>: ...");
            List<Testitaulu> taulut = repo.FetchDataAsTableModel().ToList();
            Console.WriteLine("Ok!");
            foreach (Testitaulu x in taulut)
            {
                Console.WriteLine("Id: " + x.Id + " Nimi: " + x.Nimi);
            }
            Console.WriteLine("Paina <Enter>");
             */

            Console.ReadLine();
        }
    }
}
