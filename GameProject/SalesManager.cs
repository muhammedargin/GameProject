using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager
    {

        private double CalculatePrice(Game game, Campaign campaign)
        {

            double discountedPrice = (game.gamePrice * campaign.campaignDiscount) / 100;
            Console.WriteLine("----------------------");
            Console.WriteLine("{0} oyununa {1} kampanyası uygulandı.\n Eski fiyat: {2}\n Yeni Fiyat : {3} \n",
                game.gameName, 
                campaign.campaignName,
                game.gamePrice,
                discountedPrice);
            return discountedPrice;

        }

        public void SalesInformation(Game game, Campaign campaign,Member member)
        {
            double price = CalculatePrice(game,campaign);
            Console.WriteLine("----------------------");
            Console.WriteLine("{0} Id'li hesabınız ile {1} oyununu {2} kampanyası ile {3} TL'ye satın aldınız.",
                member.Id,game.gameName,campaign.campaignName, price);


        }

        
    }
}
