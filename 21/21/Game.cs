using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    public abstract class Game
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }
        public abstract void Play();//Any class inheriting this must inherit this method.
        public virtual void ListPlayers()//virtual method get inherited, but has the ability to override it.
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }

    }
}
