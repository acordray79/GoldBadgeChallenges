using _03_Challenge_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge_Console
{
    public class ProgramUI
    {
        private KomodoOutingRepository _outingRepo = new KomodoOutingRepository();
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
                    "1: List All Outings.\n" +
                    "2: Add an outing.\n" +
                    "3: Display total cost of an outing.\n" +
                    "4: Display total cost of all outings.\n" +
                    "5: Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ListAllOutings();
                        break;
                    case "2":
                        AddAnOuting();
                        break;
                    case "3":
                        DisplayCostOfOutingType();
                        break;
                    case "4":
                        DisplayCostOfAllOutings();
                        break;
                    case "5":
                        running = false;
                        break;

                }
            }
        }
        private void ListAllOutings()
        {
            List<KomodoOutings> list = _outingRepo.GetEventList();
            foreach (KomodoOutings content in list)
            {
                Console.WriteLine($"Event Type      People      Date        Person Cost     Event Cost      Total Event Cost\n{content.EventType} {content.PeopleAttended} {content.Date} {content.CostPerPerson} {content.CostForEvent} {content.TotalCostForEvent}");
            }
            Console.ReadLine();
        }
        private void AddAnOuting()
        {
            Console.WriteLine("What is the outing type number?\n" +
                "1: Golf\n" +
                "2: Bowling\n" +
                "3: AmusementPark\n" +
                "4: Concert");
            int outing = int.Parse(Console.ReadLine());
            EventType eventType = (EventType)outing;
            Console.WriteLine("What number of people attended?");
            int peopleCount = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the date of the outing? (YYYY/MM/DD)");
            DateTime outingDateTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Type is the cost per person in decimal form? (5.50)");
            decimal peoplePrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("What is the cost for the outing? (200.65)");
            decimal outingPrice = decimal.Parse(Console.ReadLine());

            KomodoOutings newOuting = new KomodoOutings(eventType, peopleCount, outingDateTime, peoplePrice, outingPrice);
            _outingRepo.EventCost(newOuting);
            _outingRepo.AddToEventList(newOuting);
        }
        private void DisplayCostOfOutingType()
        {
            Console.WriteLine("What is the outing type number?\n" +
                "1: Golf\n" +
                "2: Bowling\n" +
                "3: AmusementPark\n" +
                "4: Concert");
            int outing = int.Parse(Console.ReadLine());
            EventType eventType = (EventType)outing;
            Console.WriteLine($"The total of the event type {eventType} is {_outingRepo.SpecificEventCost(eventType)}");
            Console.ReadLine();
        }
        private void DisplayCostOfAllOutings()
        {
            Console.WriteLine($"The total of all events is {_outingRepo.AllEventCostList()}");
            Console.ReadLine();

        }
    }
}
