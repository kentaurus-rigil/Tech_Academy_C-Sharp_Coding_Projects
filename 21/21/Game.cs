﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }
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
