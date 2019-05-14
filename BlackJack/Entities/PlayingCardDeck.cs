using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Entities
{
	class PlayingCardDeck
	{
		public PlayingCardDeck()
		{
			int cardsPerSuit = 13;
			int suitCount = 4;

			// creates 13 cards for each suit and pushes them into a list
			for (int suit = 0; suit < suitCount; suit++)
			{
				for (int value = 0; value < cardsPerSuit; value++)
				{
					this.DeckList.Add(new PlayingCard((Value)value, (Suit)suit, true));
				}
			}
		}

		public void RemoveCard(Suit suit, Value value)
		{
			this.DeckList.FindIndex(
				card => card.Suit == Suit.Hearts && card.Value == Value.Four
			);
		}

		internal List<PlayingCard> DeckList { get; } = new List<PlayingCard>();
	}
}
