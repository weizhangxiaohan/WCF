using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementInterface
{
    [ServiceContract]
    public interface ICarManagement
    {
        [OperationContract]
        int InsertNewCar(Car car);
        [OperationContract]
        bool RemoveCar(Car car);
        [OperationContract]
        void UpdateMileage(Car car);
        [OperationContract]
        List<Car> ListCars();
        [OperationContract]
        byte[] GetCarPicture(string carID);
    }

    [DataContract]
    public enum TransmissionTypeEnum
    {
        [DataMember]
        Manual,
        [DataMember]
        Automatic
    }

    [DataContract]
    public class Car
    {
        [DataMember]
        public string BrandName { get; set; }
        [DataMember]
        public string TypeName { get; set; }
        [DataMember]
        public TransmissionTypeEnum Transmission { get; set; }
        [DataMember]
        public int NumberOfDoors { get; set; }
        [DataMember]
        public int MaxNumberOfPersons { get; set; }
        [DataMember]
        public int LitersOfLuggage { get; set; }
    }
}
