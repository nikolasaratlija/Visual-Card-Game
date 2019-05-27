using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Entities
{
	abstract class Hand
	{
		const int pointsToBust = 21;

		private int valueOfHand = 0;
		private List<PlayingCard> cardsInHand = new List<PlayingCard>();

		#region getters and setters 

		public bool IsBust { get; private set; } = false;

		#endregion

		/// <summary>
		/// Draws a card then adds the value of the card.
		/// </summary>
		/// <param name="deck"></param>
		/// <returns>A PlayingCard object</returns>
		public PlayingCard Hit(PlayingCardDeck deck)
		{
			PlayingCard card = deck.DrawFirstCard();
			cardsInHand.Add(card);
			CalcValueOfHand(card);
			CalcIfHandBust();
			return card;
		}

		/// <summary>
		/// Calculates the value of a certain card and adds that number.
		/// </summary>
		/// <param name="card"></param>
		/// <returns>The value of the card</returns>
		private int CalcValueOfHand(PlayingCard playingCard)
		{
			if (CalcIfHandBust(playingCard.value))
			{
				if (cardsInHand.Exists(card => card.value == 11))
				{
					PlayingCard aceCard = cardsInHand.Find(card => card.value == 11);
					aceCard.value = 1;
					return valueOfHand = cardsInHand.Sum(card => card.value);
				}
			}

			return valueOfHand += playingCard.value;
		}

		/// <summary>
		/// Calculates whether the hand would bust with its current amounted value.
		/// </summary>
		/// <returns>A bool</returns>
		private bool CalcIfHandBust()
		{
			return IsBust = CalcIfHandBust(0);
		}

		/// <summary>
		/// Calculates whether adding `int value` to `this.valueOfHand` would make this Hand bust
		/// </summary>
		/// <param name="value"></param>
		/// <returns>A bool</returns>
		private bool CalcIfHandBust(int value)
		{
			if (valueOfHand + value >= pointsToBust)
				return true;

			return false;
		}
	}
}
