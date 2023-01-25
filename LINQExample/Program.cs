using System;
using System.Collections.Generic;

namespace LINQExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contacts> contacts = new List<Contacts>()
            { 
                //insert the contacts in address book
                new Contacts(){FirstName="Rita",LastName="Mehta",Address="Indore",City="Indore",State="Madhya Pradesh",Zip="456010",PhoneNumber="8896564552",email="rita@gmail.com"},
                new Contacts(){FirstName="Riya",LastName="Sharma",Address="Ujjain",City="Ujjain",State="Madhya Pradesh",Zip="456661",PhoneNumber="8569741526",email="riya@gmail.com"},
                new Contacts(){FirstName="Ajay",LastName="Sharma",Address="Indore",City="Indore",State="Madhya Pradesh",Zip="456010",PhoneNumber="9927845621",email="ajay@gmail.com"},
                new Contacts(){FirstName="Vijay",LastName="Vyas",Address="Ujjain",City="Ujjain",State="Madhya Pradesh",Zip="456661",PhoneNumber="6261563458",email="vijay@gmail.com"},
                new Contacts(){FirstName="Mohan",LastName="Dube",Address="Pune",City="Pune",State="Maharastra",Zip="456601",PhoneNumber="1234567890",email="mohan@gmail.com"},

            };

            /*
             foreach (Contacts contact in contacts)
             {
                Console.WriteLine("First Name : " + contact.FirstName + " Last Name : " + contact.LastName + " Address : " + contact.Address
                    + " City : " + contact.City + " State : " + contact.State + " Zip : " + contact.Zip + " Phone Number : " + contact.PhoneNumber
                    + " Email : " + contact.email);
            
             }*/

            AddressBook addressBook = new AddressBook();

            //edit existing contact person
            addressBook.UpdateContact(contacts);


            //delete a person using person's name
            addressBook.DeleteContact(contacts);


            //Retrieve Person belonging to a City or State from the Address Book
            addressBook.RetrievePerson(contacts);


            //understand the size of address book by City 
            addressBook.SizeOfAddressBookByCity(contacts);


            //understand the size of address book by State
            addressBook.SizeOfAddressBookByState(contacts);

            //retrieve entries sorted alphabetically by Person’s name for a given city
            addressBook.RetrieveEntries(contacts);
        }
    }
}
