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
            //creating object 
            AddContact addContact = new AddContact();

            //taking user input
            Console.WriteLine("Enter Firstname ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter Lastname ");
            string lastname = Console.ReadLine();

            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter City");
            string city = Console.ReadLine();

            Console.WriteLine("Enter State");
            string state = Console.ReadLine();

            Console.WriteLine("Enter pincode");
            int pincode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter PhoneNumber ");
            long phone = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();

            //calling method
            addContact.CreateContact(firstname,lastname,address,city,state,pincode,phone,email);
            
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
