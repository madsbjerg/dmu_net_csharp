using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using static Opgave5.Card;

namespace Opgave5
{
    internal class CardGame
    {
        private List<Card> _cards = new List<Card>();

        public delegate bool FilterCardGame(Card card);

        public void AddCard(Suit suit, Number number)
        {
            _cards.Add(new Card(suit, number));
        }

        public List<Card> FilterGame(FilterCardGame filter)
        {
            List<Card> filtered = new List<Card>();

            foreach(Card card in _cards)
            {
                if (filter(card)) filtered.Add(card);
            }

            return filtered;
        }
    }
}
