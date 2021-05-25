using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSystemDemo.Abstract;
using GameSystemDemo.Entities;

namespace GameSystemDemo.Concrete
{
    public class GameManager : IGameService
    {

        public void Save(Customer customer, Game game)
        {
            Console.WriteLine("Your game information saved    " +customer.FirstName + "&" + customer.LastName+"--->"+game.GameName+" "+game.UnitPrice);
        }

        public void Update(Customer customer, Game game)
        {
            Console.WriteLine("Your game information updated  " + customer.FirstName + "&" + customer.LastName + "--->" + game.GameName + " " + game.UnitPrice);
        }

        public void Delete(Customer customer, Game game)
        {
            Console.WriteLine("Your game information deleted  " + customer.FirstName + "&" + customer.LastName + "--->" + game.GameName + " " + game.UnitPrice);
        }

        public void Discount(Customer customer, Game game, Campaign campaign)
        {
            Console.WriteLine("Discount Applied  " + customer.FirstName + "&" + customer.LastName + "--->" + game.GameName+ " Discounted price : " + (game.UnitPrice-campaign.Discount)+"TL");

        }
    }
}
