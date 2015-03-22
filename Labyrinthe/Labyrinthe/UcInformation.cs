using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labyrinth
{
	public partial class UcInformations : UserControl
	{
		#region Constructor

		public UcInformations()
		{
			InitializeComponent();
		}

		#endregion

		#region Events

		private void ChangeColor(object sender, EventArgs a)
		{
			PictureBox pb = (PictureBox)sender;
			if (CdChangeColors.ShowDialog() == DialogResult.OK)
				pb.BackColor = CdChangeColors.Color;
		}

		#endregion
	}
}
