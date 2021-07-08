using System;
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
        public AddressBookSystem[] ContactArray;
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
            this.ContactArray = new AddressBookSystem[10];
        }

        //To add Contact to Address Book
        public void CreateContact(string firstName, string lastName, string Address, string city, string state, int zip, long phoneNumber, string email)
        {   


            ContactArray[this.contact] = new AddressBookSystem(firstName, lastName, Address, city, state, zip, phoneNumber, email);
            contact++;
            ContactPerson obj = new ContactPerson();
            obj.Display(ContactArray, contact);
        }
        public void Modify()
        {
            int i = 0;
            Console.WriteLine("---To Modify---\nEnter first name of user");
            string name = Console.ReadLine();
            while (this.ContactArray[i].firstName != name)
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
                case 9:
                    ContactArray = ContactArray.Take(i).Concat(ContactArray.Skip(i + 1)).ToArray();
                    contact--;
                    break;
            }
            ContactPerson obj = new ContactPerson();
            obj.Display(ContactArray, contact);

        }


    }


    class ContactPerson
    {
        static void Main(string[] args)
        {
            //Calls Default constructor
            AddressBookSystem addressBookSystem = new AddressBookSystem();
            //Call Method
            addressBookSystem.CreateContact("Charan", "Kanduri", "Nellore", "Nellore", "AP", 524002, 9398100236, "charn@gmail.com");
            addressBookSystem.CreateContact("Srikar", "Kanduri", "Saraswathi Nagar", "nellore", "ap", 6000103, 8189994011, "srikar@gmail.com");
            addressBookSystem.Modify();
        }
        //Display Details
        public void Display(AddressBookSystem[] ContactArray, int N)
        {
            Console.WriteLine("---------Address Book Contains---------");
            int i;
            for (i = 0; i < N; i++)
            {
                Console.WriteLine("First name: {0}\n Last name: {1}\n Address: {2}\n City: {3}\n Zip: {4}\n State: {5}\n Phone Number: {6}\n Email: {7} \n", ContactArray[i].firstName, ContactArray[i].lastName, ContactArray[i].Address, ContactArray[i].city, ContactArray[i].zip, ContactArray[i].state, ContactArray[i].phoneNumber, ContactArray[i].email);
            }
        }
    }
}