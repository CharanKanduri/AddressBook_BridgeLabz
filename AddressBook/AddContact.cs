using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddContact
    {
        //instance variables 
        public string firstName;
        public string lastName;
        public string Address;
        public string city;
        public string state;
        public int zip;
        public long phoneNumber;
        public string email;
        public int n = 1;
        public int contact = 0;

        public AddContact[] addContactArray;
        int i = 0;

        //Created a parameterised constructor
        public AddContact(string firstName, string lastName, string Address, string city, string state, int zip, long phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Address = Address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;


        }
        //default constructor
        public AddContact()
        {
            this.addContactArray = new AddContact[10];
        }


        public void CreateContact(string firstName, string lastName, string Address, string city, string state, int zip, long phoneNumber, string email)
        {
            addContactArray[this.contact] = new AddContact( firstName,  lastName,  Address,  city,  state,  zip,  phoneNumber,  email);

            Console.WriteLine("First name: {0}\n Last name: {1}\n Address: {2}\n City: {3}\n Zip: {4}\n State: {5}\n Phone Number: {6}\n Email: {7} \n", addContactArray[i].firstName, addContactArray[i].lastName, addContactArray[i].Address, addContactArray[i].city, addContactArray[i].zip, addContactArray[i].state, addContactArray[i].phoneNumber, addContactArray[i].email);

        }
        
        
    }


}
