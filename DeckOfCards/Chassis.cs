namespace DeckOfCards
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class Chassis
	{
		public static void Main()
		{
			IDeck deck = new Deck();
			IEnumerable<Card> hand = deck.TakeCards(13);

			Console.WriteLine("Displaying hand:");
			foreach (Card card in hand)
				Console.WriteLine(card.ToString());
			Console.ReadLine();

			Console.WriteLine("Displaying remaining deck:");
			Console.Write(deck.ToString());
			Console.ReadLine();

			deck.Shuffle();

			Console.WriteLine("Displaying remaining, shuffled deck:");
			Console.Write(deck.ToString());
			Console.ReadLine();

			Card takenCard = deck.TakeCard();

			Console.WriteLine("Displaying next card delt from deck:");
			Console.WriteLine(takenCard.ToString());
			Console.ReadLine();

			Console.WriteLine("Displaying remaining deck:");
			Console.Write(deck.ToString());
			Console.ReadLine();
		}
	}
}
