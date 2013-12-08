namespace DeckOfCards
{
	public class Card
	{
		#region Fields
		private Suit suit;
		private Rank rank;
		#endregion

		#region Methods
		public Suit Suit
		{
			get { return suit; }
		}
		public Rank Rank
		{
			get { return rank; }
		}
		#endregion

		// Constructor
		public Card(Suit suit, Rank rank)
		{
			this.suit = suit;
			this.rank = rank;
		}

		// Override
		public override string ToString()
		{
			// Return card description in readable format, ex. "Jack of Clubs"
			return rank.ToString() + " of " + suit.ToString() + "s";
		}
	}
}