using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSystemDemo.Entities;

namespace GameSystemDemo.Abstract
{
    interface ICustomerService
    {
        void Save(Customer customer);

        void Update(Customer customer);

        void Delete(Customer customer);
    }
}
