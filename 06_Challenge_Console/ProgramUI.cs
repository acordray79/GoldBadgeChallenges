using _06_Challenge_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Challenge_Console
{
    public class ProgramUI
    {
        private GreenRepository _carRepo = new GreenRepository();

        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            bool running = true;
            while (running)
            {

                Console.Clear();
                Console.WriteLine("Hello Security Admin, what would you like to do?\n" +
                    "1: Add a customer.\n" +
                    "2: Edit a customer.\n" +
                    "3: Read a customer.\n" +
                    "4: Show all customer info.\n" +
                    "5: Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddACar();
                        break;
                    case "2":
                        EditACar();
                        break;
                    case "3":
                        ShowACar();
                        break;
                    case "4":
                        ShowAllCars();
                        break;
                    case "5":
                        running = false;
                        break;
                }
            }
        }
        private void AddACar()
        {
            Console.WriteLine("What is the cars ID number?");
            int carID = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the year of the car?");
            int carYear = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the cars model?");
            string modelName = Console.ReadLine();
            Console.WriteLine("What is the cars make?");
            string makeName = Console.ReadLine();
            Console.WriteLine("What is the gas mileage?");
            double gasMileage = double.Parse(Console.ReadLine());
            Console.WriteLine("What number best describes the cars type?\n" +
                "1: Electric\n" +
                "2: Hybrid\n" +
                "3: Gas");
            int cars = int.Parse(Console.ReadLine());
            CarType carType = (CarType)cars;

            GreenPlan newCar = new GreenPlan(carID, carYear, modelName, makeName, gasMileage, carType);
            _carRepo.AddCarToList(newCar);
        }
        private void EditACar()
        {
            Console.WriteLine("What is the cars ID?");
            int carID = int.Parse(Console.ReadLine());
            Console.WriteLine("What number value would you like to change?\n" +
                "1: Model Name\n" +
                "2: Make Name\n" +
                "3: Year\n" +
                "4: Gas Mileage\n" +
                "5: Car Type");
            string carChange = (Console.ReadLine());
            switch (carChange)
            {
                case "1":
                    Console.WriteLine("What is the new model name?");
                    string modelName = Console.ReadLine();
                    foreach (GreenPlan crud in _carRepo.GetAllCarInfo())
                    {
                        if (crud.CarID == carID)
                        {
                            crud.ModelOfCar = modelName;
                        }
                    }
                    
                    break;
                case "2":
                    Console.WriteLine("What is the new make name?");
                    string makeName = Console.ReadLine();
                    foreach (GreenPlan crud in _carRepo.GetAllCarInfo())
                    {
                        if (crud.CarID == carID)
                        {
                            crud.MakeOfCar = makeName;
                        }
                    }
                    
                    break;
                case "3":
                    Console.WriteLine("What is the new year of the car?");
                    int carYear = int.Parse(Console.ReadLine());
                    foreach (GreenPlan crud in _carRepo.GetAllCarInfo())
                    {
                        if (crud.CarID == carID)
                        {
                            crud.YearOfCar = carYear;
                        }
                    }
                    
                    break;
                case "4":
                    Console.WriteLine("What is the new gas mileage of the car?");
                    double gasMileage = double.Parse(Console.ReadLine());
                    foreach (GreenPlan crud in _carRepo.GetAllCarInfo())
                    {
                        if (crud.CarID == carID)
                        {
                            crud.GasMileage = gasMileage;
                        }
                    }
                    
                    break;
                case "5":
                    Console.WriteLine("What is the new customer type?\n" +
                        "1: Electric\n" +
                        "2: Hybrid\n" +
                        "3: Gas");
                    int cType = int.Parse(Console.ReadLine());
                    CarType carType = (CarType)cType;
                    foreach (GreenPlan crud in _carRepo.GetAllCarInfo())
                    {
                        if (crud.CarID == carID)
                        {
                            crud.CarType = carType;
                        }
                    }
                    
                    break;
            }
        }
        private void ShowACar()
        {
            Console.WriteLine("What is the car ID you want to see?");
            int carID = int.Parse(Console.ReadLine());
            GreenPlan crud = _carRepo.GetCarInfo(carID);
            Console.WriteLine($"{crud.CarID} {crud.YearOfCar} {crud.MakeOfCar} {crud.ModelOfCar} {crud.GasMileage} {crud.CarType} ");
            Console.ReadLine();
        }
        private void ShowAllCars()
        {
            Console.WriteLine("Which type of cars would you like to see?\n" +
                "1: Electric\n" +
                "2: Hybrid\n" +
                "3: Gas");
            int cType = int.Parse(Console.ReadLine());
            CarType carType = (CarType)cType;
            foreach (GreenPlan crud in _carRepo.GetCarInfoType(carType))
            {
                    Console.WriteLine($"{crud.CarID} {crud.YearOfCar} {crud.MakeOfCar} {crud.ModelOfCar} {crud.GasMileage} {crud.CarType}");
                }
            }
        }
    }
}
