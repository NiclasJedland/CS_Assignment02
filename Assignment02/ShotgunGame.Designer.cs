namespace Assignment02
{
	partial class ShotgunGame
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
			this.btnLoadAmmo = new System.Windows.Forms.Button();
			this.btnBlock = new System.Windows.Forms.Button();
			this.btnShoot = new System.Windows.Forms.Button();
			this.lblYourAmmoText = new System.Windows.Forms.Label();
			this.lblComputerAmmoText = new System.Windows.Forms.Label();
			this.lblYourPickText = new System.Windows.Forms.Label();
			this.lblComputerPickText = new System.Windows.Forms.Label();
			this.lblComputerAmmo = new System.Windows.Forms.Label();
			this.lblYourAmmo = new System.Windows.Forms.Label();
			this.lblYourPick = new System.Windows.Forms.Label();
			this.lblComputerPick = new System.Windows.Forms.Label();
			this.btnShotgun = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnLoadAmmo
			// 
			this.btnLoadAmmo.Location = new System.Drawing.Point(6, 124);
			this.btnLoadAmmo.Margin = new System.Windows.Forms.Padding(4);
			this.btnLoadAmmo.Name = "btnLoadAmmo";
			this.btnLoadAmmo.Size = new System.Drawing.Size(99, 51);
			this.btnLoadAmmo.TabIndex = 0;
			this.btnLoadAmmo.Text = "Load";
			this.btnLoadAmmo.UseVisualStyleBackColor = true;
			this.btnLoadAmmo.Click += new System.EventHandler(this.btnLoadAmmo_Click);
			// 
			// btnBlock
			// 
			this.btnBlock.Location = new System.Drawing.Point(113, 124);
			this.btnBlock.Margin = new System.Windows.Forms.Padding(4);
			this.btnBlock.Name = "btnBlock";
			this.btnBlock.Size = new System.Drawing.Size(99, 51);
			this.btnBlock.TabIndex = 1;
			this.btnBlock.Text = "Block";
			this.btnBlock.UseVisualStyleBackColor = true;
			this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
			// 
			// btnShoot
			// 
			this.btnShoot.Location = new System.Drawing.Point(220, 124);
			this.btnShoot.Margin = new System.Windows.Forms.Padding(4);
			this.btnShoot.Name = "btnShoot";
			this.btnShoot.Size = new System.Drawing.Size(99, 51);
			this.btnShoot.TabIndex = 2;
			this.btnShoot.Text = "Shoot";
			this.btnShoot.UseVisualStyleBackColor = true;
			this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
			// 
			// lblYourAmmoText
			// 
			this.lblYourAmmoText.AutoSize = true;
			this.lblYourAmmoText.Location = new System.Drawing.Point(16, 11);
			this.lblYourAmmoText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblYourAmmoText.Name = "lblYourAmmoText";
			this.lblYourAmmoText.Size = new System.Drawing.Size(89, 17);
			this.lblYourAmmoText.TabIndex = 3;
			this.lblYourAmmoText.Text = "Your Ammo: ";
			// 
			// lblComputerAmmoText
			// 
			this.lblComputerAmmoText.AutoSize = true;
			this.lblComputerAmmoText.Location = new System.Drawing.Point(279, 12);
			this.lblComputerAmmoText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblComputerAmmoText.Name = "lblComputerAmmoText";
			this.lblComputerAmmoText.Size = new System.Drawing.Size(120, 17);
			this.lblComputerAmmoText.TabIndex = 4;
			this.lblComputerAmmoText.Text = " :Computer Ammo";
			// 
			// lblYourPickText
			// 
			this.lblYourPickText.AutoSize = true;
			this.lblYourPickText.Location = new System.Drawing.Point(17, 43);
			this.lblYourPickText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblYourPickText.Name = "lblYourPickText";
			this.lblYourPickText.Size = new System.Drawing.Size(87, 17);
			this.lblYourPickText.TabIndex = 5;
			this.lblYourPickText.Text = "You Picked: ";
			// 
			// lblComputerPickText
			// 
			this.lblComputerPickText.AutoSize = true;
			this.lblComputerPickText.Location = new System.Drawing.Point(275, 43);
			this.lblComputerPickText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblComputerPickText.Name = "lblComputerPickText";
			this.lblComputerPickText.Size = new System.Drawing.Size(123, 17);
			this.lblComputerPickText.TabIndex = 6;
			this.lblComputerPickText.Text = " :Computer Picked";
			// 
			// lblComputerAmmo
			// 
			this.lblComputerAmmo.Location = new System.Drawing.Point(225, 12);
			this.lblComputerAmmo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblComputerAmmo.Name = "lblComputerAmmo";
			this.lblComputerAmmo.Size = new System.Drawing.Size(57, 16);
			this.lblComputerAmmo.TabIndex = 7;
			this.lblComputerAmmo.Text = "0";
			this.lblComputerAmmo.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblYourAmmo
			// 
			this.lblYourAmmo.AutoSize = true;
			this.lblYourAmmo.Location = new System.Drawing.Point(95, 12);
			this.lblYourAmmo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblYourAmmo.Name = "lblYourAmmo";
			this.lblYourAmmo.Size = new System.Drawing.Size(16, 17);
			this.lblYourAmmo.TabIndex = 8;
			this.lblYourAmmo.Text = "0";
			// 
			// lblYourPick
			// 
			this.lblYourPick.AutoSize = true;
			this.lblYourPick.Location = new System.Drawing.Point(103, 43);
			this.lblYourPick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblYourPick.Name = "lblYourPick";
			this.lblYourPick.Size = new System.Drawing.Size(83, 17);
			this.lblYourPick.TabIndex = 9;
			this.lblYourPick.Text = "Load Ammo";
			// 
			// lblComputerPick
			// 
			this.lblComputerPick.Location = new System.Drawing.Point(191, 43);
			this.lblComputerPick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblComputerPick.Name = "lblComputerPick";
			this.lblComputerPick.Size = new System.Drawing.Size(85, 16);
			this.lblComputerPick.TabIndex = 10;
			this.lblComputerPick.Text = "Load Ammo";
			this.lblComputerPick.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// btnShotgun
			// 
			this.btnShotgun.Location = new System.Drawing.Point(327, 124);
			this.btnShotgun.Margin = new System.Windows.Forms.Padding(4);
			this.btnShotgun.Name = "btnShotgun";
			this.btnShotgun.Size = new System.Drawing.Size(99, 51);
			this.btnShotgun.TabIndex = 11;
			this.btnShotgun.Text = "Shotgun";
			this.btnShotgun.UseVisualStyleBackColor = true;
			this.btnShotgun.Click += new System.EventHandler(this.btnShotgun_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(182, 74);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(200, 31);
			this.button1.TabIndex = 12;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// ShotgunGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(438, 188);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnShotgun);
			this.Controls.Add(this.lblComputerPick);
			this.Controls.Add(this.lblYourPick);
			this.Controls.Add(this.lblYourAmmo);
			this.Controls.Add(this.lblComputerAmmo);
			this.Controls.Add(this.lblComputerPickText);
			this.Controls.Add(this.lblYourPickText);
			this.Controls.Add(this.lblComputerAmmoText);
			this.Controls.Add(this.lblYourAmmoText);
			this.Controls.Add(this.btnShoot);
			this.Controls.Add(this.btnBlock);
			this.Controls.Add(this.btnLoadAmmo);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ShotgunGame";
			this.Text = "Shotgun";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLoadAmmo;
		private System.Windows.Forms.Button btnBlock;
		private System.Windows.Forms.Button btnShoot;
		private System.Windows.Forms.Label lblYourAmmoText;
		private System.Windows.Forms.Label lblComputerAmmoText;
		private System.Windows.Forms.Label lblYourPickText;
		private System.Windows.Forms.Label lblComputerPickText;
		private System.Windows.Forms.Label lblComputerAmmo;
		private System.Windows.Forms.Label lblYourAmmo;
		private System.Windows.Forms.Label lblYourPick;
		private System.Windows.Forms.Label lblComputerPick;
		private System.Windows.Forms.Button btnShotgun;
		private System.Windows.Forms.Button button1;
	}
}

