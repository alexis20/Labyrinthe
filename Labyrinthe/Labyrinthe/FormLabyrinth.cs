using System.Drawing;
using System.Windows.Forms;

namespace Labyrinthe
{
	public partial class FormLabyrinth : Form
	{
		#region Variables

		private const int TileSize = 15;
		LabyrinthGenerator labyrinth = null;

		#endregion

		#region Constructor

		public FormLabyrinth()
		{
			InitializeComponent();

			labyrinth = new LabyrinthGenerator(UcLabyrinth.Width / 10, UcLabyrinth.Height / 9, TileSize);
			UcLabyrinth.Display(labyrinth.DisplayLabyrinth());
		}

		#endregion

		#region Events

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

			UcLabyrinth.Display(labyrinth.DisplayLabyrinth());
		}

		#endregion
	}
}
