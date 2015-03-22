using System.Drawing;
using System.Windows.Forms;

namespace Labyrinthe
{
	public partial class UcLabyrinth : UserControl
	{
		#region Properties

		Bitmap image = null;

		#endregion

		#region Constructor

		public UcLabyrinth()
		{
			InitializeComponent();
		}

		#endregion

		#region Methods

		public void Display(Bitmap pImage)
		{
			image = pImage;
			PbLabyrinth.Image = pImage;
		}

		#endregion
	}
}