// Credit to Sam Jenkins for great ideas in approaching this
// http://satalketo.com/2013/04/deck-of-cards-in-c/

using System;
using System.Collections.Generic;
using System.Linq;

namespace DeckOfCards
{
	public class Chassis
	{
		public static void Main()
		{
			// Instantiate a deck.
			IDeck deck = new Deck();

			// Create a hand (using IEnumerable since we're only viewing it).
			IEnumerable<Card> hand = deck.TakeCards(13);

			// Show the hand.
			Console.WriteLine("Displaying hand:");
			foreach (Card card in hand)
				Console.WriteLine(card.ToString());
			Console.ReadLine();

			// Show the remaining deck.
			Console.WriteLine("Displaying remaining deck:");
			Console.Write(deck.ToString());
			Console.ReadLine();

			// Shuffle the deck.
			deck.Shuffle();

			// Show the shuffled deck.
			Console.WriteLine("Displaying remaining, shuffled deck:");
			Console.Write(deck.ToString());
			Console.ReadLine();

			// Take a card off the top of the deck.
			Card takenCard = deck.TakeCard();

			// Show the card.
			Console.WriteLine("Displaying next card delt from deck:");
			Console.WriteLine(takenCard.ToString());
			Console.ReadLine();

			// Show the remaining deck.
			Console.WriteLine("Displaying remaining deck:");
			Console.Write(deck.ToString());
			Console.ReadLine();
		}
	}
}