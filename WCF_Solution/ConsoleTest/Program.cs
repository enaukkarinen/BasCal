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
            #region title
            Console.WriteLine();
            Console.WriteLine("########################################");
            Console.WriteLine("######### BasCal Ultimate 9000 #########");
            Console.WriteLine("########################################");
            Console.WriteLine();
            #endregion

            
            
            Console.WriteLine("Starting host...");
            ServiceSolutionRef.DB_ServiceClient host = new ServiceSolutionRef.DB_ServiceClient();
            host.Open();
            Console.WriteLine("Host Open!");
            Console.WriteLine();

            Console.WriteLine();

            List<Testitaulu> taulut = host.FetchThroughClassLibAndFromDBAsTable().ToList();
            Console.WriteLine("host.FetchThroughClassLibAndFromDBAsTable().ToList(); Ok!");
            Console.WriteLine();
            foreach (Testitaulu taulu in taulut)
            {
                Console.WriteLine("Id: " + taulu.Id + ", Nimi: " + taulu.Nimi);
            }

            host.FetchEvents();
            /*
            var events = host.FetchEvents();
            Console.WriteLine("host.FetchEvents().ToList(); Ok!");
            Console.WriteLine();
            foreach (var eve in events)
            {
                Console.WriteLine("EventId: " + eve.EventId);
                Console.WriteLine("TypeId: " + eve.TypeId);
                Console.WriteLine("Name: " + eve.Name);
                Console.WriteLine("Summary: " + eve.Summary);
                Console.WriteLine("Location: " + eve.Location);
                Console.WriteLine("StartTime: " + eve.StartTime.ToShortDateString());
                Console.WriteLine("EndTime: " + eve.EndTime.ToShortDateString());
                Console.WriteLine();
            }

            /*
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
             
             */
            Console.ReadLine();
        }
    }
}
