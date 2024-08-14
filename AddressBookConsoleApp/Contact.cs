using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookConsoleApp
{
    internal class Contact
    {
        private static int nextId = 1;
        public int Id { get; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Contact(string name, string phoneNumber, string email, string address)
        {
            this.Id = nextId++;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Address = address;
        }
    }
}
