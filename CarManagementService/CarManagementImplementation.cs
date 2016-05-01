using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using CarManagementInterface;
using System.IO;

namespace CarManagementService
{
    public class CarManagementImplementation : ICarManagement
    {
        public int InsertNewCar(Car car)
        {
            Console.WriteLine("InsertNewCar {0} {1}",car.BrandName,car.TypeName);
            return 1;
        }

        public bool RemoveCar(Car car)
        {
            Console.WriteLine("RemoveCar {0} {1}", car.BrandName, car.TypeName);
            return true;
        }

        public void UpdateMileage(Car car)
        {
            Console.WriteLine("UpdateCar {0} {1}", car.BrandName, car.TypeName);
        }

        public List<Car> ListCars()
        {
            Console.WriteLine("ListCars");
            List<Car> listCars = new List<Car>();
            listCars.Add(new Car {
                BrandName = "Audi",
                Transmission = TransmissionTypeEnum.Automatic,
                TypeName = "A4"
            });
            listCars.Add(new Car
            {
                BrandName = "Volkswagen",
                Transmission = TransmissionTypeEnum.Automatic,
                TypeName = "Golf"
            });
            listCars.Add(new SportCars
            {
                BrandName = "Ferraari",
                Transmission = TransmissionTypeEnum.Automatic,
                TypeName = "XXXX",
                HorsePower = 600
            });
            return listCars;
        }

        public byte[] GetCarPicture(string carID)
        {
            Console.WriteLine("GetCarPicture");
            byte[] buff;
            string pathToPicture = @"D:\Car.jpg";

            FileStream fileStream = new FileStream(pathToPicture,FileMode.Open,FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            buff = binaryReader.ReadBytes((int)fileStream.Length);
            return buff;
        }
    }
}
