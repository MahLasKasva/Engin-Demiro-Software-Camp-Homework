using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSystemDemo.Abstract;
using GameSystemDemo.Entities;

namespace GameSystemDemo.Concrete
{
    public class CampaignManager:ICampaignService
    {
        public void Save(Game game, Campaign campaign)
        {
            Console.WriteLine("Campaign added    "+game.GameName+"  "+campaign.CampaignName+"  "+campaign.Details);
        }

        public void Update(Game game, Campaign campaign)
        {
            Console.WriteLine("Campaign updated  " + game.GameName + "  " + campaign.CampaignName);

        }

        public void Delete(Game game, Campaign campaign)
        {
            Console.WriteLine("Campaign deleted  " + game.GameName + "  " + campaign.CampaignName);

        }
    }
}
