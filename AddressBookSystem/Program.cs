using System;
using System.Data;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Problem");
            //UC 1 and 2 Create Address Book DataTable
            DataTable addressBook = new DataTable();
            addressBook.TableName = "AddressBook";
            addressBook.Columns.Add("First Name");
            addressBook.Columns.Add("Last Name");
            addressBook.Columns.Add("Address");
            addressBook.Columns.Add("City");
            addressBook.Columns.Add("State");
            addressBook.Columns.Add("Phone Number");
            addressBook.Columns.Add("Email");
        }
    }
}
