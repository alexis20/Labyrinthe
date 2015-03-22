using System.Drawing;
using System.Windows.Forms;

namespace Labyrinth
{
	public partial class UcLabyrinth : UserControl
	{

		#region Constructor

		public UcLabyrinth()
		{
			InitializeComponent();
		}

		#endregion

		#region Methods

		public void Display(LabyrinthGenerator pLabyrinth)
		{
			PbLabyrinth.Image = pLabyrinth.DisplayLabyrinth();
			Focus();
		}

		#endregion
	}
}