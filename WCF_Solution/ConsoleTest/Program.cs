using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ConsoleTest.ServiceReference1;

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
            DB_ServiceClient host = new DB_ServiceClient();
            host.Open();
            Console.WriteLine("Host Open!");
            Console.WriteLine();

            
       
            //var events = host.FetchUpcomingEventsShort();
            //Console.WriteLine("host.FetchUpcomingEventsShort; Ok!");
            //Console.WriteLine();
            //foreach (var eve in events)
            //{
            //    Console.WriteLine("Name: " + eve.Name);
            //    Console.Write("StartTime: " + eve.StartTime);
            //    Console.WriteLine(" StartDate: " + eve.StartDate);
            //    Console.Write("EndTime: " + eve.EndTime);
            //    Console.WriteLine(" EndDate: " + eve.EndDate);
            //    Console.WriteLine();
            //}

            //var events2 = host.FetchUpcomingEvents();
            //Console.WriteLine("host.FetchUpcomingEvents; Ok!");
            //Console.WriteLine();
            //foreach (var eve in events2)
            //{
            //    Console.WriteLine("EventId: " + eve.EventId);
            //    Console.WriteLine("TypeId: " + eve.TypeId);
            //    Console.WriteLine("Type: " + eve.Type);

            //    Console.WriteLine();
            //}

            var evbyguid = host.FetchEventByGuid(new Guid("7B79BC09-298E-4060-9A2F-189DC6277DF8"));

            Console.WriteLine(evbyguid.EventId);
            Console.WriteLine(evbyguid.Type);
            Console.WriteLine(evbyguid.Name);
            Console.ReadLine();
        }
    }
}
