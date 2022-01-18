using System;
namespace RefactortheAddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.addMultipleContact("sri", "dharan", "abcstreet", "xyz city", "tn", "600876", "9876543211", "asf123@gmail.com");
            address.addMultipleContact("diya", "sri", "abtstreet", "abc city", "ts", "600123", "9876542398", "choci@gmail.com");
            address.addMultipleContact("varun", "prasad", "bcstreet", "xyzav city", "ap", "600567", "9876543210", "candy@gmail.com");
            address.addMultipleContact("krish", "steve", "atbcstreet", "xyzad city", "dl", "600987", "9876547536", "sweety@gmail.com");
            address.addMultipleContact("sree", "piya", "abcdstreet", "xyzop city", "wb", "600967", "8754543211", "asdd4234@gmail.com");
            address.multipleContact();
            Console.WriteLine(address);
        }
    }

}

