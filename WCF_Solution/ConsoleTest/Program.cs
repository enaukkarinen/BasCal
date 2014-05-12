using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_Solution;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceSolutionRef.DB_ServiceClient client = new ServiceSolutionRef.DB_ServiceClient();
            client.Open();
            Console.WriteLine("Client Open!");

            
            List<string> lista = client.FetchThroughClassLibAndFromDBAsString().ToList();
            Console.WriteLine("client.FetchThroughClassLibAndFromDBAsString().ToList(); Ok!");
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
