using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCardGame.Entities
{
	public class PlayingCard
	{
		private readonly int tempValue;
		private readonly Suit suit;
		private readonly Value value;
		public bool isVisible;

		#region getters and setters

		public int Value { get => tempValue; }
		internal Suit Symbol { get => suit; }
		internal Value SpecialValue { get => value; }

		#endregion getters and setters

		internal PlayingCard(int value, Suit symbol, bool isVisible)
		{
			this.tempValue = value;
			this.suit = symbol;
			this.isVisible = isVisible;
		}

		internal PlayingCard(Value value, Suit symbol, bool isVisible)
		{
			this.value = value;
			this.suit = symbol;
			this.isVisible = isVisible;
		}		

		public void Flip()
		{
			this.isVisible = !this.isVisible;
		}

		public string ShowCard()
		{
			String cardInfo = "Card is face down";

			if (this.isVisible)
			{
				if (this.tempValue > 10 || this.tempValue < 2)
				{
					cardInfo = this.value.ToString();
				}
				else
				{
					cardInfo = this.tempValue.ToString();
				}

				cardInfo += " of " + this.suit.ToString();
			}

			return cardInfo;
		}
	}
}
