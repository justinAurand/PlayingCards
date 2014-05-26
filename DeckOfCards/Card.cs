namespace DeckOfCards
{
	public class Card
	{
		// Fields.
		private Suit suit;
		private Rank rank;

		// Properties.
		public Suit Suit { get { return suit; } }
		public Rank Rank { get { return rank; } }

		// Constructor.
		public Card(Suit suit, Rank rank)
		{
			this.suit = suit;
			this.rank = rank;
		}

		// Override.
		public override string ToString()
		{
			// Return card description in readable format. Ex: "Jack of Clubs"
			return rank.ToString() + " of " + suit.ToString() + "s";
		}
	}
}