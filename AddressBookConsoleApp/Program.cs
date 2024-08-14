using AddressBookConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();
            string choice;

            do
            {
                Console.WriteLine("\nAddress Book Menu:");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Read All Contacts");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Update Contact");
                Console.WriteLine("5. Read Contact By Id");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddContact(addressBook);
                        break;
                    case "2":
                        addressBook.ReadAllContacts();
                        break;
                    case "3":
                        DeleteContact(addressBook);
                        break;
                    case "4":
                        UpdateContact(addressBook);
                        break;
                    case "5":
                        ReadContactById(addressBook);
                        break;
                    case "6":
                        Console.WriteLine("\nExiting...");
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice. Please try again.");
                        break;
                }
            } while (choice != "6");

        }
        //add-contact
        static void AddContact(AddressBook addressBook)
        {
            Console.Write("\nEnter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            Console.Write("Enter address: ");
            string address = Console.ReadLine();

            Contact contact = new Contact(name, phoneNumber, email, address);

            addressBook.AddContact(contact);
        }

        //delete-by-name
        /*static void DeleteContact(AddressBook addressBook)
        {
            Console.WriteLine("\nEnter the name of the contact to be deleted: ");
            string name = Console.ReadLine();

            addressBook.DeleteContact(name);
        }*/

        //delete-by-Id
        static void DeleteContact(AddressBook addressBook)
        {
            Console.WriteLine("\nEnter the Id of the contact to be deleted: ");
            int contactId = Convert.ToInt32(Console.ReadLine());

            addressBook.DeleteContact(contactId);
        }

        //update-by-Id
        static void UpdateContact(AddressBook addressBook)
        {
            Console.WriteLine("\nEnter the Id of the contact which is to be updated");
            int contactId = Convert.ToInt32(Console.ReadLine());

            addressBook.UpdateContact(contactId);
        }

        static void ReadContactById(AddressBook addressBook)
        {
            Console.WriteLine("\nEnter the Id. To view contact details");
            int contactId = Convert.ToInt32(Console.ReadLine());

            addressBook.ReadContactById(contactId);
        }
    }
}