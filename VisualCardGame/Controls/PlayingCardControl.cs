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
		public PlayingCardControl(PlayingCard playingCard)
		{
			InitializeComponent();

			string cardValue = "1";

			// set the value
			if (playingCard.Value == 0)
			{
				switch (playingCard.SpecialValue)
				{
					case Value.Ace: cardValue = "A";
						break;
					case Value.Jack: cardValue = "J";
						break;
					case Value.Queen: cardValue = "Q";
						break;
					case Value.King: cardValue = "K";
						break;
				}
			} 
			else
			{
				cardValue = playingCard.Value.ToString();
			}

			this.top_left_value.Text = cardValue;
			this.bottom_right_value.Text = cardValue;
			
			// sets the symbol
			char[] symbols = new char[4] { '♥', '♣', '♠', '♦' };
			char symbol = symbols[(int)playingCard.Symbol];
			
			this.top_left_symbol.Text = symbol.ToString();
			this.bottom_right_symbol.Text = symbol.ToString();

			// sets the correct color of the symbols
			if (playingCard.Symbol == Suit.Diamonds || playingCard.Symbol == Suit.Hearts)
			{
				this.top_left_symbol.ForeColor = Color.Red;
				this.bottom_right_symbol.ForeColor = Color.Red;
			}
			else if (playingCard.Symbol == Suit.Clubs || playingCard.Symbol == Suit.Spades)
			{
				this.top_left_symbol.ForeColor = Color.Black;
				this.bottom_right_symbol.ForeColor = Color.Black;
			}
		}
	}
}
