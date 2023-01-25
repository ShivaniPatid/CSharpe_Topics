using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LINQExample
{
    internal class AddressBook
    {
        public readonly DataTable dataTable = new DataTable();

        //edit existing contact person
        public void UpdateContact(List<Contacts> contactList)
        {
            var data = contactList.Where(s => s.FirstName == "Mohan").Select(s => { { s.Address = "Mumbai"; } { s.City = "Mumbai"; } { s.Zip = "456601"; } return s; });


            foreach (var contact in data)
            {
                Console.WriteLine("First Name : " + contact.FirstName + " Last Name : " + contact.LastName + " Address : " + contact.Address
                    + " City : " + contact.City + " State : " + contact.State + " Zip : " + contact.Zip + " Phone Number : " + contact.PhoneNumber
                    + " Email : " + contact.email);
            }
        }

        //delete a person using person's name
        public void DeleteContact(List<Contacts> contactList)
        {
            var data = contactList.Where(x => x.FirstName != "Mohan").ToList();

            foreach (var contact in data)
            {
                Console.WriteLine("First Name : " + contact.FirstName + " Last Name : " + contact.LastName + " Address : " + contact.Address
                    + " City : " + contact.City + " State : " + contact.State + " Zip : " + contact.Zip + " Phone Number : " + contact.PhoneNumber
                    + " Email : " + contact.email);
            }
        }

        //Retrieve Person belonging to a City or State from the Address Book
        public void RetrievePerson(List<Contacts> contactList)
        {
            var data = from listContact in contactList
                       where (listContact.City == "Indore" && listContact.State == "Madhya Pradesh")
                       select listContact;
            foreach (var contact in data)
            {
                Console.WriteLine("First Name : " + contact.FirstName + " Last Name : " + contact.LastName + " Address : " + contact.Address
                    + " City : " + contact.City + " State : " + contact.State + " Zip : " + contact.Zip + " Phone Number : " + contact.PhoneNumber
                    + " Email : " + contact.email);
            }
        }

        //understand the size of address book by City 

        public void SizeOfAddressBookByCity(List<Contacts> contactList)
        {
            var data = contactList.GroupBy(x => x.City).Select(x => new { City = x.Key, Count = x.Count() });
            foreach (var contact in data)
            {
                Console.WriteLine(contact.City + "------" + contact.Count);
            }
        }

        //understand the size of address book by State

        public void SizeOfAddressBookByState(List<Contacts> contactList)
        {
            var data = contactList.GroupBy(x => x.State).Select(x => new { State = x.Key, Count = x.Count() });
            foreach (var contact in data)
            {
                Console.WriteLine(contact.State + "------" + contact.Count);
            }
        }

        //retrieve entries sorted alphabetically by Person’s name for a given city

        public void RetrieveEntries(List<Contacts> contactList)
        {
            var data = contactList.OrderBy(city => city.City).ThenBy(name => name.FirstName);
            foreach (var contact in data)
            {
                Console.WriteLine("First Name : " + contact.FirstName + " Last Name : " + contact.LastName + " Address : " + contact.Address
                    + " City : " + contact.City + " State : " + contact.State + " Zip : " + contact.Zip + " Phone Number : " + contact.PhoneNumber
                    + " Email : " + contact.email);
            }
        }



    }
}
