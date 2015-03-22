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
			this.UcLabyrinth = new Labyrinth.UcLabyrinth();
			this.UcGestionInformation = new Labyrinth.UcGestionInformation();
			this.SuspendLayout();
			// 
			// UcLabyrinth
			// 
			this.UcLabyrinth.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UcLabyrinth.Location = new System.Drawing.Point(0, 0);
			this.UcLabyrinth.Name = "UcLabyrinth";
			this.UcLabyrinth.Size = new System.Drawing.Size(1326, 635);
			this.UcLabyrinth.TabIndex = 1;
			this.UcLabyrinth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UcLabyrinth_KeyPress);
			// 
			// UcGestionInformation
			// 
			this.UcGestionInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.UcGestionInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.UcGestionInformation.Location = new System.Drawing.Point(0, 635);
			this.UcGestionInformation.Name = "UcGestionInformation";
			this.UcGestionInformation.Size = new System.Drawing.Size(1326, 115);
			this.UcGestionInformation.TabIndex = 0;
			this.UcGestionInformation.Start += new System.EventHandler(this.UcGestionInformation_Start);
			this.UcGestionInformation.Restart += new System.EventHandler(this.UcGestionInformation_Restart);
			// 
			// UcGestion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.UcLabyrinth);
			this.Controls.Add(this.UcGestionInformation);
			this.Name = "UcGestion";
			this.Size = new System.Drawing.Size(1326, 750);
			this.ResumeLayout(false);

		}

		#endregion

		private UcGestionInformation UcGestionInformation;
		private Labyrinth.UcLabyrinth UcLabyrinth;
	}
}
