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
		#region properties

		PlayingCardDeck deck = new PlayingCardDeck();
		Player player;

		Point currentCardOffset = new Point(0, 0);
		Point cardOffset = new Point(13, -10);

		#endregion properties

		#region constructor

		public BlackJackUI()
		{
			InitializeComponent();
			player = new Player(deck);
		}

		#endregion constructor

		#region methods

		private void PlaceCard(PlayingCard card)
		{
			PlayingCardControl cardControl = new PlayingCardControl(card);

			cardControl.Left = (ClientSize.Width - cardControl.Width) / 2 + currentCardOffset.X;
			cardControl.Top = 300 + currentCardOffset.Y;
			Controls.Add(cardControl);
			cardControl.BringToFront();

			currentCardOffset.X += cardOffset.X;
			currentCardOffset.Y += cardOffset.Y;

			hand_value_label.Text = "Hand value: " + player.Value.ToString();
		}

		private void HandleBust()
		{
			hand_value_label.ForeColor = Color.Red;
			SwitchHitButtonEnabled();
		}

		private void SwitchHitButtonEnabled()
		{
			hit_button.Enabled = !hit_button.Enabled;
		}

		#region events

		private void Hit_button_Click(object sender, EventArgs e)
		{
			PlayingCard card = player.Hit();

			PlaceCard(card);

			if (player.IsBust) HandleBust();
		}

		private void Reset_button_Click(object sender, EventArgs e)
		{
			if (!hit_button.Enabled) SwitchHitButtonEnabled();
		}

		#endregion events

		#region debugging

		private void ShowDeck()
		{
			int y = 0;
			int x = 0;
			int margin = 15;

			int nthCardOfSuit = 0;
			int cardsPerSuit = 13;

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

		#endregion debugging

		#endregion methods
	}
}
