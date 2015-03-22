namespace Labyrinthe
{
    partial class FormLabyrinth
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.UcLabyrinth = new Labyrinthe.UcLabyrinth();
			this.ucInformation1 = new Labyrinthe.UcInformations();
			this.SuspendLayout();
			// 
			// UcLabyrinth
			// 
			this.UcLabyrinth.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UcLabyrinth.Location = new System.Drawing.Point(10, 10);
			this.UcLabyrinth.Name = "UcLabyrinth";
			this.UcLabyrinth.Size = new System.Drawing.Size(1114, 527);
			this.UcLabyrinth.TabIndex = 0;
			this.UcLabyrinth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UcLabyrinth_KeyPress);
			// 
			// ucInformation1
			// 
			this.ucInformation1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ucInformation1.Location = new System.Drawing.Point(10, 537);
			this.ucInformation1.Name = "ucInformation1";
			this.ucInformation1.Size = new System.Drawing.Size(1114, 115);
			this.ucInformation1.TabIndex = 1;
			// 
			// FormLabyrinth
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1134, 662);
			this.Controls.Add(this.UcLabyrinth);
			this.Controls.Add(this.ucInformation1);
			this.MinimumSize = new System.Drawing.Size(1150, 700);
			this.Name = "FormLabyrinth";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Text = "The Labyrinth";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);

        }

        #endregion

        private UcLabyrinth UcLabyrinth;
        private UcInformations ucInformation1;
    }
}

