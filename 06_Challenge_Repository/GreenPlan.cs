using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Challenge_Repository
{
    public enum CarType
    {
        Electric = 1, Hybrid, Gas
    }
    public class GreenPlan
    {
        public int CarID { get; set; }
        public int YearOfCar { get; set; }
        public string MakeOfCar { get; set; }
        public string ModelOfCar { get; set; }
        public double GasMileage { get; set; }
        public CarType CarType { get; set; }
        public GreenPlan() { }
        public GreenPlan(int carID, int yearOfCar, string makeOfCar, string modelOfCar, double gasMileage, CarType carType)
        {
            CarID = carID;
            YearOfCar = yearOfCar;
            MakeOfCar = makeOfCar;
            ModelOfCar = modelOfCar;
            GasMileage = gasMileage;
            CarType = carType;
        }
    }
}
