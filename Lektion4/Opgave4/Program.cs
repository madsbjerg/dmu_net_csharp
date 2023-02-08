namespace Opgave4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            CardGame game = new CardGame();
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 13; j++)
                {
                    game.AddCard((Card.Suit)i, (Card.Number)j);
                }
            }
            Console.WriteLine("Cards created.");

            List<Card> filtered = game.FilterGame(FilterByClubs);
            foreach(Card card in filtered)
            {
                Console.WriteLine(card.ToString());
            }
        }

        static public bool FilterByClubs(Card card)
        {
            return card.suit == Card.Suit.Clubs;
        }

        static public bool FilterByHearts(Card card)
        {
            return card.suit == Card.Suit.Hearts;
        }
    }
}