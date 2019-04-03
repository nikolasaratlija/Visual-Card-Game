using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCardGame.Entities
{
	public class PlayingCard
	{
		private readonly int value;
		private readonly Symbol symbol;
		private readonly SpecialValue specialValue;
		public bool isVisible;

		#region getters and setters

		public int Value { get => value; }
		internal Symbol Symbol { get => symbol; }
		internal SpecialValue SpecialValue { get => specialValue; }

		#endregion getters and setters

		internal PlayingCard(int value, Symbol symbol, bool isVisible)
		{
			this.value = value;
			this.symbol = symbol;
			this.isVisible = isVisible;
		}

		internal PlayingCard(SpecialValue specialValue, Symbol symbol, bool isZichtbaar)
		{
			this.specialValue = specialValue;
			this.symbol = symbol;
			this.isVisible = isZichtbaar;
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
				if (this.value > 10 || this.value < 2)
				{
					cardInfo = this.specialValue.ToString();
				}
				else
				{
					cardInfo = this.value.ToString();
				}

				cardInfo += " of " + this.symbol.ToString();
			}

			return cardInfo;
		}
	}
}
