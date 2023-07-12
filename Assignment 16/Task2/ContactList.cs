using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ContactList
    {
        public List<Contact> _contacts;

        public ContactList()
        {
            _contacts = new List<Contact>();
        }

        public void AddContact(string firstName, string LastName, int age)
        {
            var contact = new Contact
            {
                FirstName = firstName,
                LastName = LastName,
                Age = age
            };
            _contacts.Add(contact);
        } 

        public void RemoveContact(Contact contact)
        {
            _contacts.Remove(contact);
        }

        public void GetContacts()
        {
            foreach(Contact contact in _contacts)
            {
                Console.WriteLine($"FirstName - {contact.FirstName}" + '\n' +
                    $"LastName - {contact.LastName}" + '\n' +
                    $"Age - {contact.Age}"
                    );
            }
        }
    }
}
