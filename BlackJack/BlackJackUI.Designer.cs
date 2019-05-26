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
			this.SuspendLayout();
			// 
			// hit_button
			// 
			this.hit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hit_button.Location = new System.Drawing.Point(526, 461);
			this.hit_button.Name = "hit_button";
			this.hit_button.Size = new System.Drawing.Size(102, 34);
			this.hit_button.TabIndex = 0;
			this.hit_button.Text = "Hit";
			this.hit_button.UseVisualStyleBackColor = true;
			this.hit_button.Click += new System.EventHandler(this.Hit_button_Click);
			// 
			// BlackJackUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Green;
			this.ClientSize = new System.Drawing.Size(1186, 693);
			this.Controls.Add(this.hit_button);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "BlackJackUI";
			this.Text = "Visual Card Deck";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button hit_button;
	}
}

