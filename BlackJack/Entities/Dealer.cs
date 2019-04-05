using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Entities
{
	class Dealer
	{
		private readonly PlayingCardDeck deck;
		private static Random random = new Random();

		public Dealer(PlayingCardDeck deck)
		{
			this.deck = deck;
		}

		public PlayingCard DealCard()
		{
			int index = random.Next(deck.DeckList.Count);
			return this.deck.DeckList[index];
		}
	}
}
