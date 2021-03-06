﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.ServiceModel;
using System.ServiceModel.Description;
using Lexs4SearchRetrieveWebService;

namespace LexsSRWebServiceHostApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(LEXSSearchRetrievePortType),
                new Uri("http://localhost:8000/Lexs4SearchRetrieve")))
            {
                BasicHttpBinding binding = CreateBinding();

                host.AddServiceEndpoint(typeof(ILEXSSearchRetrievePortType), binding, "LEXSSearchRetrievePortType");

                AddServiceMetadataBehavior(host);

                host.Open();

                Console.WriteLine("Press <ENTER> to terminate the service host...");
                Console.ReadLine();
            }
        }

        private static BasicHttpBinding CreateBinding()
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            XmlDictionaryReaderQuotas readerQuotas = new XmlDictionaryReaderQuotas();
            readerQuotas.MaxDepth = 2147483647;
            readerQuotas.MaxStringContentLength = 2147483647;
            readerQuotas.MaxArrayLength = 2147483647;
            readerQuotas.MaxBytesPerRead = 2147483647;
            readerQuotas.MaxNameTableCharCount = 2147483647;

            binding.ReaderQuotas = readerQuotas;
            return binding;
        }

        private static void AddServiceMetadataBehavior(ServiceHost host)
        {
            ServiceMetadataBehavior mexBehavior = host.Description.Behaviors.Find<ServiceMetadataBehavior>();

            if (mexBehavior == null)
            {
                mexBehavior = new ServiceMetadataBehavior();
                mexBehavior.HttpGetEnabled = true;
                host.Description.Behaviors.Add(mexBehavior);
            }
        }
    }
}
