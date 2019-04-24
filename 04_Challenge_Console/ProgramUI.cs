using _04_Challenge_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Challenge_Console
{
    public class ProgramUI
    {
        private KomodoInsuranceDictRepository _badgeRepo = new KomodoInsuranceDictRepository();
        List<string> _doorList = new List<string>();
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
                    "1: Add a badge.\n" +
                    "2: Edit a badge.\n" +
                    "3: List all badges.\n" +
                    "4: Exit.");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddABadge();
                        break;
                    case "2":
                        EditABadge();
                        break;
                    case "3":
                        ShowAllBadge();
                        break;
                    case "4":
                        running = false;
                        break;
                }
            }
        }
        private void AddABadge()
        {
            string addMoreDoors = "y";

            Console.WriteLine("What is the number on the badge?");
            int badgeID = int.Parse(Console.ReadLine());
            while (addMoreDoors.Contains("y"))
            {

            Console.WriteLine("List a door it needs access to:");
            _doorList.Add(Console.ReadLine());
            Console.WriteLine("Any other doors? (y/n)");
            addMoreDoors = Console.ReadLine().ToLower();
            }

            KomodoInsurancePOCO newID = new KomodoInsurancePOCO(badgeID, _doorList);
            _badgeRepo.AddToDictionary(newID);
        }
        private void EditABadge()
        {
            List<string> doorList = new List<string>();
            Console.WriteLine("What is the badge number to update?");
            int badgeID = int.Parse(Console.ReadLine());
            Console.WriteLine($"{badgeID} has access to doors:");
            foreach (string doorAccess in _badgeRepo.GetAllBadges()[badgeID])
            {
                Console.WriteLine(doorAccess);
            }
            Console.WriteLine("What would you like to do?\n" +
                "1. Remove a door.\n" +
                "2. Add a door.");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Which door would you like to remove?");
                    string doorInput = Console.ReadLine();
                    foreach (var doorA in _badgeRepo.GetAllBadges()[badgeID])
                    {
                        if (doorInput == doorA)
                        {
                            _doorList.Remove(doorA);
                            break;
                        }
                    }
                    //remove door
                    break;
                case "2":
                    Console.WriteLine("What door will you be adding to this ID?");
                    _doorList.Add(Console.ReadLine());
                    //add door
                    break;
                default:
                    break;

            }
        }
        private void ShowAllBadge()
        {
            foreach (KeyValuePair<int, List<string>> kvp in _badgeRepo.GetAllBadges())
            {
                Console.WriteLine($"BadgeID = {kvp.Key}\n" +
                    $"and has access to\n");
                foreach(string door in kvp.Value)
                {
                    Console.WriteLine(door);
                }
                Console.ReadLine();
            }
        }
    }
}
