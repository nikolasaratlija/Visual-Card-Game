using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Entities
{
	class PlayingCardDeck
	{
		private List<PlayingCard> DrawnCardsList = new List<PlayingCard>();

		/// <summary>
		/// creates 12 cards for each suit and puts them into a list
		/// </summary>
		public PlayingCardDeck()
		{
			int cardsPerSuit = 12;
			int suitCount = 4;

			for (int suit = 0; suit < suitCount; suit++)
			{
				for (int value = 1; value <= cardsPerSuit; value++)
				{
					DeckList.Add(new PlayingCard((Symbol)value, (Suit)suit, value, true));
				}
			}

			DeckList.Find(card => card.Symbol == Symbol.Ace).value = 11;

			// TODO: change values of facecards to be 11
		}

		/// <summary>
		/// Returns the first PlayingCard from the deck
		/// </summary>
		/// <returns>PlayingCard object</returns>
		public PlayingCard DrawFirstCard()
		{
			PlayingCard card = this.DeckList[0];
			
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
				value.Symbol == card.Symbol && value.Suit == card.Suit
			);

			DeckList.RemoveAt(index);
		}

		internal List<PlayingCard> DeckList { get; } = new List<PlayingCard>();
	}
}
