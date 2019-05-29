using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackJack.Entities;

namespace BlackJack.Controls
{
	public partial class PlayingCardControl : UserControl
	{
		private PlayingCard playingCard;
		private string symbol;
		private char suit;

		public PlayingCardControl(PlayingCard playingCard)
		{
			InitializeComponent();

			this.playingCard = playingCard;

			SetVisibility();
			SetSymbol();
			SetSuits();
		}

		public void FlipCard(object sender, EventArgs e) {
			this.card_backside.Visible = !this.card_backside.Visible;
		}

		private void SetSymbol()
		{
			switch (playingCard.Symbol)
			{
				case Symbol.Ace:
					this.symbol = "A";
					break;
				case Symbol.Jack:
					this.symbol = "J";
					break;
				case Symbol.Queen:
					this.symbol = "Q";
					break;
				case Symbol.King:
					this.symbol = "K";
					break;
				default:
					this.symbol = ((int)playingCard.Symbol).ToString();
					break;
			}

			this.top_left_symbol.Text = this.symbol;
			this.bottom_right_symbol.Text = this.symbol;
		}

		private void SetSuits()
		{
			char[] suits = new char[4] { '♥', '♣', '♠', '♦' };
			this.suit = suits[(int)playingCard.Suit];

			this.top_left_suit.Text = this.suit.ToString();
			this.bottom_right_suit.Text = this.suit.ToString();

			// sets the correct color of the symbols
			if (this.playingCard.Suit == Suit.Diamonds || this.playingCard.Suit == Suit.Hearts)
			{
				this.top_left_suit.ForeColor = Color.Red;
				this.bottom_right_suit.ForeColor = Color.Red;
			}
			else if (this.playingCard.Suit == Suit.Clubs || this.playingCard.Suit == Suit.Spades)
			{
				this.top_left_suit.ForeColor = Color.Black;
				this.bottom_right_suit.ForeColor = Color.Black;
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
