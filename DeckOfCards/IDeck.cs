using System;
using System.Collections.Generic;

namespace DeckOfCards
{
	interface IDeck
	{
		void Reset();
		void Shuffle();
		Card TakeCard();
		IEnumerable<Card> TakeCards(int numberOfCards);
	}
}