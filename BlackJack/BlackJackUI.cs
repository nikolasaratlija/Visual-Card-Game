using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualCardGame.Entities;
using VisualCardGame.Controls;

namespace VisualCardGame
{
	public partial class BlackJackUI : Form
	{
		public BlackJackUI()
		{
			InitializeComponent();
			ShowDeck();
		}

		private void ShowDeck()
		{
			PlayingDeck cardDeck = new PlayingDeck();

			int y = 0;
			int x = 0;
			int margin = 15;

			int nthCardOfSymbol = 0;

			for (int i = 0; i < cardDeck.DeckList.Count; i++)
			{
				PlayingCardControl control = new PlayingCardControl(cardDeck.DeckList[i])
				{
					Location = new Point(x, y)
				};
				this.Controls.Add(control);
				nthCardOfSymbol++;

				if (nthCardOfSymbol % 13 == 0)
				{
					x = 0;
					y += control.Height + margin;
				}
				else
				{
					x += control.Width + margin;
				}
			}
		}

		public List<PlayingCard> PickCardAtRandom(int amount)
		{
			// TODO;
			return new List<PlayingCard>();
		}
	}
}
