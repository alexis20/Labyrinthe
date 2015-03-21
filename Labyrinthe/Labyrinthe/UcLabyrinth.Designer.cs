namespace Labyrinthe
{
    partial class UcLabyrinth
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
            this.PbLabyrinthe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbLabyrinthe)).BeginInit();
            this.SuspendLayout();
            // 
            // PbLabyrinthe
            // 
            this.PbLabyrinthe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbLabyrinthe.Location = new System.Drawing.Point(0, 0);
            this.PbLabyrinthe.Name = "PbLabyrinthe";
            this.PbLabyrinthe.Size = new System.Drawing.Size(950, 700);
            this.PbLabyrinthe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLabyrinthe.TabIndex = 0;
            this.PbLabyrinthe.TabStop = false;
            // 
            // UcLabyrinth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PbLabyrinthe);
            this.Name = "UcLabyrinth";
            this.Size = new System.Drawing.Size(950, 700);
            ((System.ComponentModel.ISupportInitialize)(this.PbLabyrinthe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbLabyrinthe;
    }
}
