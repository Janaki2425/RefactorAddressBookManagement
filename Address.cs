using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactortheAddressBook
{
    public class Address:IAddressbook
    {
        private LinkedList<Addcontact> Addcontactlist;
        private Dictionary<string, Addcontact> Addcontactmap;
    public Address()
        {
            this.Addcontactlist = new LinkedList<Addcontact>();
            this.Addcontactmap = new Dictionary<string,Addcontact>();

        }
        public void addMultipleContact(string firstname, string lastname, string address, string city, string state, string zipcode, string phonenumber, string email)
        {
            Addcontact addcontact = new Addcontact(firstname, lastname, address, city, state, zipcode, phonenumber, email);
            this.Addcontactlist.AddLast(addcontact);
            this.Addcontactmap.Add(firstname, addcontact);
        }
        public void multipleContact()
        {
            foreach (Addcontact addcontact in this.Addcontactlist)
            {
                Console.WriteLine(addcontact.ToString());
            }
        
        }

    }
}
