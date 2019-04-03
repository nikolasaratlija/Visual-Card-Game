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
	public partial class Form1 : Form
	{
		public Form1()
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
				PlayingCardControl pcc = new PlayingCardControl(cardDeck.DeckList[i])
				{
					Location = new Point(x, y)
				};
				this.Controls.Add(pcc);
				nthCardOfSymbol++;

				if (nthCardOfSymbol % 13 == 0)
				{
					x = 0;
					y += pcc.Height + margin;
				}
				else
				{
					x += pcc.Width + margin;
				}
			}
		}
	}
}
