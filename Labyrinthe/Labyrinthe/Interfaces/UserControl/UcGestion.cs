using System.Drawing;
using System.Windows.Forms;

namespace Labyrinth
{
	public partial class UcGestion : UserControl
	{
		#region Variables

		private LabyrinthManager labyrinth = null;
		private int time = 0;

		#endregion

		#region Constructor

		public UcGestion()
		{
			InitializeComponent();
		}

		#endregion

		#region Methods

		public void Display()
		{
			labyrinth = new LabyrinthManager(UcLabyrinth.Width, UcLabyrinth.Height);
			time = 0;

			UcGestionInformation.Display(labyrinth);
		}

		#endregion

		#region Events

		private void UcGestionInformation_Start(object sender, System.EventArgs e)
		{
			UcLabyrinth.Display(labyrinth);
			TmrGameTime.Enabled = true;
		}


		private void UcGestionInformation_Restart(object sender, System.EventArgs e)
		{
			Display();
			UcLabyrinth.Display(labyrinth);
			TmrGameTime.Enabled = true;
		}


		private void UcLabyrinth_KeyUp(object sender, KeyEventArgs e)
		{
			if (labyrinth.IsWinner || labyrinth.IsLoser) return;

			if (e.KeyCode == Keys.W)	// Move up
				labyrinth.MovePlayer(new Point(labyrinth.CurrentTile.X, labyrinth.CurrentTile.Y + 1));
			else if (e.KeyCode == Keys.A)	// Move left
				labyrinth.MovePlayer(new Point(labyrinth.CurrentTile.X - 1, labyrinth.CurrentTile.Y));
			else if (e.KeyCode == Keys.S)	// Move down
				labyrinth.MovePlayer(new Point(labyrinth.CurrentTile.X, labyrinth.CurrentTile.Y - 1));
			else if (e.KeyCode == Keys.D)	// Move right
				labyrinth.MovePlayer(new Point(labyrinth.CurrentTile.X + 1, labyrinth.CurrentTile.Y));

			UcLabyrinth.Display(labyrinth);
			UcGestionInformation.Display(labyrinth);

			// Check if game is over
			if (labyrinth.IsWinner || labyrinth.IsLoser)
			{
				TmrGameTime.Enabled = false;

				if (new FormGameOver(labyrinth, time).ShowDialog() == DialogResult.Retry)
				{
					Display();
					UcLabyrinth.Display(labyrinth);
					TmrGameTime.Enabled = true;
				}
			}
		}


		private void TmrGameTime_Tick(object sender, System.EventArgs e)
		{
			++time;
		}

		#endregion
	}
}
