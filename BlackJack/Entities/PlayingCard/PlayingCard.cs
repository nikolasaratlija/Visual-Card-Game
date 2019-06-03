using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Entities
{
	public class PlayingCard
	{
		public bool isFaceUp;
		public int value;

		#region getters and setters

		internal Suit Suit { get; }

		internal Symbol Symbol { get; }

		#endregion getters and setters

		internal PlayingCard(Symbol symbol, Suit suit, int value, bool isFaceUp = true)
		{
			this.Symbol = symbol;
			this.Suit = suit;
			this.value = value;
			this.isFaceUp = isFaceUp;
		}		

		public void Flip()
		{
			this.isFaceUp = !this.isFaceUp;
		}
	}
}
