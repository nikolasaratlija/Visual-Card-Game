namespace VisualCardGame.Controls
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
			this.top_left_value = new System.Windows.Forms.Label();
			this.bottom_right_value = new System.Windows.Forms.Label();
			this.top_left_symbol = new System.Windows.Forms.Label();
			this.bottom_right_symbol = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// top_left_value
			// 
			this.top_left_value.AutoSize = true;
			this.top_left_value.Location = new System.Drawing.Point(3, 0);
			this.top_left_value.Name = "top_left_value";
			this.top_left_value.Size = new System.Drawing.Size(16, 17);
			this.top_left_value.TabIndex = 0;
			this.top_left_value.Text = "2";
			// 
			// bottom_right_value
			// 
			this.bottom_right_value.AutoSize = true;
			this.bottom_right_value.Location = new System.Drawing.Point(61, 108);
			this.bottom_right_value.Name = "bottom_right_value";
			this.bottom_right_value.Size = new System.Drawing.Size(16, 17);
			this.bottom_right_value.TabIndex = 1;
			this.bottom_right_value.Text = "2";
			// 
			// top_left_symbol
			// 
			this.top_left_symbol.AutoSize = true;
			this.top_left_symbol.ForeColor = System.Drawing.Color.Red;
			this.top_left_symbol.Location = new System.Drawing.Point(3, 17);
			this.top_left_symbol.Name = "top_left_symbol";
			this.top_left_symbol.Size = new System.Drawing.Size(16, 17);
			this.top_left_symbol.TabIndex = 2;
			this.top_left_symbol.Text = "♥";
			// 
			// bottom_right_symbol
			// 
			this.bottom_right_symbol.AutoSize = true;
			this.bottom_right_symbol.ForeColor = System.Drawing.Color.Red;
			this.bottom_right_symbol.Location = new System.Drawing.Point(61, 91);
			this.bottom_right_symbol.Name = "bottom_right_symbol";
			this.bottom_right_symbol.Size = new System.Drawing.Size(16, 17);
			this.bottom_right_symbol.TabIndex = 3;
			this.bottom_right_symbol.Text = "♥";
			// 
			// PlayingCardControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.bottom_right_symbol);
			this.Controls.Add(this.top_left_symbol);
			this.Controls.Add(this.bottom_right_value);
			this.Controls.Add(this.top_left_value);
			this.Name = "PlayingCardControl";
			this.Size = new System.Drawing.Size(80, 125);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label top_left_value;
		private System.Windows.Forms.Label bottom_right_value;
		private System.Windows.Forms.Label top_left_symbol;
		private System.Windows.Forms.Label bottom_right_symbol;
	}
}
