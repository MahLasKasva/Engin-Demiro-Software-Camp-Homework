using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName+" "+customer.LastName+ "s customer information has been saved");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + "s customer information has been updated");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + "s customer information was deleted");
        }

        public void GelAll(Customer customer)
        {
            Console.WriteLine(
              "CustomerId: " +  customer.CustomerId+"\n" +
              "FirstName: " + customer.FirstName+ "\n"+
              "LastName: " + customer.LastName+ "\n"+
              "IdentityNumber: " + customer.IdentityNumber+ "\n"+
              "Phone: " + customer.Phone+ "\n"+
              "Mail: " + customer.Mail+ "\n"+
              "City: " + customer.City+ "\n" +
              "Country: " + customer.Country+ "\n" +
              "Address: " + customer.Address);
        }
    }
}
