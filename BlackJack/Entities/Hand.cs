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

		// TODO: refactor
		// A definition of how many points a certain card would be worth.
		// It's missing the Ace because the value of the Ace is dynamic.
		private readonly Dictionary<Value, int> CardValueDefinition = new Dictionary<Value, int>
		{
			{ Value.Two,   2 },
			{ Value.Three, 3 },
			{ Value.Four,  4 },
			{ Value.Five,  5 },
			{ Value.Six,   6 },
			{ Value.Seven, 7 },
			{ Value.Eight, 8 },
			{ Value.Nine,  9 },
			{ Value.Jack,  10 },
			{ Value.Queen, 10 },
			{ Value.King,  10 },
		};

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
			valueOfHand += CalcValue(card);
			CalcIfBust();
			return card;
		}

		private bool CalcIfBust()
		{
			if (valueOfHand >= pointsToBust)
				return IsBust = true;

			return false;
		}

		/// <summary>
		/// Calculates the value of a certain card and adds that number.
		/// </summary>
		/// <param name="card"></param>
		/// <returns>The value of the card</returns>
		private int CalcValue(PlayingCard card)
		{
			if (card.Value == Value.Ace)
			{
				// TODO: magic numbers somehow
				if (valueOfHand + 11 >= pointsToBust)
					return 1; 
				else
					return 11;
			}
			Console.WriteLine(card.Value);
			return CardValueDefinition[card.Value];
		}
	}
}
