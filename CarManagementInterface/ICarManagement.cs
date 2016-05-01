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
        [EnumMember]
        Manual,
        [EnumMember]
        Automatic
    }

    [DataContract]
    [KnownType(typeof(LuxutyCar))]
    [KnownType(typeof(SportCars))]
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

    [DataContract]
    public class LuxutyCar
    {
        [DataMember]
        List<LuxuryItems> LuxuryItemList;
    }

    [DataContract]
    public class LuxuryItems : Car
    {
        [DataMember]
        public string ItemName { get; set; }
        [DataMember]
        public string ItemDescription { get; set; }
    }

    [DataContract]
    public class SportCars : Car
    {
        [DataMember]
        public int HorsePower { get; set; }
    }
}
