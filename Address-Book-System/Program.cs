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
        }
    }
}