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

		public void Hit(PlayingCardDeck deck)
		{
			PlayingCard card = deck.DrawFirstCard();
			cardsInHand.Add(card);
			CalculateValueOfHand(card);
			CalculateIfBust();
		}

		private bool CalculateIfBust()
		{
			if (valueOfHand >= pointsToBust)
			{
				IsBust = true;
				return true;
			}
			return false;
		}

		/// <summary>
		/// Calculates the value of a certain card and adds that number 
		/// </summary>
		/// <param name="card"></param>
		private void CalculateValueOfHand(PlayingCard card)
		{
			if (card.Value != Value.Ace)
			{
				valueOfHand += CardValueDefinition[card.Value];
			}
			else if (card.Value == Value.Ace)
			{
				// TODO: remove magic numbers
				if (valueOfHand + 11 >= pointsToBust)
				{
					valueOfHand += 1; 
				}
				else
				{
					valueOfHand += 11;
				}
			}
		}
	}
}
