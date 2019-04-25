using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Challenge_Repository
{
    public class Crud_Repository
    {
        private List<Crud> _listOfCustomer = new List<Crud>();
        //Dictionary<int, string> _customerType = new Dictionary<int, string>
        //{
        //       { 1, "It's been a long time since we've heard from you, we want you back" },
        //       { 2, "Thank you for your work with us. We appreciate your loyalty. Here's a coupon." },
        //       { 3, "We currently have the lowest rates on Helicopter Insurance!" }
        //};
        public void AddCustomerToEmailList(Crud email)
        {
            _listOfCustomer.Add(email);
        }
        public Crud GetCustomerInfo(int customerID)
        {
            foreach(Crud crud in _listOfCustomer)
            {
                if(crud.CustomerID == customerID)
                {
                    return crud;
                }
            }
            return null;
        }
        public List<Crud> GetAllCustomerInfo()
        {
            return _listOfCustomer.OrderBy(crud => crud.LastName).ThenBy(crud => crud.FirstName).ToList();
        }

    }
}
