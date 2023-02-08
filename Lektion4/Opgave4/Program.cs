namespace Opgave5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int suits = 4;
            int numbers = 13;

            CardGame game = new CardGame();

            // Create cards by looping through amount of suits and numbers
            for (int i = 0; i < suits; i++)
                for (int j = 0; j < numbers; j++)
                    game.AddCard((Card.Suit)i, (Card.Number)j);

            Console.WriteLine("Cards created.");

            // Filter using different delegates
            Console.WriteLine("\nClubs: ");
            List<Card> clubs = game.FilterGame(FilterByClubs);
            foreach(Card card in clubs)
            {
                Console.WriteLine(card.ToString());
            }

            Console.WriteLine("\nPicture cards: ");
            List<Card> pictures = game.FilterGame(FilterByPicture);
            foreach(Card card in pictures)
            {
                Console.WriteLine(card.ToString());
            }
        }

        static public bool FilterByPicture(Card card)
        {
            // numbers 0..9 are Ace..Ten everything higher is a picture card
            return (int)card.number > 9;
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