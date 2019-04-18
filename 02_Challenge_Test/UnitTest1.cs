using System;
using System.Collections.Generic;
using _02_Challenge_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Challenge_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddAndGetAllQueueTest()
        {
            KomodoClaimsRepository queueRepo = new KomodoClaimsRepository();
            KomodoClaims content = new KomodoClaims(1, ClaimType.Home, "Bad stuff happened", 400.34m, new DateTime(1989, 05, 19), new DateTime(1989, 5, 23), true);

            queueRepo.AddToQueue(content);
            Queue<KomodoClaims> list = queueRepo.GetAllQueue();

            var expected = 1;
            var actual = list.Count;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PeekNextContentTest()
        {
            KomodoClaimsRepository queueRepo = new KomodoClaimsRepository();
            KomodoClaims content = new KomodoClaims(1, ClaimType.Home, "Bad stuff happened", 400.34m, new DateTime(1989, 05, 19), new DateTime(1989, 5, 23), true);

            queueRepo.AddToQueue(content);
            KomodoClaims queueContent = queueRepo.PeekNextContent();

            Assert.AreSame(content, queueContent);
        }
        [TestMethod]
        public void GetNextContentTest()
        {
            KomodoClaimsRepository queueRepo = new KomodoClaimsRepository();
            KomodoClaims content = new KomodoClaims(1, ClaimType.Home, "Bad stuff happened", 400.34m, new DateTime(1989, 05, 19), new DateTime(1989, 5, 23), true);
            KomodoClaims content2 = new KomodoClaims(2, ClaimType.Car, "Big Boom", 400.34m, new DateTime(2018, 05, 19), new DateTime(2018, 9, 23), false);

            queueRepo.AddToQueue(content);
            queueRepo.AddToQueue(content2);
            queueRepo.GetNextContent();
            Queue<KomodoClaims> list = queueRepo.GetAllQueue();

            var expected = 1;
            var actual = list.Count;
            Assert.AreEqual(expected, actual);
        }
    }
}
