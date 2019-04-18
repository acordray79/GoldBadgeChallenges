using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge_Repository
{
    public class ChallengeRepository
    {
        private List<Challenge> _listOfMeals = new List<Challenge>();

        public void AddToMenuList(Challenge menu)
        {
            _listOfMeals.Add(menu);
        }
        public List<Challenge> GetMenuList()
        {
            return _listOfMeals;
        }
        public void RemFromMenuList(int mealNumFromUser)
        {
            foreach (Challenge prod in _listOfMeals)
            {
                if (prod.MealNumber == mealNumFromUser)
                {
                    _listOfMeals.Remove(prod);
                    break;
                }
            }
        }

    }
}
