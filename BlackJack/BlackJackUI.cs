using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackJack.Entities;
using BlackJack.Controls;

namespace BlackJack
{
	public partial class BlackJackUI : Form
	{
		public BlackJackUI()
		{
			InitializeComponent();

			Dictionary<Value, int> specialValue = new Dictionary<Value, int>
			{
				{ Value.Jack, 10 },
				{ Value.Queen, 10 },
				{ Value.King, 10 }
			};

			ShowDeck();
			//ShowTwoCards();
		}

		private void ShowTwoCards()
		{
			Dealer dealer = new Dealer(new PlayingCardDeck());
			PlayingCard cardOne = dealer.DealCard();
			PlayingCard cardTwo = dealer.DealCard();

			PlayingCardControl cardControlOne = new PlayingCardControl(cardOne)
			{
				Location = new Point(15, 15)
			};

			PlayingCardControl cardControlTwo = new PlayingCardControl(cardTwo)
			{
				Location = new Point(90, 15)
			};

			Controls.Add(cardControlOne);
			Controls.Add(cardControlTwo);
		}

		private void ShowDeck()
		{
			PlayingCardDeck cardDeck = new PlayingCardDeck();

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
	}
}
