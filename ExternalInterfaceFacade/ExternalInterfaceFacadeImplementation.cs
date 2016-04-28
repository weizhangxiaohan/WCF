using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using ExternalInterface;

namespace ExternalInterfaceFacade
{
    public class ExternalInterfaceFacadeImplementation : IExternalInterface
    {
        public void SubmitRentalContract(RentalContract rentalContract)
        {
            throw new NotImplementedException();
        }
    }
}
