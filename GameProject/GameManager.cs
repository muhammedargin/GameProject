using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager
    {
        List<Game> games;
        public GameManager()
        {

            games = new List<Game> { };
        }

        public void Add(Game game)
        {
            Console.WriteLine("-------------------------------");
            games.Add(game);
            Console.WriteLine("{0} oyunu eklendi",game.gameName);
            Console.WriteLine("-------------------------------");

        }

        public void Delete (Game game)
        {
            Console.WriteLine("-------------------------------");
            games.Remove(game);
            Console.WriteLine("{0} oyunu silindi", game.gameName);


        }

        public void Uptade(Game game)

        {
           //oyunlarda düzenlemeler yapılacak
            
        }

        public void List()
        {
            int i = 1;
            foreach (var game in games)
            {
                Console.WriteLine("Oyun Listesi");
                Console.WriteLine("{0} Oyun : {1}",i,game.gameName);
                i++;
            }


        }
            
            
             
 
    }


        


    
}
