using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager
    {
        List<Campaign> campaigns;
        public CampaignManager()
        {
            campaigns = new List<Campaign> { } ;
        }
        public void Add(Campaign campaign)
        {
            Console.WriteLine("--------------------------");
            campaigns.Add(campaign);
            Console.WriteLine(campaign.campaignName+ " "+ "Kampanyası eklenmiştir.");
            

        }



        public void Delete(Campaign campaign)
        {
            Console.WriteLine("--------------------------");
            campaigns.Remove(campaign);
            Console.WriteLine(campaign.campaignName + " " + "Kampanyası silinmiştir.");

        }


        public void Update()
        {

            //kampanyada fiyat ve isim değişiklikleri yapılacak


        }

        public void ShowList()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Kampanyalar Listleniyor...");
            foreach (var campaign in campaigns)
            {
                Console.WriteLine(campaign);
            }

        }


        
    }


        

    
}
