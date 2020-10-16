﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new TwentyOneGame();
            game.Players = new List<Player>();//Must instantiate a list before adding a player
            Player player = new Player();
            player.Name = "Jesse";
            game += player;
            game -= player;

            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            //game.ListPlayers();
            //Console.ReadLine();


            Deck deck = new Deck();
            deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();


            //Polymorphism-ability of a class to morph into it inheriting class
            //List<Game> games = new List<Game>();
            //TwentyOneGame game = new TwentyOneGame();
            //games.Add(game);


            //Inheritance
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            //game.ListPlayers();
            //game.Play();
            //Console.ReadLine();


        }
    }
}
