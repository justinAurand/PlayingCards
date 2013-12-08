using System;
using System.Collections.Generic;
using System.Linq;

namespace DeckOfCards
{
	public class Deck : IDeck
	{
		// Field
		private List<Card> cards;

		// Constructor
		public Deck()
		{
			Reset();
		}

		#region Methods
		// Replace cards list with new set of 52 cards.
		public void Reset()
		{
			cards = Enumerable.Range(1, 4)
				.SelectMany(s => Enumerable.Range(1, 13)
					.Select(r => new
						Card((Suit)s, (Rank)r)
					)
				).ToList();
		}

		// Randomize the list of cards.
		public void Shuffle()
		{
			cards = cards.OrderBy(c => Guid.NewGuid())
				.ToList();
		}

		// Take a single card from the list of cards.
		public Card TakeCard()
		{
			// Select the first card in the list of cards.
			Card card = cards.FirstOrDefault();

			// Remove the selected card from the list of cards.
			cards.Remove(card);

			// Return the selected card.
			return card;
		}

		// Take the number of cards supplied from the list of cards.
		public IEnumerable<Card> TakeCards(int numberOfCards)
		{
			// Try selecting the supplied number of cards from the list of cards.
			IEnumerable<Card> takenCards = cards.Take(numberOfCards);

			// Convert taken cards to an array.
			var takenCardsArray = takenCards as Card[] ?? takenCards.ToArray();

			// Remove the taken cards from the list of cards.
			cards.RemoveAll(takenCardsArray.Contains);

			// Return the taken cards.
			return takenCardsArray;
		}
		#endregion

		// Override
		public override string ToString()
		{
			// Instantiate the return string.
			string str = String.Empty;

			// Loop through the list of cards.
			foreach (Card card in cards)
				// Add a readable card description and new line to the return string.
				str += card.ToString() + Environment.NewLine;

			// Return the result.
			return str;
		}
	}
}