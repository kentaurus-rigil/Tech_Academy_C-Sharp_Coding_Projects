using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    public struct Card
    {
        public Suit Suit { get; set; }//class is a cookie cutter, and object is the cookie.
        public Face Face { get; set; }
        public override string ToString()
        {
            return string.Format("{0} of {1}, ", Face, Suit);
        }

    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    { 
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
        
}

    

