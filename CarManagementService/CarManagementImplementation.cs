using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using CarManagementInterface;

namespace CarManagementService
{
    public class CarManagementImplementation : ICarManagement
    {
        public int InsertNewCar(Car car)
        {
            throw new NotImplementedException();
        }

        public bool RemoveCar(Car car)
        {
            throw new NotImplementedException();
        }

        public void UpdateMileage(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> ListCars()
        {
            throw new NotImplementedException();
        }

        public byte[] GetCarPicture(string carID)
        {
            throw new NotImplementedException();
        }
    }
}
