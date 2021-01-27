using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();
            CampaignManager campaignManager = new CampaignManager();
            MemberManager memberManager = new MemberManager();
            SalesManager salesManager = new SalesManager();
            //bütün managerleri oluşturduk.

            Game game1 = new Game()
            {
                gameName = "Assassin's Creed Odyssey",
                gameCategory = 1,
                gamePrice = 99
            };

            Game game2 = new Game()
            {
                gameName = "The Witcher 3 Wild Hunt",
                gameCategory = 2,
                gamePrice = 29
            };

            Campaign campaign = new Campaign();
            campaign.campaignName = "Black Friday";
            campaign.campaignDiscount = 50;//yüzde olarak bu rakamı indirim hesaplamada kullanacağız


            NewMember newMember = new NewMember() { 
                Id = 0001, 
                Age = 25,
                Name="Muhammed",
                Surname="Argin",
                TcNo="1111111111",
                whoRecommended="Engin Demiroğ" };
            OldMember oldMember = new OldMember()
            {
                Id = 0002,
                Age = 23,
                Name = "Zeynep",
                Surname = "Argin",
                TcNo = "222222222",
                registrationDate = "01/01/2021"
            };

            Console.WriteLine("----------------------");
            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.List();
            gameManager.Delete(game2);
            gameManager.List();
            // oyun ekleme ve silme işlemleri gerçekleştirildi

            Console.WriteLine("------------------");

            memberManager.Add(newMember); 
            memberManager.Add(oldMember);
            memberManager.List();
            memberManager.Delete(oldMember);
            memberManager.List();
            // üye ekleme ve silme işlemleri gerçekleştirildi

            Console.WriteLine("------------------");
            salesManager.SalesInformation(game1, campaign, newMember);


        }
    }
}
