using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4
{
    internal class Card
    {
        public Suit suit { get; set; }
        public Number number { get; set; }
        public Card(Suit suit, Number num)
        {
            this.suit = suit;
            this.number = num;
        }

        public override string ToString()
        {
            return number + " of " + suit;
        }

        public enum Suit
        {
            Hearts,
            Spades,
            Clubs,
            Diamonds
        }

        public enum Number
        {
            Ace,
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
            King
        }
    }
}
