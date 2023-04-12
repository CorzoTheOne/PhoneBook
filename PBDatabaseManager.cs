using PhoneBook.Data;
using PhoneBook.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class PBDatabaseManager
    {
        public static async void AddContact()
        {
            var dbContext = new PhonebookDbContext();

            Console.WriteLine("Enter the name of the contact: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the phone number of the contact: ");
            string phoneNumber = Console.ReadLine();

            var contactObject = new Contact(name, phoneNumber);

            dbContext.Contacts.Add(contactObject);
            _ = await dbContext.SaveChangesAsync();
        }
        public static void UpdateContact()
        {

        }
        public static void ViewContact()
        {

        }
        public static void DeleteContact()
        {

        }
    }
}
