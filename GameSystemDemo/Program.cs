using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GameSystemDemo.Abstract;
using GameSystemDemo.Adapters;
using GameSystemDemo.Concrete;
using GameSystemDemo.Entities;

namespace GameSystemDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new CustomerManager(new MernisServiceAdapter());
            Customer customer1 = new Customer
            {
                Id = 1,
                DateOfBirth = new DateTime(1999, 11, 23),
                FirstName = "Recep",
                LastName = "Pazarlı",
                NationalyId = "22450529986"
            };

            Console.WriteLine("1------------------------------");
            baseCustomerManager.Save(customer1);
            baseCustomerManager.Delete(customer1);
            baseCustomerManager.Update(customer1);
            Console.WriteLine("-------------------------------");


            Game game1 = new Game
            {
                Id = 1,
                GameName = "Euro Truck Simulator",
                UnitPrice = 100
            };

            GameManager gameManager = new GameManager();
            Console.WriteLine("2------------------------------");
            gameManager.Save(customer1,game1);
            gameManager.Update(customer1, game1);
            gameManager.Delete(customer1, game1);
            Console.WriteLine("-------------------------------");

            Campaign campaign1 = new Campaign
            {
                Id = 1,
                CampaignName = "Summer sale",
                Details = "20 TL discount on the Euro Truck game",
                Discount = 20
            };

            Console.WriteLine("3------------------------------");
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Save(game1,campaign1);
            campaignManager.Update(game1, campaign1);
            campaignManager.Delete(game1, campaign1);
            Console.WriteLine("-------------------------------");


            Console.WriteLine("4------------------------------");
            gameManager.Discount(customer1,game1,campaign1);
            Console.WriteLine("-------------------------------");















            Console.ReadLine();
        }
    }
}