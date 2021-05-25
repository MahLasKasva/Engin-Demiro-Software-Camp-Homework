using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSystemDemo.Entities;

namespace GameSystemDemo.Abstract
{
    interface ICampaignService
    {
        void Save(Game game,Campaign campaign);
        void Update(Game game, Campaign campaign);
        void Delete(Game game, Campaign campaign);


    }
}
