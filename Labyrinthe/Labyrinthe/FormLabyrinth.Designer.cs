﻿namespace Labyrinth
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
			this.UcGestion = new Labyrinth.UcGestion();
			this.SuspendLayout();
			// 
			// UcGestion
			// 
			this.UcGestion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UcGestion.Location = new System.Drawing.Point(10, 10);
			this.UcGestion.Name = "UcGestion";
			this.UcGestion.Size = new System.Drawing.Size(1464, 942);
			this.UcGestion.TabIndex = 0;
			// 
			// FormLabyrinth
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1484, 962);
			this.Controls.Add(this.UcGestion);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1150, 700);
			this.Name = "FormLabyrinth";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "The Labyrinth";
			this.ResumeLayout(false);

        }

		#endregion

		private Labyrinth.UcGestion UcGestion;
	}
}

