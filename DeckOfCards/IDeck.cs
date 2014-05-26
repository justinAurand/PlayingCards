namespace DeckOfCards
{
	using System;
	using System.Collections.Generic;

	interface IDeck
	{
		void Reset();
		void Shuffle();
		Card TakeCard();
		IEnumerable<Card> TakeCards(int numberOfCards);
	}
}