using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge_Repository
{
    public class Challenge
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public string MealIngrediants { get; set; }
        public decimal MealPrice { get; set; }

        public Challenge() { }
        public Challenge(int mealNumber, string mealName, string mealDescription, string mealIngrediants, decimal mealPrice)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            MealDescription = mealDescription;
            MealIngrediants = mealIngrediants;
            MealPrice = mealPrice;
        }
    }
}
