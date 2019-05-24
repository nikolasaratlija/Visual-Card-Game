using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Entities
{
	class Dealer : Hand
	{
		private PlayingCardDeck deck;

		public Dealer(PlayingCardDeck deck)
		{
			this.deck = deck;
		}

		public PlayingCard DealCard()
		{
			return deck.DrawFirstCard();
		}
	}
}
