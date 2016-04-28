using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using RentalInterface;

namespace RentalService
{
    public class RentalServiceImplementation : IRental
    {
        public string RegisterCarRental(RentalRegistration rentalRegistration)
        {
            throw new NotImplementedException();
        }

        public void RegisterCarRentalAsPayed(string rentalID)
        {
            throw new NotImplementedException();
        }

        public void StartCarRental(string rentalID, string locationID)
        {
            throw new NotImplementedException();
        }

        public void StopCarRental(string rentalID, string locationID)
        {
            throw new NotImplementedException();
        }

        public RentalRegistration GetRentalRegistration(string rentalID)
        {
            throw new NotImplementedException();
        }
    }
}
