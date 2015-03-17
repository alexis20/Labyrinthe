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
            this.UcLabyrinthe = new Labyrinthe.UcLabyrinth();
            this.ucInformation1 = new Labyrinthe.UcInformations();
            this.SuspendLayout();
            // 
            // UcLabyrinthe
            // 
            this.UcLabyrinthe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcLabyrinthe.Location = new System.Drawing.Point(10, 10);
            this.UcLabyrinthe.Name = "UcLabyrinthe";
            this.UcLabyrinthe.Size = new System.Drawing.Size(1114, 527);
            this.UcLabyrinthe.TabIndex = 0;
            // 
            // ucInformation1
            // 
            this.ucInformation1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucInformation1.Location = new System.Drawing.Point(10, 537);
            this.ucInformation1.Name = "ucInformation1";
            this.ucInformation1.Size = new System.Drawing.Size(1114, 115);
            this.ucInformation1.TabIndex = 1;
            // 
            // FormLabyrinthe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 662);
            this.Controls.Add(this.UcLabyrinthe);
            this.Controls.Add(this.ucInformation1);
            this.MinimumSize = new System.Drawing.Size(1150, 700);
            this.Name = "FormLabyrinthe";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Le Labyrinthe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private UcLabyrinth UcLabyrinthe;
        private UcInformations ucInformation1;
    }
}

