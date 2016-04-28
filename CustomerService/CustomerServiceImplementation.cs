using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using CustomerInterface;

namespace CustomerService
{
    public class CustomerServiceImplementation : ICustomer
    {
        public int RegisterCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
