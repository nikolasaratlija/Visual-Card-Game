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
		Player player = new Player();

		int cardLocationOffsetX = 15;
		int cardLocationOffsetY = -25;
		// TODO: figure out a way to get access the Size property of PlayingCardControl
		Point nextCardLocation = new Point(300, 300);

		#endregion properties

		#region constructor

		public BlackJackUI()
		{
			InitializeComponent();
		}

		#endregion constructor

		#region methods

		private void PlaceCard(PlayingCard card)
		{
			PlayingCardControl cardControl = new PlayingCardControl(card)
			{
				Location = nextCardLocation
			};
			Controls.Add(cardControl);

			nextCardLocation.X += cardLocationOffsetX;
			nextCardLocation.Y += cardLocationOffsetY;

			hand_value_label.Text = player.Value.ToString();
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
			PlayingCard card = player.Hit(deck);

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
