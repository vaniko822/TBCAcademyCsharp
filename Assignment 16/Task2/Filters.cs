using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task2
{
    public class Filters
    {
        public static void FilterFirstName(string firstName, List<Contact> contacts)
        {
            var firstname = firstName.ToLower();
            for(int i = 0; i < contacts.Count; i++)
            {
                var contact = contacts[i];
                if (firstname == contact.FirstName.ToLower())
                {
                    Console.WriteLine($"FirstName - {contact.FirstName}" + '\n' +
                        $"LastName - {contact.LastName}" + '\n' +
                        $"Age - {contact.Age}"
                        );
                }
            }
        }

        public static void FilterLastName(string lastName, List<Contact> contacts)
        {
            var lastname = lastName.ToLower();
            for (int i = 0; i < contacts.Count; i++)
            {
                var contact = contacts[i];
                if (lastname == contact.LastName.ToLower())
                {
                    Console.WriteLine($"FirstName - {contact.FirstName}" + '\n' +
                        $"LastName - {contact.LastName}" + '\n' +
                        $"Age - {contact.Age}"
                        );
                }
            }
        }

        public static void FilterFullName(string firstName, string lastName, List<Contact> contacts)
        {
            var firstname = firstName.ToLower();
            var lastname = lastName.ToLower();
            for (int i = 0; i < contacts.Count; i++)
            {
                var contact = contacts[i];
                if (firstname == contact.FirstName.ToLower() && lastname == contact.LastName.ToLower())
                {
                    Console.WriteLine($"FirstName - {contact.FirstName}" + '\n' +
                        $"LastName - {contact.LastName}" + '\n' +
                        $"Age - {contact.Age}"
                        );
                }
            }
        }

        public static void FilterAge(int age, List<Contact> contacts) 
        {
            var contactAge = age;
            for (int i = 0; i < contacts.Count; i++)
            {
                var contact = contacts[i];
                if (age == contact.Age)
                {
                    Console.WriteLine($"FirstName - {contact.FirstName}" + '\n' +
                        $"LastName - {contact.LastName}" + '\n' +
                        $"Age - {contact.Age}"
                        );
                }
            }
        }
    }
}
