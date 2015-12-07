namespace DeckOfCards
{
	public class Card
	{
		private Suit suit;
		private Rank rank;

		public Suit Suit { get { return suit; } }
		public Rank Rank { get { return rank; } }

		public Card(Suit suit, Rank rank)
		{
			this.suit = suit;
			this.rank = rank;
		}

		public override string ToString()
		{
			return rank.ToString() + " of " + suit.ToString() + "s";
		}
	}
}
