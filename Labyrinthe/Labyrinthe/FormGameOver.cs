using System.Windows.Forms;

namespace Labyrinth
{
	public partial class FormGameOver : Form
	{
		#region Constructors

		public FormGameOver()
		{
			InitializeComponent();

			LblTitle.Text = string.Empty;
			TxtTime.Text = string.Empty;

			TxtStepsRemaining.Text = string.Empty;
			TxtTotalSteps.Text = string.Empty;

			TxtBonusStepsRemaining.Text = string.Empty;
			TxtTotalBonusSteps.Text = string.Empty;
			TxtTotalBonusStepsTaken.Text = string.Empty;

			TxtBonusTorchRemaining.Text = string.Empty;
			TxtTotalBonusTorch.Text = string.Empty;
			TxtTotalBonusTorchTaken.Text = string.Empty;
		}


		public FormGameOver(LabyrinthManager pLabyrinth, int pTime)
		{
			InitializeComponent();

			LblTitle.Text = pLabyrinth.IsWinner ? "YOU WIN !" : "YOU LOSE !";
			TxtTime.Text = (pTime / 60) + ":" + (pTime % 60);

			TxtStepsRemaining.Text = pLabyrinth.StepsRemaining.ToString();
			TxtTotalSteps.Text = pLabyrinth.TotalSteps.ToString();

			TxtBonusStepsRemaining.Text = pLabyrinth.BonusStepsRemaining.ToString();
			TxtTotalBonusSteps.Text = pLabyrinth.TotalBonusSteps.ToString();
			TxtTotalBonusStepsTaken.Text = pLabyrinth.BonusStepsTaken.ToString();

			TxtBonusTorchRemaining.Text = pLabyrinth.BonusTorchRemaining.ToString();
			TxtTotalBonusTorch.Text = pLabyrinth.TotalBonusTorch.ToString();
			TxtTotalBonusTorchTaken.Text = pLabyrinth.BonusTorchTaken.ToString();
		}

		#endregion

		#region Events

		private void BtnExit_Click(object sender, System.EventArgs e)
		{
			if (MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				Application.Exit();
		}

		#endregion
	}
}
