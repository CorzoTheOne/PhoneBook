using PhoneBook;
using PhoneBook.Data;
using PhoneBook.Data.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Select an action: ");
            Console.WriteLine("1: Add a contact");
            Console.WriteLine("2: View contacts");
            Console.WriteLine("3: Update a contact");
            Console.WriteLine("4: Delete a contact");
            Console.WriteLine("5: Exit");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    PBDatabaseManager.AddContact();
                    break;
                case "2":
                    PBDatabaseManager.ViewContact();
                    break;
                case "3":
                    PBDatabaseManager.UpdateContact();
                    break;
                case "4":
                    PBDatabaseManager.DeleteContact();
                    break;
                case "5":
                    Environment.Exit(200);
                    break;
                default:
                    continue;
            }
        }
    }
}