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
    public partial class UcInformation : UserControl
    {
        #region Constructor
        public UcInformation()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        public void Display(LabyrinthManager pLabyrinth)
        {
            TxtStepsRemaining.Text = pLabyrinth.StepsRemaining.ToString();
            TxtBonusStepsRemaining.Text = pLabyrinth.BonusStepsRemaining.ToString();
            TxtBonusTorchRemaining.Text = pLabyrinth.BonusTorchRemaining.ToString();
        }

        #endregion
    }
}
