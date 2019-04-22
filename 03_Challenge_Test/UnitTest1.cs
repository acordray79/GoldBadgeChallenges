using System;
using System.Collections.Generic;
using _03_Challenge_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Challenge_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddAndGetList()
        {
            KomodoOutingRepository repoInfo = new KomodoOutingRepository();
            KomodoOutings productInfo = new KomodoOutings(EventType.Bowling, 5, new DateTime(2019 / 1 / 25), 15.23m, 250.50m);

            repoInfo.AddToEventList(productInfo);
            List<KomodoOutings> list = repoInfo.GetEventList();

            var expected = 1;
            var actual = list.Count;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestEventCost()
        {
            KomodoOutingRepository repoInfo = new KomodoOutingRepository();
            KomodoOutings productInfo = new KomodoOutings(EventType.Bowling, 6, new DateTime(2019 / 1 / 25), 25.50m, 220m);

            repoInfo.AddToEventList(productInfo);
            repoInfo.EventCost(productInfo);

            var actual = productInfo.TotalCostForEvent;
            

            var expected = 373m;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SpecificTypeAllCost()
        {
            KomodoOutingRepository repoInfo = new KomodoOutingRepository();
            KomodoOutings productInfo = new KomodoOutings(EventType.Bowling, 6, new DateTime(2019 / 1 / 25), 25.50m, 220m);
            KomodoOutings productInfo2 = new KomodoOutings(EventType.Bowling, 6, new DateTime(2019 / 1 / 25), 25.50m, 220m);

            repoInfo.EventCost(productInfo);
            repoInfo.EventCost(productInfo2);

            repoInfo.AddToEventList(productInfo);
            repoInfo.AddToEventList(productInfo2);

            repoInfo.SpecificEventCost(EventType.Bowling);

            var actual = repoInfo.AllEventCostList();


            var expected = 746m;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestTotalEventCost()
        {
            KomodoOutingRepository repoInfo = new KomodoOutingRepository();
            KomodoOutings productInfo = new KomodoOutings(EventType.Bowling, 6, new DateTime(2019 / 1 / 25), 25.50m, 220m);

            repoInfo.AddToEventList(productInfo);
            var actual = repoInfo.AllEventCostList();


            var expected = 373m;
            Assert.AreEqual(expected, actual);
        }

    }
}
