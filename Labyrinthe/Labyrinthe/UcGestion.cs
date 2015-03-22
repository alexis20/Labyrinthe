using System.Drawing;
using System.Windows.Forms;

namespace Labyrinth
{
	public partial class UcGestion : UserControl
	{
		#region Variables

		private LabyrinthGenerator labyrinth = null;

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
			labyrinth = new LabyrinthGenerator(UcLabyrinth.Width / 20, UcLabyrinth.Height / 20);

			UcGestionInformation.Display(labyrinth);
		}

		#endregion

		#region Events

		private void UcGestionInformation_Start(object sender, System.EventArgs e)
		{
			UcLabyrinth.Display(labyrinth);
		}


		private void UcGestionInformation_Restart(object sender, System.EventArgs e)
		{
			labyrinth = new LabyrinthGenerator(UcLabyrinth.Width / 20, UcLabyrinth.Height / 20);
			UcLabyrinth.Display(labyrinth);
        }


		private void UcLabyrinth_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar.Equals('w'))
				labyrinth.MovePlayer(new Point(labyrinth.CurrentTile.X, labyrinth.CurrentTile.Y + 1));
			else if (e.KeyChar.Equals('a'))
				labyrinth.MovePlayer(new Point(labyrinth.CurrentTile.X - 1, labyrinth.CurrentTile.Y));
			else if (e.KeyChar.Equals('s'))
				labyrinth.MovePlayer(new Point(labyrinth.CurrentTile.X, labyrinth.CurrentTile.Y - 1));
			else if (e.KeyChar.Equals('d'))
				labyrinth.MovePlayer(new Point(labyrinth.CurrentTile.X + 1, labyrinth.CurrentTile.Y));

			UcLabyrinth.Display(labyrinth);
		}

		#endregion
	}
}
