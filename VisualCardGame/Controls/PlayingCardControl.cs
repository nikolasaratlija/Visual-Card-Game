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
					case SpecialValue.ace: cardValue = "A";
						break;
					case SpecialValue.jack: cardValue = "J";
						break;
					case SpecialValue.queen: cardValue = "Q";
						break;
					case SpecialValue.king: cardValue = "K";
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
			if (playingCard.Symbol == Symbol.diamonds || playingCard.Symbol == Symbol.hearts)
			{
				this.top_left_symbol.ForeColor = Color.Red;
				this.bottom_right_symbol.ForeColor = Color.Red;
			}
			else if (playingCard.Symbol == Symbol.clubs || playingCard.Symbol == Symbol.spades)
			{
				this.top_left_symbol.ForeColor = Color.Black;
				this.bottom_right_symbol.ForeColor = Color.Black;
			}
		}
	}
}
