namespace Address_Book_System
{
    internal class Program
    {
        static void Main(string[] args)
        {   //print Message
            Console.WriteLine("Welcome to AddressBook Book System");

            //add a new contact
            CreateContact.PersonDetails();
            Console.ReadLine();
        }
    }
}