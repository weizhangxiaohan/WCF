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
        [OperationBehavior(TransactionAutoComplete = true,TransactionScopeRequired = true)]
        public int RegisterCustomer(CustomerInterface.Customer customer)
        {
            using (DataClassesCustomerDataContext context = new DataClassesCustomerDataContext())
            {
                Customer customerToInsert = new Customer();
                customerToInsert.CustomerName = customer.CustomerName;
                customerToInsert.CustomerFirstName = customer.CustomerFirstName;
                context.Customer.InsertOnSubmit(customerToInsert);
                context.SubmitChanges();
                return customerToInsert.CustomerID;
            }
        }
    }
}
