using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge_Repository
{
    public enum EventType
    {
        Golf = 1, Bowling, AmusementPark, Concert
    }
    public class KomodoOutings
    {
        public EventType EventType { get; set; }
        public int PeopleAttended { get; set; }
        public DateTime Date { get; set; }
        public decimal CostPerPerson { get; set; }
        public decimal CostForEvent { get; set; }
        public decimal TotalCostForEvent { get; set; }
        public KomodoOutings() {  }
        public KomodoOutings(EventType eventType, int peopleAttended, DateTime date, decimal costPerPerson, decimal costForEvent)
        {
            EventType = eventType;
            PeopleAttended = peopleAttended;
            Date = date;
            CostPerPerson = costPerPerson;
            CostForEvent = costForEvent;
        }
    }
}
