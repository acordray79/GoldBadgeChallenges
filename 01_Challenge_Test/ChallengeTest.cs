using System;
using System.Collections.Generic;
using _01_Challenge_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Challenge_Test
{
    [TestClass]
    public class ChallengeTest
    {
        [TestMethod]
        public void AddToMenu()
        {

            ChallengeRepository repoInfo = new ChallengeRepository();
            Challenge productInfo = new Challenge(4, "Burger N Fries", "Hamburger with potato french fries", "Bread, meat, potato", 5.99m);

            repoInfo.AddToMenuList(productInfo);
            List<Challenge> list = repoInfo.GetMenuList();

            var expected = 1;
            var actual = list.Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemFromMenuList()
        {
            ChallengeRepository repoInfo = new ChallengeRepository();
            Challenge productInfo = new Challenge(2, "Burger N Fries", "Hamburger with potato french fries", "Bread, meat, potato", 5.99m);
            Challenge productInfo2 = new Challenge(3, "Tuna N Chips", "Tuna filet with potato chips", "Bread, tuna, potato", 5.99m);

            repoInfo.AddToMenuList(productInfo);
            repoInfo.AddToMenuList(productInfo2);
            repoInfo.RemFromMenuList(3);
            List<Challenge> list = repoInfo.GetMenuList();

            var expected = 1;
            var actual = list.Count;
            Assert.AreEqual(expected, actual);
        }
    }
}
