using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using static Opgave4.Card;

namespace Opgave4
{
    internal class CardGame
    {
        private List<Card> _cards = new List<Card>();

        public delegate bool FilterCardGame(Card card);
        private FilterCardGame _filter;

        public void AddCard(Suit suit, Number number)
        {
            _cards.Add(new Card(suit, number));
        }

        public void SetFilter(FilterCardGame filter)
        {
            _filter = filter;
        }

        public List<Card> FilterGame(FilterCardGame filter)
        {
            _filter = filter;
            List<Card> filtered = new List<Card>();

            foreach(Card card in _cards)
            {
                if (filter(card)) filtered.Add(card);
            }

            return filtered;
        }



    }
}
