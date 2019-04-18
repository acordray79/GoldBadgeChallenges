using _02_Challenge_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge_Challenge
{
    public class ProgramUI
    {
        private KomodoClaimsRepository _claimRepo = new KomodoClaimsRepository();
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
                Console.WriteLine("Please input option number you wish to use.\n" +
                    "1: See all claims.\n" +
                    "2: See next claim.\n" +
                    "3: Add new claim.\n" +
                    "4: Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        SeeAllClaims();
                        break;
                    case "2":
                        GetNextClaim();
                        break;
                    case "3":
                        AddNewClaim();
                        break;
                    case "4":
                        running = false;
                        break;

                }
            }
        }
        private void SeeAllClaims()
        {
            Queue<KomodoClaims> list = _claimRepo.GetAllQueue();
            foreach (KomodoClaims content in list)
            {
                Console.WriteLine($"ClaimID     Claim Type      Description                Claim Ammount       Date Of Incident        Date of Claim       Is Valid\n{content.ClaimID}     {content.ClaimType}     {content.Description}                {content.ClaimAmount}       {content.DateOfIncident}        {content.DateOfClaim}       {content.IsValid}");
            }
            Console.ReadLine();
        }
        private void GetNextClaim()
        {
            KomodoClaims list = _claimRepo.PeekNextContent();

            Console.WriteLine($"Here are the details for the next claim to be handled\n" +
                $"ClaimID: {list.ClaimID}\n" +
                $"Type: {list.ClaimType}\n" +
                $"Description: {list.Description}\n" +
                $"Amount: {list.ClaimAmount}\n" +
                $"Date Of Incident: {list.DateOfIncident}\n" +
                $"Date Of Claim: {list.DateOfClaim}\n" +
                $"IsValid: {list.IsValid}\n" +
                $"Would you like to take this claim? (Y/N)");
            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "y":
                case "yes":
                    KomodoClaims list2 = _claimRepo.GetNextContent();
                    break;
                default:
                    break;
            }
        }
        private void AddNewClaim()
        {
            Console.WriteLine("What is the claim ID?");
            int claimID = int.Parse(Console.ReadLine());
            Console.WriteLine("What is claim type number?\n" +
                "1: Car\n" +
                "2: Home\n" +
                "3: Theft");
            int claim = int.Parse(Console.ReadLine());
            ClaimType claimType = (ClaimType)claim;
            Console.WriteLine("Input description of claim.");
            string description = Console.ReadLine();
            Console.WriteLine("What is claim monitary amount in decimal format.");
            decimal claimAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("What was the date of the incident? (YYYY/MM/DD)");
            DateTime incidentDateTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("What was the date of the claim? (YYYY/MM/DD)");
            DateTime claimDateTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Is this a valid claim? (Y/N)" );
            string validAsString = Console.ReadLine().ToLower();
            bool isValid = false;

            switch (validAsString)
            {
                case "y":
                case "yes":
                    isValid = true;
                    break;
                case "n":
                case "no":
                    isValid = false;
                    break;
            }
                    KomodoClaims newContent = new KomodoClaims(claimID, claimType, description, claimAmount, incidentDateTime, claimDateTime, isValid);
            _claimRepo.AddToQueue(newContent);
        }
    }
}
