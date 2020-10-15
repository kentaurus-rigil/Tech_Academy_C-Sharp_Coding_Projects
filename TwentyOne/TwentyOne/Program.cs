using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck deck = new Deck();
            deck.Shuffle(3);
            //deck = Shuffle(deck);
            //deck = Shuffle(/*named parameter easier to read*/deck: deck, times: 3);//optional parameters
            
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Faces + " of " + card.Suits);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        //Method Overloading
        //public static Deck Shuffle(Deck deck, int times) 
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
            //deck.Cards = new List<Card>();


            //Card cardOne = new Card() {Face = "King", Suit = "Spades"};
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            //deck.Cards.Add(cardOne);

            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            //Console.ReadLine();

        }
    }


