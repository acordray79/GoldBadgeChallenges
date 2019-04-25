using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Challenge_Repository
{
    public enum CustomerType
    {
        Potential = 1, Current, Past
    }
    public class Crud
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CustomerType CustomerType { get; set; }
        public Crud() {  }
        public Crud(int customerID, string firstName, string lastName, CustomerType customerType)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            CustomerType = customerType;
        }
    }
}
