using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment02
{
	public partial class ShotgunGame : Form
	{
		Random rnd = new Random();
		public ShotgunGame()
		{
			InitializeComponent();
			ChangeColorOfShootButton();
			lblYourPick.Text = "";
			lblComputerPick.Text = "";
		}

		void ComputerPick()
		{
			int playerAmmo = CheckAmountOfAmmo(lblYourAmmo.Text);
			int computerAmmo = CheckAmountOfAmmo(lblComputerAmmo.Text);
			int pick = -1;

			if(computerAmmo >= 3)
				pick = 3;
			else if(computerAmmo == 0 && playerAmmo == 0)
				pick = 0;
			else if(computerAmmo >= 1 && playerAmmo == 0 ) // 2/3 chance to shoot if player doesn't have ammo and computer do
			{
				pick = rnd.Next(0, 3);
				if(pick == 1)
					pick = 2;
			}
			else if(computerAmmo == 0 && playerAmmo >= 1) // 2/3 chance to block if player has ammo and computer doesn't
			{
				pick = rnd.Next(0, 3);
				if(pick == 2)
					pick = 1;
			}
			else if(computerAmmo >= 1) //slightly higher chance to shoot over block/load
			{
				pick = rnd.Next(0, 4);
				if(pick > 2)
					pick = 2;
			}
			else //will only block or load
				pick = rnd.Next(0, 2);

			int ammo = int.Parse(lblComputerAmmo.Text);
			switch(pick)
			{
				case 0://Load Ammo
					ammo++;
					lblComputerPick.Text = "Load";
					lblComputerAmmo.Text = ammo.ToString();
					break;
				case 1://Block
					lblComputerPick.Text = "Block";
					break;
				case 2://Shoot
					ammo--;
					lblComputerPick.Text = "Shoot";
					lblComputerAmmo.Text = ammo.ToString();
					break;
				case 3: //Shotgun
					ammo -= 3;
					lblComputerPick.Text = "Shotgun";
					lblComputerAmmo.Text = ammo.ToString();
					break;
				default:
					break;
			}
		}

		int CheckAmountOfAmmo(string labelText)
		{
			return int.Parse(labelText);
		}

		private void btnLoadAmmo_Click(object sender, EventArgs e)
		{
			ComputerPick();
			lblYourPick.Text = "Load";
			int ammo = int.Parse(lblYourAmmo.Text);
			ammo++;
			lblYourAmmo.Text = ammo.ToString();
			CheckResult();
			ChangeColorOfShootButton();
		}

		private void btnBlock_Click(object sender, EventArgs e)
		{
			ComputerPick();
			lblYourPick.Text = "Block";
			CheckResult();
		}

		private void btnShoot_Click(object sender, EventArgs e)
		{
			if(int.Parse(lblYourAmmo.Text) >= 1)
			{
				ComputerPick();
				int ammo = int.Parse(lblYourAmmo.Text);
				ammo--;
				lblYourAmmo.Text = ammo.ToString();
				lblYourPick.Text = "Shoot";
				CheckResult();
			}
		}

		private void btnShotgun_Click(object sender, EventArgs e)
		{
			if(CheckAmountOfAmmo(lblYourAmmo.Text) >= 3)
			{
				ComputerPick();
				int ammo = int.Parse(lblYourAmmo.Text);
				ammo -= 3;
				lblYourAmmo.Text = ammo.ToString();
				lblYourPick.Text = "Shotgun";
				CheckResult();
			}
			ChangeColorOfShootButton();
		}

		void ChangeColorOfShootButton()
		{
			if(int.Parse(lblYourAmmo.Text) >= 1)
				btnShoot.ForeColor = Color.Black;
			else
				btnShoot.ForeColor = Color.DarkGray;

			if(CheckAmountOfAmmo(lblYourAmmo.Text) >= 3)
				btnShotgun.ForeColor = Color.Black;
			else
				btnShotgun.ForeColor = Color.DarkGray;
		}

		void CheckResult()
		{
			string playerPick = lblYourPick.Text;
			string computerPick = lblComputerPick.Text;
			switch(playerPick)
			{
				case "Load":
					if(computerPick == "Shoot" || computerPick == "Shotgun")
						GameOver("COMPUTER");
					break;
				case "Block":
					if(computerPick == "Shotgun")
						GameOver("COMPUTER");
					break;
				case "Shoot":
					if(computerPick == "Shotgun")
						GameOver("COMPUTER");
					else if(computerPick != "Shoot" && computerPick != "Block")
						GameOver("YOU");
					break;
				case "Shotgun":
					if(computerPick != "Shotgun")
						GameOver("YOU");
					break;
				default:
					break;
			}
		}

		void GameOver(string winner)
		{
			this.Hide();
			var newWindow = new GameOverForm();
			newWindow.Closed += (s, args) => this.Close();
			newWindow.Winner(winner);
			newWindow.Show();
		}
	}
}
