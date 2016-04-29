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
            Console.WriteLine("RegisterCarRental");
            using (DataClassesRentalDataContext context = new DataClassesRentalDataContext ())
            {
                Rental rentalToInsert = new Rental();
                rentalToInsert.CustomerID = rentalRegistration.CustomerID;
                rentalToInsert.CarID = rentalRegistration.CarID;
                rentalToInsert.Comments = rentalRegistration.Comments;
                context.Rental.InsertOnSubmit(rentalToInsert);
                context.SubmitChanges();
            }
            return "OK";
        }

        public void RegisterCarRentalAsPayed(string rentalID)
        {
            Console.WriteLine("RegisterCarRentalAsPayed " + rentalID);
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
