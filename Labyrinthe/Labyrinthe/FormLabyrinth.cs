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
        public FormLabyrinth()
        {
            InitializeComponent();

            UcLabyrinth.Display();
        }
    }
}
