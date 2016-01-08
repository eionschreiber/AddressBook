using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBook
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressbook = new AddressBook();
            addressbook.initialAddresses();
            addressbook.addToAddressBook();
            addressbook.lookUpNumber();
            addressbook.printPhoneBook();
        }
    }
}
