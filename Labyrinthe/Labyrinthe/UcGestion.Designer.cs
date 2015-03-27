namespace Labyrinth
{
	partial class UcGestion
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.TlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.UcLabyrinth = new Labyrinth.UcLabyrinth();
            this.UcGestionInformation = new Labyrinth.UcGestionInformation();
            this.TlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpMain
            // 
            this.TlpMain.ColumnCount = 1;
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpMain.Controls.Add(this.UcLabyrinth, 0, 0);
            this.TlpMain.Controls.Add(this.UcGestionInformation, 0, 1);
            this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpMain.Location = new System.Drawing.Point(0, 0);
            this.TlpMain.Name = "TlpMain";
            this.TlpMain.RowCount = 2;
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpMain.Size = new System.Drawing.Size(979, 554);
            this.TlpMain.TabIndex = 0;
            // 
            // UcLabyrinth
            // 
            this.UcLabyrinth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcLabyrinth.Location = new System.Drawing.Point(3, 3);
            this.UcLabyrinth.Name = "UcLabyrinth";
            this.UcLabyrinth.Size = new System.Drawing.Size(973, 422);
            this.UcLabyrinth.TabIndex = 0;
            this.UcLabyrinth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UcLabyrinth_KeyUp);
            // 
            // UcGestionInformation
            // 
            this.UcGestionInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcGestionInformation.Location = new System.Drawing.Point(3, 431);
            this.UcGestionInformation.Name = "UcGestionInformation";
            this.UcGestionInformation.Size = new System.Drawing.Size(973, 120);
            this.UcGestionInformation.TabIndex = 1;
            this.UcGestionInformation.Start += new System.EventHandler(this.UcGestionInformation_Start);
            this.UcGestionInformation.Restart += new System.EventHandler(this.UcGestionInformation_Restart);
            // 
            // UcGestion
            // 
            this.Controls.Add(this.TlpMain);
            this.Name = "UcGestion";
            this.Size = new System.Drawing.Size(979, 554);
            this.TlpMain.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.TableLayoutPanel TlpMain;
        private UcLabyrinth UcLabyrinth;
        private UcGestionInformation UcGestionInformation;
	}
}
