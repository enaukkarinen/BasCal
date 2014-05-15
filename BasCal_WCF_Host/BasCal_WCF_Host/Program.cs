using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BasCal_WCF_Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting host...");

            var host = new ServiceHost(typeof(DBservice));
            host.Open();
            Console.WriteLine("Started.");

            Console.Write("Press <ENTER> to exit");
            Console.ReadLine();
            host.Close();
        }
    }
}
