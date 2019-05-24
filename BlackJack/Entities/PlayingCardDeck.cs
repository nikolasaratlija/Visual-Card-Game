using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Entities
{
	class PlayingCardDeck
	{
		private readonly List<PlayingCard> DrawnCardsList = new List<PlayingCard>();

		/// <summary>
		/// creates 13 cards for each suit and puts them into a list
		/// </summary>
		public PlayingCardDeck()
		{
			int cardsPerSuit = 13;
			int suitCount = 4;

			for (int suit = 0; suit < suitCount; suit++)
			{
				for (int value = 0; value < cardsPerSuit; value++)
				{
					this.DeckList.Add(new PlayingCard((Value)value, (Suit)suit, true));
				}
			}
		}

		/// <summary>
		/// Returns the first PlayingCard from the deck
		/// </summary>
		/// <returns></returns>
		public PlayingCard DrawFirstCard()
		{
			PlayingCard card = this.DeckList[0];

			// Removes the drawn card from the deck and puts it in another list
			RemoveCard(card);
			DrawnCardsList.Add(card);

			return card;
		}

		/// <summary>
		/// Finds the index of a card in this.DeckList by the properties Value and Suit and then removes it from the list
		/// </summary>
		/// <param name="card"></param>
		private void RemoveCard(PlayingCard card)
		{
			int index = DeckList.FindIndex(value => 
				value.Value == card.Value && value.Suit == card.Suit
			);

			DeckList.RemoveAt(index);
		}

		internal List<PlayingCard> DeckList { get; } = new List<PlayingCard>();
	}
}
