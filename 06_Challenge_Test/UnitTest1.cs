using System;
using System.Collections.Generic;
using _06_Challenge_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Challenge_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddAndGetListOfCars()
        {
            GreenRepository repoInfo = new GreenRepository();
            GreenPlan customerInfo = new GreenPlan(1, 2015, "Honda", "Sonata", 32d, CarType.Hybrid);
            GreenPlan customerInfo2 = new GreenPlan(2, 2010, "Honda", "Sonata", 32d, CarType.Hybrid);

            repoInfo.AddCarToList(customerInfo);
            repoInfo.AddCarToList(customerInfo2);
            List<GreenPlan> list = repoInfo.GetAllCarInfo();

            var expected = 2;
            var actual = list.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddAndGetInfoForOneCar()
        {
            GreenRepository repoInfo = new GreenRepository();
            GreenPlan customerInfo = new GreenPlan(1, 2015, "Honda", "Sonata", 32d, CarType.Hybrid);
            GreenPlan customerInfo2 = new GreenPlan(2, 2010, "Honda", "Sonata", 32d, CarType.Hybrid);

            repoInfo.AddCarToList(customerInfo);
            repoInfo.AddCarToList(customerInfo2);

            var expected = customerInfo2;
            var actual = repoInfo.GetCarInfo(2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddAndRemoveCarInfo()
        {
            GreenRepository repoInfo = new GreenRepository();
            GreenPlan customerInfo = new GreenPlan(1, 2015, "Honda", "Sonata", 32d, CarType.Hybrid);
            GreenPlan customerInfo2 = new GreenPlan(2, 2010, "Honda", "Sonata", 32d, CarType.Hybrid);

            repoInfo.AddCarToList(customerInfo);
            repoInfo.AddCarToList(customerInfo2);

            repoInfo.RemoveCarFromList(customerInfo);
            List<GreenPlan> list = repoInfo.GetAllCarInfo();

            var expected = 1;
            var actual = list.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetListByType()
        {
            GreenRepository repoInfo = new GreenRepository();
            GreenPlan customerInfo = new GreenPlan(1, 2015, "Honda", "Sonata", 32d, CarType.Hybrid);
            GreenPlan customerInfo2 = new GreenPlan(2, 2010, "Honda", "Sonata", 32d, CarType.Hybrid);

            repoInfo.AddCarToList(customerInfo);
            repoInfo.AddCarToList(customerInfo2);

            List<GreenPlan> list = repoInfo.GetAllCarInfoType(CarType.Hybrid);

            var expected = 2;
            var actual = list.Count;
            Assert.AreEqual(expected, actual);
        }
    }
}
