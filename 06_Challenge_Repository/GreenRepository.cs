using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Challenge_Repository
{
    public class GreenRepository
    {
        private List<GreenPlan> _listOfCars = new List<GreenPlan>();

        public void AddCarToList(GreenPlan car)
        {
            _listOfCars.Add(car);
        }
        public void RemoveCarFromList(GreenPlan car)
        {
            _listOfCars.Remove(car);
        }
        public GreenPlan GetCarInfo(int carID)
        {
            foreach (GreenPlan auto in _listOfCars)
            {
                if (auto.CarID == carID)
                {
                    return auto;
                }
            }
            return null;
        }
        public List<GreenPlan> GetAllCarInfoType(CarType carType)
        {
            List<GreenPlan> listOfCarType = new List<GreenPlan>();
            foreach (GreenPlan auto in _listOfCars)
            {
                if (auto.CarType == carType)
                {
                    listOfCarType.Add(auto);
                }
            }
                    return listOfCarType;
        }
        public List<GreenPlan> GetAllCarInfo()
        {
            return _listOfCars;
        }
    }
}
