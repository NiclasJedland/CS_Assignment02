namespace Assignment02
{
	partial class GameOverForm
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
			if(disposing && (components != null))
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
			this.btnExit = new System.Windows.Forms.Button();
			this.btnPlayAgain = new System.Windows.Forms.Button();
			this.lblWinner = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(30, 97);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 53);
			this.btnExit.TabIndex = 0;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnPlayAgain
			// 
			this.btnPlayAgain.Location = new System.Drawing.Point(180, 97);
			this.btnPlayAgain.Name = "btnPlayAgain";
			this.btnPlayAgain.Size = new System.Drawing.Size(75, 53);
			this.btnPlayAgain.TabIndex = 1;
			this.btnPlayAgain.Text = "Play Again?";
			this.btnPlayAgain.UseVisualStyleBackColor = true;
			this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
			// 
			// lblWinner
			// 
			this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWinner.Location = new System.Drawing.Point(12, 9);
			this.lblWinner.Name = "lblWinner";
			this.lblWinner.Size = new System.Drawing.Size(260, 85);
			this.lblWinner.TabIndex = 2;
			this.lblWinner.Text = "COMPUTER WON!";
			this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// GameOverForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 170);
			this.Controls.Add(this.lblWinner);
			this.Controls.Add(this.btnPlayAgain);
			this.Controls.Add(this.btnExit);
			this.Name = "GameOverForm";
			this.Text = "GameOverForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnPlayAgain;
		private System.Windows.Forms.Label lblWinner;
	}
}