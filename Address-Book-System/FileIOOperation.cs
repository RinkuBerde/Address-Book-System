using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{
    internal class FileIOOperation
    {
        private string filePath = @"C:\Users\RINKU\Desktop\Day-9\Address-Book-System\Address-Book-System\AddressBookRecord.txt";
        public void WriteToFile(Dictionary<string, AddressBook> addressBookDictionary)
        {
            using StreamWriter writer = new StreamWriter(filePath, true);
            foreach (AddressBook addressBookobj in addressBookDictionary.Values)
            {
                foreach (Contact contact in addressBookobj.addressBook.Values)
                {
                    writer.WriteLine(contact.ToString());
                }
            }
            Console.WriteLine("\nSuccessfully added to Text file.");
            writer.Close();
        }
        public void ReadFromFile()
        {
            Console.WriteLine("Below are Contents of Text File");
            string lines = File.ReadAllText(filePath);
            Console.WriteLine(lines);
        }
    }
}

