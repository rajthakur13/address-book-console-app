using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookConsoleApp
{
    internal class AddressBook
    {
        private List<Contact> contacts;

        public AddressBook()
        {
            contacts = new List<Contact>();
        }

        //add-contact
        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
            Console.WriteLine("\nContact added successfully.");
        }

        //read-all-contacts
        public void ReadAllContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("\nNo Contacts available.");
            }
            else
            {
                foreach (var contact in contacts)
                {
                    Console.WriteLine("\n---------------------------------------------------");
                    Console.WriteLine("\nId: " + contact.Id + "\nName: " + contact.Name + "\nPhone Number: " + contact.PhoneNumber + "\nEmail: " + contact.Email + "\nAddress: " + contact.Address);
                    //Console.WriteLine("\n---------------------------------------------------");
                }
                Console.WriteLine("\n---------------------------------------------------");
            }
        }

        //delete-by-name
        /* public void DeleteContact(string name)
         {
             var contactToRemove = contacts.FirstOrDefault(c => c.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase)); //OrdinalIgnoreCase

             if (contactToRemove != null)
             {
                 contacts.Remove(contactToRemove);
                 Console.WriteLine("\nContact removed successfully.");
             }
             else
             {
                 Console.WriteLine("\nContact not found.");
             }
         }*/

        //delete-by-Id
        public void DeleteContact(int contactId)
        {
            var contactToRemove = contacts.Find(c => c.Id == contactId);

            if (contactToRemove != null)
            {
                contacts.Remove(contactToRemove);
                Console.WriteLine("\nContact removed successfully.");
            }
            else
            {
                Console.WriteLine("\nContact not found.");
            }
        }

        public void UpdateContact(int contactId)
        {
            var contactToUpdate = contacts.Find(c => c.Id == contactId);

            if (contactToUpdate != null)
            {
                Console.Write("\nEnter new name or press enter to skip: ");
                string newName = Console.ReadLine();
                Console.Write("Enter new phone number or press enter to skip: ");
                string newPhoneNumber = Console.ReadLine();
                Console.Write("Enter new email or press enter to skip: ");
                string newEmail = Console.ReadLine();
                Console.Write("Enter new address or press enter to skip: ");
                string newAddress = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(newName))
                {
                    contactToUpdate.Name = newName;
                }

                if (!string.IsNullOrWhiteSpace(newPhoneNumber))
                {
                    contactToUpdate.PhoneNumber = newPhoneNumber;
                }

                if (!string.IsNullOrWhiteSpace(newEmail))
                {
                    contactToUpdate.Email = newEmail;
                }

                if (!string.IsNullOrWhiteSpace(newAddress))
                {
                    contactToUpdate.Address = newAddress;
                }

                Console.WriteLine("\nContact updated successfully.");
            }
            else
            {
                Console.WriteLine("\nContact not found.");
            }
        }

        public void ReadContactById(int contactId)
        {
            var contactToRead = contacts.Find(c => c.Id == contactId);

            if (contactToRead != null)
            {

            }

        }
    }
}
