namespace DeckOfCards
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class Deck : IDeck
	{
		private List<Card> cards;

		public Deck()
		{
			Reset();
		}

		#region Methods
		public void Reset()
		{
			cards = Enumerable.Range(1, 4)
				.SelectMany(s => Enumerable.Range(1, 13)
					.Select(r => new Card((Suit)s, (Rank)r))
				).ToList();
		}

		public void Shuffle()
		{
			cards = cards.OrderBy(c => Guid.NewGuid())
				.ToList();
		}

		public Card TakeCard()
		{
			Card card = cards.FirstOrDefault();
			cards.Remove(card);
			return card;
		}

		public IEnumerable<Card> TakeCards(int numberOfCards)
		{
			IEnumerable<Card> takenCards = cards.Take(numberOfCards);
			var takenCardsArray = takenCards as Card[] ?? takenCards.ToArray();
			cards.RemoveAll(takenCardsArray.Contains);
			return takenCardsArray;
		}
		#endregion

		public override string ToString()
		{
			string str = String.Empty;
			foreach (Card card in cards)
				str += card.ToString() + Environment.NewLine;
			return str;
		}
	}
}