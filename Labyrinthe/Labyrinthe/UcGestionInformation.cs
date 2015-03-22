using System;
using System.Windows.Forms;

namespace Labyrinth
{
	public partial class UcGestionInformation : UserControl
	{
		#region Properties

		public event EventHandler Start;
		public event EventHandler Restart;

		#endregion

		#region Constructor

		public UcGestionInformation()
		{
			InitializeComponent();
		}

		#endregion

		#region Methods

		public void Display(LabyrinthGenerator pLabyrinth)
		{

		}

		#endregion

		#region Events

		private void BtnStart_Click(object sender, EventArgs e)
		{
			BtnStart.Enabled = false;
			BtnRestart.Enabled = true;

			if (Start != null)
				Start(this, e);
		}


		private void BtnRestart_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do you really want to restart the game?", "Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (Restart != null)
					Restart(this, e);
			}
		}


		private void BtnExit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				Application.Exit();
		}

		#endregion
	}
}
