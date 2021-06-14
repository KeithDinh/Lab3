using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseholdAccounts householdAccounts = new HouseholdAccounts();
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine("-------------------------");
                Console.WriteLine("Household Account");
                Console.WriteLine("1. Add new expense\n2. Show all expenses\n3. Search\n4. Modify a tab\n5. Delete\n6. Sort\n7. Normalize Description\n8. Enter to exit");
                Console.WriteLine("Select an option to continue: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        householdAccounts.Add();
                        break;
                    case 2:
                        householdAccounts.ShowAll();
                        break;
                    case 3:
                        householdAccounts.Search();
                        break;
                    case 4:
                        householdAccounts.Modify();
                        break;
                    case 5:
                        householdAccounts.Delete();
                        break;
                    case 6:
                        householdAccounts.Sort();
                        break;
                    case 7:
                        householdAccounts.Normalize();
                        break;
                    default:
                        flag = false;
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
