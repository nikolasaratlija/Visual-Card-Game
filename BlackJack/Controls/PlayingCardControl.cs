using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualCardGame.Entities;

namespace VisualCardGame.Controls
{
	public partial class PlayingCardControl : UserControl
	{
		private string value;
		private char suit;

		public PlayingCardControl(PlayingCard playingCard)
		{
			InitializeComponent();

			SetValues(playingCard.Value);

			SetSuits(playingCard.Suit);
		}

		private void SetValues(Value value)
		{
			switch (value)
			{
				case Value.Ace:
					this.value = "A";
					break;
				case Value.Jack:
					this.value = "J";
					break;
				case Value.Queen:
					this.value = "Q";
					break;
				case Value.King:
					this.value = "K";
					break;
				default:
					this.value = value.ToString();
					break;
			}

			this.top_left_value.Text = this.value;
			this.bottom_right_value.Text = this.value;
		}

		private void SetSuits(Suit suit)
		{
			char[] suits = new char[4] { '♥', '♣', '♠', '♦' };
			this.suit = suits[(int)suit];

			this.top_left_symbol.Text = this.suit.ToString();
			this.bottom_right_symbol.Text = this.suit.ToString();

			// sets the correct color of the symbols
			if (suit == Suit.Diamonds || suit == Suit.Hearts)
			{
				this.top_left_symbol.ForeColor = Color.Red;
				this.bottom_right_symbol.ForeColor = Color.Red;
			}
			else if (suit == Suit.Clubs || suit == Suit.Spades)
			{
				this.top_left_symbol.ForeColor = Color.Black;
				this.bottom_right_symbol.ForeColor = Color.Black;
			}
		}
	}
}
