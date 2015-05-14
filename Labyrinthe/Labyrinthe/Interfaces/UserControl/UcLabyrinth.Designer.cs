namespace Labyrinth
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
			this.PbLabyrinth = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.PbLabyrinth)).BeginInit();
			this.SuspendLayout();
			// 
			// PbLabyrinth
			// 
			this.PbLabyrinth.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PbLabyrinth.Location = new System.Drawing.Point(0, 0);
			this.PbLabyrinth.Name = "PbLabyrinth";
			this.PbLabyrinth.Size = new System.Drawing.Size(950, 700);
			this.PbLabyrinth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PbLabyrinth.TabIndex = 0;
			this.PbLabyrinth.TabStop = false;
			// 
			// UcLabyrinth
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.PbLabyrinth);
			this.Name = "UcLabyrinth";
			this.Size = new System.Drawing.Size(950, 700);
			((System.ComponentModel.ISupportInitialize)(this.PbLabyrinth)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbLabyrinth;
    }
}
