using _01_Challenge_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge_Console
{
    public class ProgramUI
    {
        private ChallengeRepository _menuRepo = new ChallengeRepository();
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
                Console.WriteLine("Input number of what you would you like to do?\n" +
                    "1: Add new menu meal.\n" +
                    "2: Remove menu meal.\n" +
                    "3: View menu list.\n" +
                    "4: Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddNewMealToList();
                        break;
                    case "2":
                        RemoveMealFromList();
                        break;
                    case "3":
                        ViewMealList();
                        break;
                    case "4":
                        running = false;
                        break;

                }
            }
        }
        private void AddNewMealToList()
        {
            Console.WriteLine("Input number for the meal menu item.");
            int mealNum = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the name of meal menu item?");
            string mealName = Console.ReadLine();
            Console.WriteLine("Type in description of meal menu item.");
            string mealDesc = Console.ReadLine();
            Console.WriteLine("What are ingrediants in meal menu item?");
            string mealIngred = Console.ReadLine();
            Console.WriteLine("Input price with numbers for meal menu item.");
            int mealPrice = int.Parse(Console.ReadLine());

            Challenge newMeal = new Challenge(mealNum, mealName, mealDesc, mealIngred, mealPrice);
            _menuRepo.AddToMenuList(newMeal);
        }
        private void RemoveMealFromList()
        {
            Console.WriteLine("What order ID would you like to remove?");
            int orderID = int.Parse(Console.ReadLine());
            _menuRepo.RemFromMenuList(orderID);
        }
        private void ViewMealList()
        {
            List<Challenge> list = _menuRepo.GetMenuList();
            foreach (Challenge content in list)
            {
                Console.WriteLine($"{content.MealNumber} {content.MealName} {content.MealDescription} {content.MealIngrediants} {content.MealPrice}");
            }
            Console.ReadLine();
        }
    }
}
