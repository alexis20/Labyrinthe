using System.Windows.Forms;

namespace Labyrinth
{
	public partial class FormLabyrinth : Form
	{
		#region Constructor

		public FormLabyrinth()
		{
			InitializeComponent();

			UcGestion.Display();
		}

		#endregion
	}
}
