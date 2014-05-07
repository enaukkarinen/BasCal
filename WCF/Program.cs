﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;

namespace Darkside.WCF4Silverlight
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Starting host...");

            var host = new ServiceHost(typeof(MyService));
            host.Open();
            Console.WriteLine("Started.");

            Console.Write("Press <ENTER> to exit");
            Console.ReadLine();
            host.Close();

        }
    }
}