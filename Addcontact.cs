using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactortheAddressBook
{
    internal class Addcontact
    {
        public string firstname;
        public string lastname;
        public string address;
        public string city;
        public string state;
        public string zipcode;
        public string phonenumber;
        public string email;

        public Addcontact(string firstname, string lastname, string address, string city, string state, string zipcode, string phonenumber, string email)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipcode = zipcode;
            this.phonenumber = phonenumber;
            this.email = email;

        }

    }
}
