using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labyrinthe
{
	public partial class FormLabyrinth : Form
	{
		#region Constructor

		public FormLabyrinth()
		{
			InitializeComponent();

			UcLabyrinth.Display();
		}

		#endregion

		#region Events

		private void UcLabyrinth_KeyPress(object sender, KeyPressEventArgs e)
		{

		}

		#endregion
	}
}
