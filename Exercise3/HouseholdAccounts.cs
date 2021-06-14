using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Exercise3
{
    class HouseholdAccounts
    {
        private List<Transaction> transactions = new List<Transaction>();
        public void Add()
        {
            Console.Write("Enter Date: ");
            string dateString = Console.ReadLine();
            while (!ValidateDate(dateString))
            {
                Console.Write("Please correct date format (YYYYMMDD): ");
                dateString = Console.ReadLine();
            }
            DateTime d = DateTime.ParseExact(dateString, "yyyyMMdd", CultureInfo.InvariantCulture);
            Console.Write("Enter Description: ");
            string description = Console.ReadLine();
            while(description.Length == 0)
            {
                Console.Write("Description can't be blank. Please provide a description: ");
                description = Console.ReadLine();
            }
            Console.Write("Enter Amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            Transaction tran = new Transaction(d, description, amount);
            transactions.Add(tran);
            Console.WriteLine("------");
            PrintTransaction(tran);
        }
        private bool ValidateDate(string dateString) {
            bool flag = true;
            try
            {
                DateTime d = DateTime.ParseExact(dateString, "yyyyMMdd", CultureInfo.InvariantCulture);
                DateTime validStart = new DateTime(1000, 01, 01);
                DateTime validEnd = new DateTime(3000, 12, 31);
                if(d < validStart || d > validEnd)
                {
                    flag = false;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                flag = false;
            }
            return flag;
        }
        private void PrintTransaction(Transaction trans)
        {
            Console.WriteLine($"Date: {trans.Date.ToString("dd / MM / yyyy")}");
            Console.WriteLine($"Description: {trans.Description}");
            Console.WriteLine($"Category: \"{trans.Category}\"");
            Console.WriteLine($"Amount: \"{Math.Round(trans.Amount, 2)}\"");
        }
        public void ShowAll()
        {
            Console.Write("Enter start date (YYYYMMDD): ");
            DateTime d1 = DateTime.ParseExact(Console.ReadLine(), "yyyyMMdd", CultureInfo.InvariantCulture);
            Console.Write("Enter end date (YYYYMMDD): ");
            DateTime d2 = DateTime.ParseExact(Console.ReadLine(), "yyyyMMdd", CultureInfo.InvariantCulture);

            for(int i=0; i<transactions.Count; i++)
            {
                if(transactions[i].Date > d1 && transactions[i].Date < d2) {
                    Console.WriteLine($"Number: {i}");
                    PrintTransaction(transactions[i]);
                    Console.WriteLine("------");
                }
            }
        }
        public void Delete()
        {
            Console.Write("Enter the transaction number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number > transactions.Count || number < 0)
            {
                Console.WriteLine("Invalid number.");
                return;
            }

            Console.WriteLine($"Number: {number}");
            PrintTransaction(transactions[number]);
            Console.WriteLine("------");
            Console.Write("Please confirm to delete the transaction (y/n): ");
            if(Console.ReadLine().ToLower() == "y")
            {
                transactions.RemoveAt(number);
                Console.WriteLine("Successfully Deleted!!!");
                return;
            }
        }
        public void Modify( )
        {
            Console.Write("Enter the transaction number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > transactions.Count || number < 0)
            {
                Console.WriteLine("Invalid number.");
                return;
            }
            Console.WriteLine($"Number: {number}");
            PrintTransaction(transactions[number]);
            Console.WriteLine("------");
            Console.Write("Please choose field to update (1-Date 2-Description 3-Amount 4-Exit: ");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.Write("Enter new date: ");
                    transactions[number].Date = DateTime.ParseExact(Console.ReadLine(), "yyyyMMdd", CultureInfo.InvariantCulture);
                    break;
                case 2:
                    Console.Write("Enter new description: ");
                    transactions[number].Description = Console.ReadLine();
                    break;
                case 3:
                    Console.Write("Enter new Amount: ");
                    transactions[number].Amount = Convert.ToDecimal(Console.ReadLine());
                    transactions[number].Category = (transactions[number].Amount >= 0) ? "Income" : "Expense";
                    break;
                default:
                    break;
            }
            Console.WriteLine("------");
            Console.WriteLine($"Number: {number}");
            PrintTransaction(transactions[number]);
            Console.WriteLine("------");

        }
        public void Sort()
        {
            transactions = transactions.OrderBy(x => x.Date).ThenBy(x => x.Description).ToList();
            Console.WriteLine("Sort successfully!!!");
        }
        public void Normalize()
        {
            for(int i=0; i<transactions.Count; i++)
            {
                transactions[i].Description = Regex.Replace(transactions[i].Description, @"\s+", " ").Trim();
                transactions[i].Description = Char.ToUpper(transactions[i].Description[0]) + transactions[i].Description.Substring(1).ToLower();
            }
        }

        public void Search()
        {
            Console.WriteLine("Enter text to search: ");
            string text = Console.ReadLine();
            for(int i=0; i<transactions.Count; i++)
            {
                if(transactions[i].Description.ToLower().Contains(text.ToLower()) || transactions[i].Category.ToLower().Contains(text.ToLower()))
                {
                    Console.WriteLine($"Number: {i}");
                    PrintTransaction(transactions[i]);
                    Console.WriteLine("------");
                }
            }
        }

    }
}
