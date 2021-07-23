using System;
using System.Collections.Generic;
using System.Linq;

namespace Address_Book
{
    public class AddressBookSystem
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
        public List<AddressBookSystem> ContactArray;
        int contact = 0;

        //Parameterised Constructor
        public AddressBookSystem(string firstName, string lastName, string Address, string city, string state, int zip, long phoneNumber, string email)
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
        //Default Contructor
        public AddressBookSystem()
        {
            this.ContactArray = new List<AddressBookSystem>();
        }

        //To add Contact to Address Book
        public void CreateContact(string firstName, string lastName, string Address, string city, string state, int zip, long phoneNumber, string email)
        {
            //Newly add element to List
            if (contact == 0)
            {
                ContactArray.Add(new AddressBookSystem(firstName, lastName, Address, city, state, zip, phoneNumber, email));
                contact++;
                ContactPerson obj = new ContactPerson();
                obj.Display(ContactArray, contact);

            }
            else if (contact != 0)
            {
                //Check if element already present in List
                AddressBookSystem addressBookSystems = ContactArray.Find(x => x.firstName.Equals(firstName));
                if (addressBookSystems == null)
                {
                    ContactArray.Add(new AddressBookSystem(firstName, lastName, Address, city, state, zip, phoneNumber, email));
                    contact++;
                    ContactPerson obj = new ContactPerson();
                    obj.Display(ContactArray, contact);
                }
                else
                {
                    Console.WriteLine("This person already exists in your AddressBook!");
                }

            }
        }
        //Function call To modify
        public void Modify()
        {
            //User enters field to Modify
            int i = 0;
            Console.WriteLine("-------To Modify-------\nEnter first name of user that needs modification");
            string name = Console.ReadLine();

            //Traverse till the desired index
            while (ContactArray[i].firstName != name)
            {
                i++;
            }

            Console.WriteLine("Enter field to be modified 1.firstName 2.lastName 3.Address 4.city 5.state 6.zip 7.phoneNumber 8.email 9.Delete a contact");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter the modified value");
                    string fn = Console.ReadLine();
                    ContactArray[i].firstName = fn;
                    break;
                case 2:
                    Console.WriteLine("Enter the modified value");
                    string ls = Console.ReadLine();
                    ContactArray[i].lastName = ls;
                    break;
                case 3:
                    Console.WriteLine("Ente the modified value");
                    string add = Console.ReadLine();
                    ContactArray[i].Address = add;
                    break;
                case 4:
                    Console.WriteLine("Enter the modified value");
                    string cities = Console.ReadLine();
                    ContactArray[i].city = cities;
                    break;
                case 5:
                    Console.WriteLine("Enter the modified value");
                    string states = Console.ReadLine();
                    ContactArray[i].state = states;
                    break;
                case 6:
                    Console.WriteLine("Enter the modified value");
                    int temp = Convert.ToInt32(Console.ReadLine());
                    ContactArray[i].zip = temp;
                    break;
                case 7:
                    Console.WriteLine("Ente the modified value");
                    int phn = Convert.ToInt32(Console.ReadLine());
                    ContactArray[i].phoneNumber = phn;
                    break;
                case 8:
                    Console.WriteLine("Ente the modified value");
                    string emails = Console.ReadLine();
                    ContactArray[i].email = emails;
                    break;
                //Delete a user
                case 9:
                    ContactArray = ContactArray.Take(i).Concat(ContactArray.Skip(i + 1)).ToList();
                    contact--;
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            //Display Function
            ContactPerson obj = new ContactPerson();
            obj.Display(ContactArray, contact);
        }
    }
}