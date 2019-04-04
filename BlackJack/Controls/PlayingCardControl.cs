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
		private PlayingCard playingCard;
		private string value;
		private char suit;

		public PlayingCardControl(PlayingCard playingCard)
		{
			InitializeComponent();

			this.playingCard = playingCard;

			this.Click += new EventHandler(this.FlipCard);

			for (int i = 0; i < Controls.Count; i++)
			{
				Controls[i].Click += new EventHandler(this.FlipCard);
			}

			SetVisibility();
			SetValues();
			SetSuits();
		}

		private void FlipCard(object sender, EventArgs e) {
			this.card_backside.Visible = !this.card_backside.Visible;
		}

		private void SetValues()
		{
			switch (playingCard.Value)
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
					this.value = ((int)playingCard.Value).ToString();
					break;
			}

			this.top_left_value.Text = this.value;
			this.bottom_right_value.Text = this.value;
		}

		private void SetSuits()
		{
			char[] suits = new char[4] { '♥', '♣', '♠', '♦' };
			this.suit = suits[(int)suit];

			this.top_left_symbol.Text = this.suit.ToString();
			this.bottom_right_symbol.Text = this.suit.ToString();

			// sets the correct color of the symbols
			if (this.playingCard.Suit == Suit.Diamonds || this.playingCard.Suit == Suit.Hearts)
			{
				this.top_left_symbol.ForeColor = Color.Red;
				this.bottom_right_symbol.ForeColor = Color.Red;
			}
			else if (this.playingCard.Suit == Suit.Clubs || this.playingCard.Suit == Suit.Spades)
			{
				this.top_left_symbol.ForeColor = Color.Black;
				this.bottom_right_symbol.ForeColor = Color.Black;
			}
		}

		private void SetVisibility()
		{
			if (this.playingCard.isFaceUp == false)
			{
				this.card_backside.Visible = true;
			}
		}
	}
}
