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
			this.SuspendLayout();
			// 
			// hit_button
			// 
			this.hit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hit_button.Location = new System.Drawing.Point(13, 498);
			this.hit_button.Margin = new System.Windows.Forms.Padding(4);
			this.hit_button.Name = "hit_button";
			this.hit_button.Size = new System.Drawing.Size(136, 42);
			this.hit_button.TabIndex = 0;
			this.hit_button.Text = "Hit";
			this.hit_button.UseVisualStyleBackColor = true;
			this.hit_button.Click += new System.EventHandler(this.Hit_button_Click);
			// 
			// reset_button
			// 
			this.reset_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reset_button.Location = new System.Drawing.Point(857, 498);
			this.reset_button.Margin = new System.Windows.Forms.Padding(4);
			this.reset_button.Name = "reset_button";
			this.reset_button.Size = new System.Drawing.Size(136, 42);
			this.reset_button.TabIndex = 1;
			this.reset_button.Text = "Reset hand";
			this.reset_button.UseVisualStyleBackColor = true;
			this.reset_button.Click += new System.EventHandler(this.Reset_button_Click);
			// 
			// hand_value_label
			// 
			this.hand_value_label.AutoSize = true;
			this.hand_value_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hand_value_label.ForeColor = System.Drawing.Color.Snow;
			this.hand_value_label.Location = new System.Drawing.Point(277, 254);
			this.hand_value_label.Name = "hand_value_label";
			this.hand_value_label.Size = new System.Drawing.Size(26, 29);
			this.hand_value_label.TabIndex = 2;
			this.hand_value_label.Text = "0";
			// 
			// BlackJackUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Green;
			this.ClientSize = new System.Drawing.Size(1006, 553);
			this.Controls.Add(this.hand_value_label);
			this.Controls.Add(this.reset_button);
			this.Controls.Add(this.hit_button);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "BlackJackUI";
			this.Text = "Visual Card Deck";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button hit_button;
		private System.Windows.Forms.Button reset_button;
		private System.Windows.Forms.Label hand_value_label;
	}
}

