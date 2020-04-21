using System;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook()
            {
                ContactList = new Contact[]
                {
                    new Contact
                    {
                        Name = "Khoa",
                        PhoneNumber = "0935216417"
                    },
                    new Contact
                    {
                        Name = "Tram",
                        PhoneNumber = "0935456789"
                    },
                    new Contact
                    {
                        Name = "Trung",
                        PhoneNumber = "0935113114"
                    }

                }
            };

            Console.WriteLine(phoneBook.ShowPhoneBook());

            Console.Write("enter your keyword: ");
            var keyword = Console.ReadLine();

            Console.WriteLine(phoneBook.Search(keyword));

            Console.Write("enter your keyword: ");
            var keyword2 = Console.ReadLine();

            phoneBook.Remove(ref phoneBook.ContactList, keyword);
            Console.WriteLine(phoneBook.ShowPhoneBook());

            Console.Write("enter your keyword: ");
            var keyword3 = Console.ReadLine();
            Console.Write("enter your new phone number: ");
            var newPhone = Console.ReadLine();

            phoneBook.Update(keyword3, newPhone);
            Console.WriteLine(phoneBook.ShowPhoneBook());

            Console.ReadKey();
        }
    }
}
