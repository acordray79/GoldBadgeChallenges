using _05_Challenge_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Challenge_Console
{
    public class ProgramUI
    {
        private Crud_Repository _customerRepo = new Crud_Repository();
        Dictionary<int, string> _customerType = new Dictionary<int, string>
        {
               { 1, "It's been a long time since we've heard from you, we want you back" },
               { 2, "Thank you for your work with us. We appreciate your loyalty. Here's a coupon." },
               { 3, "We currently have the lowest rates on Helicopter Insurance!" }
        };
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
                    "1: Add a customer.\n" +
                    "2: Edit a customer.\n" +
                    "3: Read a customer.\n" +
                    "4: Show all customer info.\n" +
                    "5: Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddACustomer();
                        break;
                    case "2":
                        EditACustomer();
                        break;
                    case "3":
                        ShowACustomer();
                        break;
                    case "4":
                        ShowAllCustomer();
                        break;
                    case "5":
                        running = false;
                        break;
                }
            }
        }
        private void AddACustomer()
        {
            Console.WriteLine("What is the customers ID number?");
            int customerID = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the customers first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is the customers last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("What number best describes the customer?\n" +
                "1: Potential\n" +
                "2: Current\n" +
                "3: Past");
            int customer = int.Parse(Console.ReadLine());
            CustomerType customerType = (CustomerType)customer;

            Crud newCustomer = new Crud(customerID, firstName, lastName, customerType);
            _customerRepo.AddCustomerToEmailList(newCustomer);
        }
        private void EditACustomer()
        {
            Console.WriteLine("What is the customers ID?");
            int customerID = int.Parse(Console.ReadLine());
            Console.WriteLine("What number value would you like to change?\n" +
                "1: First Name\n" +
                "2: Last Name\n" +
                "3: Customer Type");
            string customerChange = (Console.ReadLine());
            switch (customerChange)
            {
                case "1":
                    Console.WriteLine("What is the new first name?");
                    string firstName = Console.ReadLine();
                    foreach(Crud crud in _customerRepo.GetAllCustomerInfo())
                    {
                        if(crud.CustomerID == customerID)
                        {
                            crud.FirstName = firstName;
                        }
                    }
                    //change first name
                    break;
                case "2":
                    Console.WriteLine("What is the new last name?");
                    string lastName = Console.ReadLine();
                    foreach (Crud crud in _customerRepo.GetAllCustomerInfo())
                    {
                        if (crud.CustomerID == customerID)
                        {
                            crud.LastName = lastName;
                        }
                    }
                    // change last name
                    break;
                case "3":
                    Console.WriteLine("What is the new customer type?\n" +
                        "1: Potential\n" +
                        "2: Current\n" +
                        "3: Past");
                    int cType = int.Parse(Console.ReadLine());
                    CustomerType customerType = (CustomerType)cType;
                    foreach (Crud crud in _customerRepo.GetAllCustomerInfo())
                    {
                        if (crud.CustomerID == customerID)
                        {
                            crud.CustomerType = customerType;
                        }
                    }
                    // change customer type
                    break;
            }
        }
        private void ShowACustomer()
        {
            Console.WriteLine("What is the customer ID you want to see?");
            int customerID = int.Parse(Console.ReadLine());
            Crud crud = _customerRepo.GetCustomerInfo(customerID);
            Console.WriteLine($"{crud.CustomerID} {crud.LastName} {crud.FirstName} {crud.CustomerType} {_customerType[(int)crud.CustomerType]}");
            Console.ReadLine();
            
        }
        private void ShowAllCustomer()
        {
            foreach(Crud crud in _customerRepo.GetAllCustomerInfo())
            {
                Console.WriteLine($"{crud.CustomerID} {crud.LastName} {crud.FirstName} {crud.CustomerType} {_customerType[(int)crud.CustomerType]}");
            }
            Console.ReadLine();
        }
    }
}
