using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RefactortheAddressBook
{
    internal interface IAddressbook
    {
        public void addMultipleContact(string firstname, string lastname, string address, string city, string state, string zipcode, string phonenumber, string email);

        public void multipleContact();
    }

}
