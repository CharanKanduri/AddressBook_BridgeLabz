using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBook
{
    class Program
    {   
    
        static void Main(string[] args)
        {   
            Console.WriteLine("Welcome to AddressBook Program !");

            AddContact addContact = new AddContact();
                
            addContact.CreateContact("CHARAN", "Kanduri", "Saraswathi Nagar", "Nellore", "AP", 524002, 9398100236, "example@gmail.com");
            addContact.CreateContact("Srikar", "Kanduri", "Saraswathi Nagar", "Nellore", "AP", 524002, 8189994011, "examplesrikar@gmail.com");
        }
       public void Display(AddContact[] addContactArray, int n)
        {
            int i = 0;

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("First name: {0}\n Last name: {1}\n Address: {2}\n City: {3}\n Zip: {4}\n State: {5}\n Phone Number: {6}\n Email: {7} \n",addContactArray[i].firstName, addContactArray[i].lastName, addContactArray[i].Address, addContactArray[i].city, addContactArray[i].zip, addContactArray[i].state, addContactArray[i].phoneNumber, addContactArray[i].email);
            }
        }
    }
}
