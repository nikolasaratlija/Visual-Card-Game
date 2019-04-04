using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualCardGame.Entities
{
	public class PlayingCard
	{
		public bool isVisible;

		#region getters and setters

		internal Suit Suit { get; }
		internal Value Value { get; }

		#endregion getters and setters

		internal PlayingCard(Value value, Suit symbol, bool isVisible)
		{
			this.Value = value;
			this.Suit = symbol;
			this.isVisible = isVisible;
		}		

		public void Flip()
		{
			this.isVisible = !this.isVisible;
		}
	}
}
