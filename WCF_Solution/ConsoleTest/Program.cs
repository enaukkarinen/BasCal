using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_Solution;
using System.ServiceModel;
using ConsoleTest.DB_Service_Reference;

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
            DB_Service_Reference.DB_ServiceClient host = new DB_Service_Reference.DB_ServiceClient();
            host.Open();
            Console.WriteLine("Host Open!");
            Console.WriteLine();

            var upevents = host.FetchUpcomingEvents();
            foreach (var eve in upevents)
            {
                Console.WriteLine("Name: " + eve.Name);
                Console.WriteLine("Summary: " + eve.Summary);
                Console.WriteLine("Location: " + eve.Location);
                Console.WriteLine("StartTime: " + eve.StartTime.ToShortDateString() + " - " + eve.StartTime.ToShortTimeString());
                Console.WriteLine("EndTime: " + eve.EndTime.ToShortDateString() + " - " + eve.EndTime.ToShortTimeString());
                Console.WriteLine();
            }
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
