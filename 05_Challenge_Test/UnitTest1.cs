using System;
using System.Collections.Generic;
using _05_Challenge_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Challenge_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddAndGetMethod()
        {
            Crud_Repository repoInfo = new Crud_Repository();
            Crud customerInfo = new Crud(1, "John", "Walters", CustomerType.Current);
            Crud customerInfo2 = new Crud(2, "Jan", "Fittz", CustomerType.Current);

            repoInfo.AddCustomerToEmailList(customerInfo);
            repoInfo.AddCustomerToEmailList(customerInfo2);
            List<Crud> list = repoInfo.GetAllCustomerInfo();

            var expected = 2;
            var actual = list.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetIndividualInfo()
        {
            Crud_Repository repoInfo = new Crud_Repository();
            Crud customerInfo = new Crud(1, "John", "Walters", CustomerType.Current);
            Crud customerInfo2 = new Crud(2, "Jan", "Fittz", CustomerType.Current);

            repoInfo.AddCustomerToEmailList(customerInfo);
            repoInfo.AddCustomerToEmailList(customerInfo2);

            var expected = customerInfo2;
            var actual = repoInfo.GetCustomerInfo(2);

            Assert.AreEqual(expected, actual);
        }
    }
}
