using System;
using System.Collections.Generic;
using _04_Challenge_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Challenge_Test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void AddToDictionaryTest()
        {
            List<string> door1 = new List<string>();
            door1.Add("AD4");
            KomodoInsuranceDictRepository repoInfo = new KomodoInsuranceDictRepository();
            KomodoInsurancePOCO accessInfo = new KomodoInsurancePOCO(1, door1);
            KomodoInsurancePOCO accessInfo2 = new KomodoInsurancePOCO(2, door1);
            KomodoInsurancePOCO accessInfo3 = new KomodoInsurancePOCO(3, door1);
            Dictionary<int, List<string>> employeeBadges = repoInfo.GetAllBadges();

            repoInfo.AddToDictionary(accessInfo);
            repoInfo.AddToDictionary(accessInfo2);
            repoInfo.AddToDictionary(accessInfo3);

            var expected = 3;
            var actual = employeeBadges.Keys.Count;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ReplaceInDictionary()
        {
            List<string> door1 = new List<string>();
            door1.Add("AD4");
            List<string> door2 = new List<string>();
            door2.Add("D34");
            KomodoInsuranceDictRepository repoInfo = new KomodoInsuranceDictRepository();
            KomodoInsurancePOCO accessInfo = new KomodoInsurancePOCO(1, door1);
            KomodoInsurancePOCO accessInfo2 = new KomodoInsurancePOCO(2, door1);
            KomodoInsurancePOCO accessInfo3 = new KomodoInsurancePOCO(3, door1);

            repoInfo.AddToDictionary(accessInfo);
            repoInfo.AddToDictionary(accessInfo2);
            repoInfo.AddToDictionary(accessInfo3);
            
            repoInfo.ChangeDoors(accessInfo2.BadgeID, door2);

            var expected = door2;
            var actual = repoInfo.GetAllBadges()[2];
            Assert.AreEqual(expected, actual);
        }
    }
}
