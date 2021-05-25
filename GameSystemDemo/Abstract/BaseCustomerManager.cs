using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSystemDemo.Entities;

namespace GameSystemDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService 
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Your information saved    "+customer.FirstName+"&"+customer.LastName);
        }

        public  void Update(Customer customer)
        {
            Console.WriteLine("Your information updated  " + customer.FirstName + "&" + customer.LastName);
        }

        public  void Delete(Customer customer)
        {
            Console.WriteLine("Your information deleted  " + customer.FirstName + "&" + customer.LastName);
        }

    }
}
