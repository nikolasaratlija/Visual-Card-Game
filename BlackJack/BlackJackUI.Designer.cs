namespace BlackJack
{
	partial class BlackJackUI
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.hit_button = new System.Windows.Forms.Button();
			this.reset_button = new System.Windows.Forms.Button();
			this.hand_value_label = new System.Windows.Forms.Label();
			this.player_bet_label = new System.Windows.Forms.Label();
			this.balance_amount_label = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// hit_button
			// 
			this.hit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hit_button.Location = new System.Drawing.Point(12, 408);
			this.hit_button.Name = "hit_button";
			this.hit_button.Size = new System.Drawing.Size(72, 29);
			this.hit_button.TabIndex = 0;
			this.hit_button.Text = "Hit";
			this.hit_button.UseVisualStyleBackColor = true;
			this.hit_button.Click += new System.EventHandler(this.Hit_button_Click);
			// 
			// reset_button
			// 
			this.reset_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reset_button.Location = new System.Drawing.Point(670, 12);
			this.reset_button.Name = "reset_button";
			this.reset_button.Size = new System.Drawing.Size(72, 29);
			this.reset_button.TabIndex = 1;
			this.reset_button.Text = "Reset";
			this.reset_button.UseVisualStyleBackColor = true;
			this.reset_button.Click += new System.EventHandler(this.Reset_button_Click);
			// 
			// hand_value_label
			// 
			this.hand_value_label.AutoSize = true;
			this.hand_value_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hand_value_label.ForeColor = System.Drawing.Color.White;
			this.hand_value_label.Location = new System.Drawing.Point(314, 410);
			this.hand_value_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.hand_value_label.Name = "hand_value_label";
			this.hand_value_label.Size = new System.Drawing.Size(126, 24);
			this.hand_value_label.TabIndex = 2;
			this.hand_value_label.Text = "Hand value: 0";
			this.hand_value_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// player_bet_label
			// 
			this.player_bet_label.AutoSize = true;
			this.player_bet_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.player_bet_label.ForeColor = System.Drawing.Color.White;
			this.player_bet_label.Location = new System.Drawing.Point(617, 413);
			this.player_bet_label.Name = "player_bet_label";
			this.player_bet_label.Size = new System.Drawing.Size(125, 24);
			this.player_bet_label.TabIndex = 4;
			this.player_bet_label.Text = "Bet amount: 0";
			// 
			// balance_amount_label
			// 
			this.balance_amount_label.AutoSize = true;
			this.balance_amount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.balance_amount_label.ForeColor = System.Drawing.Color.White;
			this.balance_amount_label.Location = new System.Drawing.Point(644, 389);
			this.balance_amount_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.balance_amount_label.Name = "balance_amount_label";
			this.balance_amount_label.Size = new System.Drawing.Size(98, 24);
			this.balance_amount_label.TabIndex = 5;
			this.balance_amount_label.Text = "Balance: 0";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(594, 356);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(37, 30);
			this.button2.TabIndex = 7;
			this.button2.Text = "+ 5";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(637, 356);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(46, 30);
			this.button3.TabIndex = 8;
			this.button3.Text = "+ 25";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(689, 356);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(53, 30);
			this.button4.TabIndex = 9;
			this.button4.Text = "+ 100";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// BlackJackUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Green;
			this.ClientSize = new System.Drawing.Size(754, 449);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.balance_amount_label);
			this.Controls.Add(this.player_bet_label);
			this.Controls.Add(this.hand_value_label);
			this.Controls.Add(this.reset_button);
			this.Controls.Add(this.hit_button);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "BlackJackUI";
			this.Text = "Visual Card Deck";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button hit_button;
		private System.Windows.Forms.Button reset_button;
		private System.Windows.Forms.Label hand_value_label;
		private System.Windows.Forms.Label player_bet_label;
		private System.Windows.Forms.Label balance_amount_label;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
	}
}

