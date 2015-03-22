using System.Drawing;
using System.Windows.Forms;

namespace Labyrinth
{
	public partial class FormLabyrinth : Form
	{
		#region Variable

		LabyrinthGenerator labyrinth = null;

		#endregion

		#region Constructor

		public FormLabyrinth()
		{
			InitializeComponent();

			labyrinth = new LabyrinthGenerator(UcLabyrinth.Width / 20, UcLabyrinth.Height / 20);
			UcLabyrinth.Display(labyrinth.DisplayLabyrinth());
		}

		#endregion

		#region Event

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
