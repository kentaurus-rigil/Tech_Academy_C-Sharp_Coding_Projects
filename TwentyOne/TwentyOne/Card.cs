using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
   public class Card
    {
        //Constructor method name is always the name of the class
        public Card()
        {
            Suits = "Spades";
            Faces = "two";
        }
        //Public is the property of the object and it determines, string(data type). named Suit
        //Card class has a property of data type string, named Suit.  You can get this property or set this property
        public string Suits { get; set; }//class is a cookie cutter, and object is the cookie.
        public string Faces { get; set; }

    }
}
