using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using CarManagementInterface;
using CarManagementService;
using CustomerInterface;
using CustomerService;
using ExternalInterface;
using ExternalInterfaceFacade;
using RentalInterface;
using RentalService;

namespace HostAllService
{
    class Program
    {
        static ServiceHost CarManagementServiceHost;
        static ServiceHost CustomerServiceHost;
        static ServiceHost ExternalServiceHost;
        static ServiceHost RentalServiceHost;

        static void Main(string[] args)
        {
            Console.WriteLine("ServiceHost");
            try
            {
                CarManagementServiceHost = new ServiceHost(typeof(CarManagementImplementation));
                CarManagementServiceHost.Open();
                CustomerServiceHost = new ServiceHost(typeof(CustomerServiceImplementation));
                CustomerServiceHost.Open();
                ExternalServiceHost = new ServiceHost(typeof(ExternalInterfaceFacadeImplementation));
                ExternalServiceHost.Open();
                RentalServiceHost = new ServiceHost(typeof(RentalServiceImplementation));
                RentalServiceHost.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Started");
            Console.ReadKey();
        }
    }
}
