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
	public partial class GameOverForm : Form
	{
		public GameOverForm()
		{
			InitializeComponent();
		}

		private void btnPlayAgain_Click(object sender, EventArgs e)
		{
			this.Hide();
			var newWindow = new ShotgunGame();
			newWindow.Closed += (s, args) => this.Close();
			newWindow.Show();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		public void Winner(string winner)
		{
			lblWinner.Text = winner + " WON!";
		}
	}
}
