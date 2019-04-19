using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge_Repository
{
    public class KomodoOutingRepository
    {
        private List<KomodoOutings> _listOfEvents = new List<KomodoOutings>();

        public List<KomodoOutings> GetEventList()
        {
            return _listOfEvents;
        }
        public void AddToEventList(KomodoOutings outings)
        {
            _listOfEvents.Add(outings);
        }
        public decimal EventCostsList(KomodoOutings outing)
        {
            decimal total = 0m;
            switch (outing.EventType)
            {
                case EventType.Golf:
                    total += outing.CostForEvent + outing.CostPerPerson * outing.PeopleAttended;
                    break;
                case EventType.Bowling:
                    total += outing.CostForEvent + outing.CostPerPerson * outing.PeopleAttended;
                    break;
                case EventType.AmusementPark:
                    total += outing.CostForEvent + outing.CostPerPerson * outing.PeopleAttended;
                    break;
                case EventType.Concert:
                    total += outing.CostForEvent + outing.CostPerPerson * outing.PeopleAttended;
                    break;
                default:
                    break;
            }
            return total;
        }
        public decimal AllEventCostList()
        {
            decimal total = 0m;
            foreach (KomodoOutings outing in _listOfEvents)
            {
                total += outing.CostForEvent + outing.CostPerPerson * outing.PeopleAttended;
            }
            return total;
        }
    }
}
