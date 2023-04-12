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
        public Contact model = new();
        public static async void AddContact()
        {
            var dbContext = new PhonebookDbContext();

            Console.WriteLine("Enter the name of the contact: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the phone number of the contact: ");
            string phoneNumber = Console.ReadLine();

            var contactObject = new Contact();
            contactObject.Name = name;
            contactObject.PhoneNumber = phoneNumber;

            dbContext.Contacts.Add(contactObject);
            _ = await dbContext.SaveChangesAsync();
        }
        public static void UpdateContact()
        {
            using (var db = new PhonebookDbContext())
            {
                Console.WriteLine("Type the Id of the Contact you wish to edit or press 'q' to view all contacts.");
                string input = Console.ReadLine();
                string idOfContact = "1";
                switch (input)
                {
                    case "q":
                        ViewContact();
                        UpdateContact();
                        break;
                    default:
                        idOfContact = input;
                        break;
                }
                var contact = db.Contacts.Where(c => c.Id == Convert.ToInt32(idOfContact)).FirstOrDefault();
                
                Console.WriteLine("Which field do you want to update? (Name = 1 or PhoneNumber = 2)");
                string field = Console.ReadLine();
                switch (field)
                {
                    case "1":
                        Console.WriteLine("Enter the new name:");
                        string newName = Console.ReadLine();
                        string oldName = contact.Name;
                        contact.Name = newName;
                        Console.WriteLine($"Name updated from {oldName} to {newName}.");
                        break;
                    case "2":
                        Console.WriteLine("Enter the updated phonenumber");
                        string newPhone = Console.ReadLine();
                        string oldPhone = contact.PhoneNumber;
                        contact.PhoneNumber = newPhone;
                        Console.WriteLine($"Phonenumber updated from {oldPhone} to {newPhone}");
                        break;
                    default:
                        Console.WriteLine("You f'ed up, start over!");
                        UpdateContact();
                        break;
                }
                db.SaveChanges();

            }
        }
        public static void ViewContact()
        {
            var dbContext = new PhonebookDbContext();
            List<Contact> contacts = new List<Contact>();

            using (var db = new PhonebookDbContext())
            {
                contacts = db.Contacts.ToList();

                Console.WriteLine($"ID         | Name       | Phone number " );
                for (int i = 0; i < contacts.Count; i++)
                {
                    Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2, -10}", contacts[i].Id, contacts[i].Name, contacts[i].PhoneNumber));
                }
            }
        }
        public static void DeleteContact()
        {

            using (var db = new PhonebookDbContext())
            {
                Console.WriteLine("Select the Id of the user you wish to delete: ");
                ViewContact();
                Console.WriteLine();
                string removeId = Console.ReadLine();

                var contact = db.Contacts.Where(c => c.Id == Convert.ToInt32(removeId)).FirstOrDefault();
                _ = db.Remove(contact);
                db.SaveChanges();
            }
        }
    }
}
