using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace RentalInterface
{
    [ServiceContract]
    public interface IRental
    {
        [OperationContract]
        string RegisterCarRental(RentalRegistration rentalRegistration);

        [OperationContract]
        void RegisterCarRentalAsPayed(string rentalID);

        [OperationContract]
        void StartCarRental(string rentalID, string locationID);

        [OperationContract]
        void StopCarRental(string rentalID, string locationID);

        [OperationContract]
        RentalRegistration GetRentalRegistration(string rentalID);
    }

    [DataContract]
    public enum PaymentStatusEnum
    {
        [EnumMember(Value = "PUV")]
        PaidUpFrontByVoucher,
        [EnumMember(Value = "PUC")]
        PaidUpFrontByCreditCard,
        [EnumMember(Value = "TPP")]
        ToBePaidAtPickUp,
        [EnumMember(Value = "INV")]
        ToBePaidByInvoice
    }

    [DataContract]
    public enum IncludeInsurance
    {
        [EnumMember]
        LiabilityInsurance = 1,
        [EnumMember]
        FireInsurance = 2,
        [EnumMember]
        TheftProtection = 4,
        [EnumMember]
        AllRiskInsurance = 1 + 2 + 4
    }

    [DataContract]
    public class RentalRegistration
    {
        [DataMember]
        public int CustomerID { get; set; }
        [DataMember]
        public string CarID { get; set; }
        [DataMember]
        public int PickUpLocation { get; set; }
        [DataMember]
        public int DropOffLocation { get; set; }
        [DataMember]
        public DateTime PickUpDateTime { get; set; }
        [DataMember]
        public DateTime DropOffDateTime { get; set; }
        [DataMember]
        public PaymentStatusEnum PaymentStatus { get; set; }
        [DataMember]
        public string Comments { get; set; }
    }
}
