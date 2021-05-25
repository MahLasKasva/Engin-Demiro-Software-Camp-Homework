using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSystemDemo.Entities;

namespace GameSystemDemo.Abstract
{
    interface IGameService
    {
        void Save(Customer customer,Game game);

        void Update(Customer customer, Game game);

        void Delete(Customer customer, Game game);

        void Discount(Customer customer, Game game,Campaign campaign);
    }
}
