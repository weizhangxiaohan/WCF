using CustomerInterface;
using RentalInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ExternalInterface
{
    [ServiceContract]
    public interface IExternalInterface
    {
        [OperationContract]
        void SubmitRentalContract(RentalContract rentalContract);
    }

    [DataContract]
    public class RentalContract
    {
        [DataMember]
        public string Company { get; set; }
        [DataMember]
        public string CompanyReferenceID { get; set; }
        [DataMember]
        public RentalRegistration RentalRegistration { get; set; }
        [DataMember]
        public Customer Customer { get; set; }
    }
}
