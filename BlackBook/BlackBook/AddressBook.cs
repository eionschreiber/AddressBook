using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBook
{
    public class AddressBook
    {
        
       public SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();

        public SortedDictionary<string,string> initialAddresses()
        {
            
            phoneBook.Add("Jimmy Falon", "234-435-1324");
            phoneBook.Add("Alex Trabeck", "308-542-1672");
            phoneBook.Add("Donald Trump", "1-800-BULL");
            phoneBook.Add("Kung Furry", "1-800-CHOSEN-ONE");
            phoneBook.Add("Forest Gump", "1-800-SHRIMP");
            return phoneBook;
            
        }
        public void printPhoneBook()
        {
            Console.WriteLine("Do you want to see the full address list? type y or n");
            string readBookChoice = Console.ReadLine().ToLower();
            if (readBookChoice == "y")
            {
                    foreach (KeyValuePair<string,string> entry in phoneBook)
                {
                    Console.WriteLine(entry);
                }
            }
            
        }
        public void lookUpNumber()
        {
            Console.WriteLine("Type in the name of the person you want to find and I'll give you their number");
            string findNumber = Console.ReadLine();
            if (phoneBook.ContainsKey(findNumber) == true)
            {
                Console.WriteLine(phoneBook[findNumber]);
            }
            if (phoneBook.ContainsKey(findNumber) == false)
            {
                Console.WriteLine("that name does not exist");
            }

        }
        public void addToAddressBook()
        {
            Console.WriteLine("Do you want to add to your contacts? y or n");
            string addToBookChoice = Console.ReadLine().ToLower();
            if (addToBookChoice == "y")
            {
                Console.WriteLine("Enter a First Name");
                string addFirstName = Console.ReadLine();
                Console.WriteLine("Enter a Last Name");
                string addLastName = Console.ReadLine();
                Console.WriteLine("Enter a Phone Number");
                string addPhoneNumber = Console.ReadLine();
                string addFullName = addFirstName + " " + addLastName;
                phoneBook.Add(addFullName, addPhoneNumber);
                Console.WriteLine("entry added");

            }
        }
        public void ChangeContact(string name)
        {
            Console.WriteLine("This is where I will over ride from changing the contacts name to changing their phone number if that is possible");
        }
        

    }
}
