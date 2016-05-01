using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using ExternalInterface;
using System.Transactions;
using CustomerInterface;
using RentalInterface;

namespace ExternalInterfaceFacade
{
    public class ExternalInterfaceFacadeImplementation : IExternalInterface
    {
        public void SubmitRentalContract(RentalContract rentalContract)
        {
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                NetNamedPipeBinding netNamedPipeBinding = new NetNamedPipeBinding();
                netNamedPipeBinding.TransactionFlow = true;

                ICustomer customerServiceChannel = ChannelFactory<ICustomer>.CreateChannel(netNamedPipeBinding,new EndpointAddress("net.pipe://localhost/CustomerService"));

                int newCustomerID = customerServiceChannel.RegisterCustomer(rentalContract.Customer);
                rentalContract.RentalRegistration.CustomerID = newCustomerID;

                IRental rentalServiceChannel = ChannelFactory<IRental>.CreateChannel(netNamedPipeBinding,new EndpointAddress("net.pipe://localhost/rentalService"));
                rentalServiceChannel.RegisterCarRental(rentalContract.RentalRegistration);

                scope.Complete();
            }
        }
    }
}
