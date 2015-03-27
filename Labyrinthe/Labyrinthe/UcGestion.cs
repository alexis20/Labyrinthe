using System.Drawing;
using System.Windows.Forms;

namespace Labyrinth
{
	public partial class UcGestion : UserControl
	{
		#region Variables

		private LabyrinthManager labyrinth = null;

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
			//labyrinth = new LabyrinthManager(UcLabyrinth.Width, UcLabyrinth.Height);

			//UcGestionInformation.Display(labyrinth);
		}

		#endregion

		#region Events

		private void UcGestionInformation_Start(object sender, System.EventArgs e)
		{
			//UcLabyrinth.Display(labyrinth);
		}


		private void UcGestionInformation_Restart(object sender, System.EventArgs e)
		{
			Display();
			//UcLabyrinth.Display(labyrinth);
        }


		private void UcLabyrinth_KeyUp(object sender, KeyEventArgs e)
		{
			if (labyrinth.IsWinner || labyrinth.IsLoser) return;

			if (e.KeyCode == Keys.W)
				labyrinth.MovePlayer(new Point(labyrinth.CurrentTile.X, labyrinth.CurrentTile.Y + 1));
			else if (e.KeyCode == Keys.A)
				labyrinth.MovePlayer(new Point(labyrinth.CurrentTile.X - 1, labyrinth.CurrentTile.Y));
			else if (e.KeyCode == Keys.S)
				labyrinth.MovePlayer(new Point(labyrinth.CurrentTile.X, labyrinth.CurrentTile.Y - 1));
			else if (e.KeyCode == Keys.D)
				labyrinth.MovePlayer(new Point(labyrinth.CurrentTile.X + 1, labyrinth.CurrentTile.Y));

			//UcLabyrinth.Display(labyrinth);
			//UcGestionInformation.Display(labyrinth);

			if (labyrinth.IsWinner)
				MessageBox.Show("You won!");
			else if (labyrinth.IsLoser)
				MessageBox.Show("You lost!");
		}

		#endregion
	}
}
