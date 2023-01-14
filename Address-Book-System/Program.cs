using System.Net;

namespace Address_Book_System
{
    internal class Program
    {
        static void Main(string[] args)
        {   //print Message
            Console.WriteLine("Welcome to Address Book  System");

              //Create contact
               CreateContact.PersonDetails();
               Console.ReadLine();

              //add a new contact
               AddContact.GetCustomer();
               AddContact.ListingPeople();

             // Modify existing contact
              EditContact.GetCustomer();
              EditContact.Modify();
              EditContact.ListingPeople();

            //delete a person          
            DeleteContact.GetCustomer();
            DeleteContact.Modify();
            DeleteContact.ListingPeople();
            DeleteContact.RemovePeople();

            //add multiple person to Address Book
            Console.WriteLine("Welcome To Address Book System!");
            Console.WriteLine("1.Enter to add the details");
            Console.WriteLine("2.Enter to modify the details");
            Console.WriteLine("3.Listing the details..");
            Console.WriteLine("4.Remove the details");
            Console.WriteLine("Enter a option");
            switch (Console.ReadLine())
            {
                case "1":
                    AddressBook.AddBook.GetCustomer();
                    AddressBook.AddBook.ListingPeople();
                    break;
                case "2":
                    AddressBook.AddBook.GetCustomer();
                    AddressBook.AddBook.Modify();
                    AddressBook.AddBook.ListingPeople();
                    break;
                case "3":
                    AddressBook.AddBook.GetCustomer();
                    AddressBook.AddBook.ListingPeople();
                    break;
                case "4":
                    AddressBook.AddBook.GetCustomer();
                    AddressBook.AddBook.RemovePeople();

                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;

            }
        }
    }
}