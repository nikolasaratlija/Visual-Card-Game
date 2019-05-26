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
		PlayingCardDeck deck = new PlayingCardDeck();
		Player player = new Player();

		int cardLocation = 15;


		public BlackJackUI()
		{
			InitializeComponent();
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
			int y = 0;
			int x = 0;
			int margin = 15;

			int nthCardOfSuit = 0;
			int cardsPerSuit = 12;

			for (int i = 0; i < deck.DeckList.Count; i++)
			{
				PlayingCardControl control = new PlayingCardControl(deck.DeckList[i])
				{
					Location = new Point(x, y)
				};
				this.Controls.Add(control);
				nthCardOfSuit++;

				if (nthCardOfSuit % cardsPerSuit == 0)
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

		private void Hit_button_Click(object sender, EventArgs e)
		{
			PlayingCard card = player.Hit(deck);

			PlayingCardControl cardControl = new PlayingCardControl(card)
			{
				Location = new Point(cardLocation, 15)
			};

			cardLocation += cardControl.Width + 15;

			Controls.Add(cardControl);
		}
	}
}
