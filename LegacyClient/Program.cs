using LegacyClient.ServiceReference;
using System;
using System.ServiceModel;

namespace LegacyClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to run...");
            Console.ReadKey();

            using (var serviceClient = new ServiceClient())
            {
                serviceClient.Open();
                var result = serviceClient.GetData(32);
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
