using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCardGame.Entities
{
	class PlayingDeck
	{
		public PlayingDeck()
		{
			int cardsPerSuit = 13;
			int suitCount = 4; 

			// creates 13 cards for each suit and pushes them into a list
			for (int suit = 0; suit < suitCount; suit++)
			{
				// loop starts at 1 because there's no card with a value lower than 1
				for (int value = 1; value <= cardsPerSuit; value++)
				{
					this.DeckList.Add(new PlayingCard((Value)value, (Suit)suit, true));	
				}
			}
		}

		internal List<PlayingCard> DeckList { get; } = new List<PlayingCard>();
	}
}
