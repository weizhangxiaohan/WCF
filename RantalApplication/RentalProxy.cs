using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using RentalInterface;

namespace RantalApplication
{
    public class RentalProxy : ClientBase<IRental>,IRental
    {
        public RentalProxy()
            : base("RentalServiceEndpoint")
        {
        
        }

        public string RegisterCarRental(RentalRegistration rentalRegistration)
        {
            return Channel.RegisterCarRental(rentalRegistration);
        }

        public void RegisterCarRentalAsPayed(string rentalID)
        {
            Channel.RegisterCarRentalAsPayed(rentalID);
        }

        public void StartCarRental(string rentalID, string locationID)
        {
            Channel.StartCarRental(rentalID, locationID);
        }

        public void StopCarRental(string rentalID, string locationID)
        {
            Channel.StopCarRental(rentalID, locationID);
        }

        public RentalRegistration GetRentalRegistration(string rentalID)
        {
            return Channel.GetRentalRegistration(rentalID);
        }
    }
}
