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
			CalcValueOfHand();
			CalcIfBust();
			return card;
		}

		/// <summary>
		/// Calculates the value of a certain card and adds that number.
		/// </summary>
		/// <param name="card"></param>
		/// <returns>The value of the card</returns>
		private int CalcValueOfHand()
		{
			if (IsBust == true && cardsInHand.Exists(card => card.Symbol == Symbol.Ace))
				cardsInHand.First(card => card.value == 11).value = 1;
			Console.WriteLine(cardsInHand.Sum(card => card.value));
			return valueOfHand = cardsInHand.Sum(card => card.value);
		}

		private bool CalcIfBust()
		{
			if (valueOfHand >= pointsToBust)
				return IsBust = true;

			return false;
		}
	}
}
