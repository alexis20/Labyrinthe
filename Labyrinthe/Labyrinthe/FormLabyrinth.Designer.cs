namespace Labyrinth
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
			this.UcLabyrinth = new Labyrinth.UcLabyrinth();
			this.SuspendLayout();
			// 
			// UcLabyrinth
			// 
			this.UcLabyrinth.Location = new System.Drawing.Point(10, 10);
			this.UcLabyrinth.Name = "UcLabyrinth";
			this.UcLabyrinth.Size = new System.Drawing.Size(1464, 827);
			this.UcLabyrinth.TabIndex = 0;
			this.UcLabyrinth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UcLabyrinth_KeyPress);
			// 
			// FormLabyrinth
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1484, 962);
			this.Controls.Add(this.UcLabyrinth);
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

        private UcLabyrinth UcLabyrinth;
    }
}

