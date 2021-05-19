using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                CustomerId = 1,
                FirstName = "Recep",
                LastName = "Pazarlı",
                IdentityNumber = "12345678912",
                Phone = "02133211232",
                Mail = "customer@gmail.com",
                City = "Bursa",
                Country = "İnegöl",
                Address = "Taksi yanı no:6"
            };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            Console.WriteLine("******************************************");
            customerManager.Update(customer1);
            Console.WriteLine("******************************************");
            customerManager.Delete(customer1);
            Console.WriteLine("******************************************");
            customerManager.GelAll(customer1);

        }




    }
}

