namespace BlackJack.Controls
{
	partial class PlayingCardControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.top_left_symbol = new System.Windows.Forms.Label();
			this.bottom_right_symbol = new System.Windows.Forms.Label();
			this.top_left_suit = new System.Windows.Forms.Label();
			this.bottom_right_suit = new System.Windows.Forms.Label();
			this.card_backside = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.card_backside)).BeginInit();
			this.SuspendLayout();
			// 
			// top_left_symbol
			// 
			this.top_left_symbol.AutoSize = true;
			this.top_left_symbol.Location = new System.Drawing.Point(3, 0);
			this.top_left_symbol.Name = "top_left_symbol";
			this.top_left_symbol.Size = new System.Drawing.Size(16, 17);
			this.top_left_symbol.TabIndex = 0;
			this.top_left_symbol.Text = "2";
			// 
			// bottom_right_symbol
			// 
			this.bottom_right_symbol.AutoSize = true;
			this.bottom_right_symbol.Location = new System.Drawing.Point(61, 108);
			this.bottom_right_symbol.Name = "bottom_right_symbol";
			this.bottom_right_symbol.Size = new System.Drawing.Size(16, 17);
			this.bottom_right_symbol.TabIndex = 1;
			this.bottom_right_symbol.Text = "2";
			// 
			// top_left_suit
			// 
			this.top_left_suit.AutoSize = true;
			this.top_left_suit.ForeColor = System.Drawing.Color.Red;
			this.top_left_suit.Location = new System.Drawing.Point(3, 17);
			this.top_left_suit.Name = "top_left_suit";
			this.top_left_suit.Size = new System.Drawing.Size(16, 17);
			this.top_left_suit.TabIndex = 2;
			this.top_left_suit.Text = "♥";
			// 
			// bottom_right_suit
			// 
			this.bottom_right_suit.AutoSize = true;
			this.bottom_right_suit.ForeColor = System.Drawing.Color.Red;
			this.bottom_right_suit.Location = new System.Drawing.Point(61, 91);
			this.bottom_right_suit.Name = "bottom_right_suit";
			this.bottom_right_suit.Size = new System.Drawing.Size(16, 17);
			this.bottom_right_suit.TabIndex = 3;
			this.bottom_right_suit.Text = "♥";
			// 
			// card_backside
			// 
			this.card_backside.Image = global::BlackJack.Properties.Resources.playingcard_back;
			this.card_backside.Location = new System.Drawing.Point(0, 0);
			this.card_backside.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.card_backside.Name = "card_backside";
			this.card_backside.Size = new System.Drawing.Size(80, 126);
			this.card_backside.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.card_backside.TabIndex = 4;
			this.card_backside.TabStop = false;
			this.card_backside.Visible = false;
			// 
			// PlayingCardControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.card_backside);
			this.Controls.Add(this.bottom_right_suit);
			this.Controls.Add(this.top_left_suit);
			this.Controls.Add(this.bottom_right_symbol);
			this.Controls.Add(this.top_left_symbol);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "PlayingCardControl";
			this.Size = new System.Drawing.Size(80, 126);
			((System.ComponentModel.ISupportInitialize)(this.card_backside)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label top_left_symbol;
		private System.Windows.Forms.Label bottom_right_symbol;
		private System.Windows.Forms.Label top_left_suit;
		private System.Windows.Forms.Label bottom_right_suit;
		private System.Windows.Forms.PictureBox card_backside;
	}
}
