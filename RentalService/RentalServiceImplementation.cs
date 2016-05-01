using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using RentalInterface;
using System.Security.Principal;

namespace RentalService
{
    public class RentalServiceImplementation : IRental
    {
        [OperationBehavior(TransactionAutoComplete = true, TransactionScopeRequired = true)]
        public string RegisterCarRental(RentalRegistration rentalRegistration)
        {
            Console.WriteLine("RegisterCarRental");

            if (rentalRegistration == null)
            {
                RentalRegisterFault fault = new RentalRegisterFault();
                fault.FaultID = 1;
                fault.FaultDescription = "Input is not valid,got null value";
                throw new FaultException<RentalRegisterFault>(fault,"got null value");
            }

            try
            {
                using (DataClassesRentalDataContext context = new DataClassesRentalDataContext())
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
            catch (Exception ex)
            {
                RentalRegisterFault fault = new RentalRegisterFault();
                fault.FaultID = 123;
                fault.FaultDescription = "An error occurred whlie inserting the registeration";
                throw new FaultException<RentalRegisterFault>(fault, "An error occurred while inserting");
            }
        }

        [OperationBehavior(Impersonation = ImpersonationOption.Required)]
        public void RegisterCarRentalAsPayed(string rentalID)
        {
            Console.WriteLine("RegisterCarRentalAsPayed " + rentalID);
            Console.WriteLine("WindowsIdentity : {0}",WindowsIdentity.GetCurrent().Name);
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
