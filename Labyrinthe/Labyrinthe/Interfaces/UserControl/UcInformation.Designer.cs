namespace Labyrinth
{
    partial class UcInformation
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
			this.TlpMain = new System.Windows.Forms.TableLayoutPanel();
			this.LblStepsRemaining = new System.Windows.Forms.Label();
			this.LblBonusStepsRemaining = new System.Windows.Forms.Label();
			this.LblBonusTorchRemaining = new System.Windows.Forms.Label();
			this.TxtStepsRemaining = new System.Windows.Forms.Label();
			this.TxtBonusStepsRemaining = new System.Windows.Forms.Label();
			this.TxtBonusTorchRemaining = new System.Windows.Forms.Label();
			this.FlpLegend = new System.Windows.Forms.FlowLayoutPanel();
			this.LblPlayer = new System.Windows.Forms.Label();
			this.PbPlayer = new System.Windows.Forms.PictureBox();
			this.LblExit = new System.Windows.Forms.Label();
			this.PbExit = new System.Windows.Forms.PictureBox();
			this.LblBonusSteps = new System.Windows.Forms.Label();
			this.PbBonusSteps = new System.Windows.Forms.PictureBox();
			this.LblBonusTorch = new System.Windows.Forms.Label();
			this.PbBonusTorch = new System.Windows.Forms.PictureBox();
			this.LblInstructions = new System.Windows.Forms.Label();
			this.TlpMain.SuspendLayout();
			this.FlpLegend.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PbPlayer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PbExit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PbBonusSteps)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PbBonusTorch)).BeginInit();
			this.SuspendLayout();
			// 
			// TlpMain
			// 
			this.TlpMain.ColumnCount = 2;
			this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TlpMain.Controls.Add(this.LblStepsRemaining, 0, 1);
			this.TlpMain.Controls.Add(this.LblBonusStepsRemaining, 0, 2);
			this.TlpMain.Controls.Add(this.LblBonusTorchRemaining, 0, 3);
			this.TlpMain.Controls.Add(this.TxtStepsRemaining, 1, 1);
			this.TlpMain.Controls.Add(this.TxtBonusStepsRemaining, 1, 2);
			this.TlpMain.Controls.Add(this.TxtBonusTorchRemaining, 1, 3);
			this.TlpMain.Controls.Add(this.FlpLegend, 0, 0);
			this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TlpMain.Location = new System.Drawing.Point(0, 0);
			this.TlpMain.Name = "TlpMain";
			this.TlpMain.RowCount = 4;
			this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.TlpMain.Size = new System.Drawing.Size(889, 124);
			this.TlpMain.TabIndex = 0;
			// 
			// LblStepsRemaining
			// 
			this.LblStepsRemaining.AutoSize = true;
			this.LblStepsRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblStepsRemaining.Location = new System.Drawing.Point(3, 31);
			this.LblStepsRemaining.Name = "LblStepsRemaining";
			this.LblStepsRemaining.Size = new System.Drawing.Size(124, 31);
			this.LblStepsRemaining.TabIndex = 0;
			this.LblStepsRemaining.Text = "Steps Remaining:";
			this.LblStepsRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// LblBonusStepsRemaining
			// 
			this.LblBonusStepsRemaining.AutoSize = true;
			this.LblBonusStepsRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblBonusStepsRemaining.Location = new System.Drawing.Point(3, 62);
			this.LblBonusStepsRemaining.Name = "LblBonusStepsRemaining";
			this.LblBonusStepsRemaining.Size = new System.Drawing.Size(124, 31);
			this.LblBonusStepsRemaining.TabIndex = 1;
			this.LblBonusStepsRemaining.Text = "Bonus Steps Remaining:";
			this.LblBonusStepsRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// LblBonusTorchRemaining
			// 
			this.LblBonusTorchRemaining.AutoSize = true;
			this.LblBonusTorchRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblBonusTorchRemaining.Location = new System.Drawing.Point(3, 93);
			this.LblBonusTorchRemaining.Name = "LblBonusTorchRemaining";
			this.LblBonusTorchRemaining.Size = new System.Drawing.Size(124, 31);
			this.LblBonusTorchRemaining.TabIndex = 2;
			this.LblBonusTorchRemaining.Text = "Bonus Torch Remaining:";
			this.LblBonusTorchRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TxtStepsRemaining
			// 
			this.TxtStepsRemaining.AutoSize = true;
			this.TxtStepsRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtStepsRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtStepsRemaining.Location = new System.Drawing.Point(133, 31);
			this.TxtStepsRemaining.Name = "TxtStepsRemaining";
			this.TxtStepsRemaining.Size = new System.Drawing.Size(753, 31);
			this.TxtStepsRemaining.TabIndex = 3;
			this.TxtStepsRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TxtBonusStepsRemaining
			// 
			this.TxtBonusStepsRemaining.AutoSize = true;
			this.TxtBonusStepsRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtBonusStepsRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtBonusStepsRemaining.Location = new System.Drawing.Point(133, 62);
			this.TxtBonusStepsRemaining.Name = "TxtBonusStepsRemaining";
			this.TxtBonusStepsRemaining.Size = new System.Drawing.Size(753, 31);
			this.TxtBonusStepsRemaining.TabIndex = 4;
			this.TxtBonusStepsRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TxtBonusTorchRemaining
			// 
			this.TxtBonusTorchRemaining.AutoSize = true;
			this.TxtBonusTorchRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtBonusTorchRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtBonusTorchRemaining.Location = new System.Drawing.Point(133, 93);
			this.TxtBonusTorchRemaining.Name = "TxtBonusTorchRemaining";
			this.TxtBonusTorchRemaining.Size = new System.Drawing.Size(753, 31);
			this.TxtBonusTorchRemaining.TabIndex = 5;
			this.TxtBonusTorchRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FlpLegend
			// 
			this.TlpMain.SetColumnSpan(this.FlpLegend, 2);
			this.FlpLegend.Controls.Add(this.LblPlayer);
			this.FlpLegend.Controls.Add(this.PbPlayer);
			this.FlpLegend.Controls.Add(this.LblExit);
			this.FlpLegend.Controls.Add(this.PbExit);
			this.FlpLegend.Controls.Add(this.LblBonusSteps);
			this.FlpLegend.Controls.Add(this.PbBonusSteps);
			this.FlpLegend.Controls.Add(this.LblBonusTorch);
			this.FlpLegend.Controls.Add(this.PbBonusTorch);
			this.FlpLegend.Controls.Add(this.LblInstructions);
			this.FlpLegend.Location = new System.Drawing.Point(3, 3);
			this.FlpLegend.Name = "FlpLegend";
			this.FlpLegend.Size = new System.Drawing.Size(871, 25);
			this.FlpLegend.TabIndex = 6;
			// 
			// LblPlayer
			// 
			this.LblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblPlayer.Location = new System.Drawing.Point(2, 2);
			this.LblPlayer.Margin = new System.Windows.Forms.Padding(2, 2, 0, 0);
			this.LblPlayer.Name = "LblPlayer";
			this.LblPlayer.Size = new System.Drawing.Size(42, 18);
			this.LblPlayer.TabIndex = 0;
			this.LblPlayer.Text = "Player";
			this.LblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PbPlayer
			// 
			this.PbPlayer.BackColor = System.Drawing.Color.Red;
			this.PbPlayer.Location = new System.Drawing.Point(44, 1);
			this.PbPlayer.Margin = new System.Windows.Forms.Padding(0, 1, 30, 0);
			this.PbPlayer.Name = "PbPlayer";
			this.PbPlayer.Size = new System.Drawing.Size(22, 22);
			this.PbPlayer.TabIndex = 1;
			this.PbPlayer.TabStop = false;
			// 
			// LblExit
			// 
			this.LblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblExit.Location = new System.Drawing.Point(98, 2);
			this.LblExit.Margin = new System.Windows.Forms.Padding(2, 2, 0, 0);
			this.LblExit.Name = "LblExit";
			this.LblExit.Size = new System.Drawing.Size(28, 18);
			this.LblExit.TabIndex = 2;
			this.LblExit.Text = "Exit";
			this.LblExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PbExit
			// 
			this.PbExit.BackColor = System.Drawing.Color.LightGreen;
			this.PbExit.Location = new System.Drawing.Point(126, 1);
			this.PbExit.Margin = new System.Windows.Forms.Padding(0, 1, 30, 0);
			this.PbExit.Name = "PbExit";
			this.PbExit.Size = new System.Drawing.Size(22, 22);
			this.PbExit.TabIndex = 3;
			this.PbExit.TabStop = false;
			// 
			// LblBonusSteps
			// 
			this.LblBonusSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblBonusSteps.Location = new System.Drawing.Point(180, 2);
			this.LblBonusSteps.Margin = new System.Windows.Forms.Padding(2, 2, 0, 0);
			this.LblBonusSteps.Name = "LblBonusSteps";
			this.LblBonusSteps.Size = new System.Drawing.Size(76, 18);
			this.LblBonusSteps.TabIndex = 4;
			this.LblBonusSteps.Text = "Bonus steps";
			this.LblBonusSteps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PbBonusSteps
			// 
			this.PbBonusSteps.BackColor = System.Drawing.Color.CornflowerBlue;
			this.PbBonusSteps.Location = new System.Drawing.Point(256, 1);
			this.PbBonusSteps.Margin = new System.Windows.Forms.Padding(0, 1, 30, 0);
			this.PbBonusSteps.Name = "PbBonusSteps";
			this.PbBonusSteps.Size = new System.Drawing.Size(22, 22);
			this.PbBonusSteps.TabIndex = 5;
			this.PbBonusSteps.TabStop = false;
			// 
			// LblBonusTorch
			// 
			this.LblBonusTorch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblBonusTorch.Location = new System.Drawing.Point(310, 2);
			this.LblBonusTorch.Margin = new System.Windows.Forms.Padding(2, 2, 0, 0);
			this.LblBonusTorch.Name = "LblBonusTorch";
			this.LblBonusTorch.Size = new System.Drawing.Size(75, 18);
			this.LblBonusTorch.TabIndex = 6;
			this.LblBonusTorch.Text = "Bonus torch";
			this.LblBonusTorch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PbBonusTorch
			// 
			this.PbBonusTorch.BackColor = System.Drawing.Color.Gold;
			this.PbBonusTorch.Location = new System.Drawing.Point(385, 1);
			this.PbBonusTorch.Margin = new System.Windows.Forms.Padding(0, 1, 30, 0);
			this.PbBonusTorch.Name = "PbBonusTorch";
			this.PbBonusTorch.Size = new System.Drawing.Size(22, 22);
			this.PbBonusTorch.TabIndex = 7;
			this.PbBonusTorch.TabStop = false;
			// 
			// LblInstructions
			// 
			this.LblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblInstructions.Location = new System.Drawing.Point(439, 2);
			this.LblInstructions.Margin = new System.Windows.Forms.Padding(2, 2, 0, 0);
			this.LblInstructions.Name = "LblInstructions";
			this.LblInstructions.Size = new System.Drawing.Size(153, 23);
			this.LblInstructions.TabIndex = 8;
			this.LblInstructions.Text = "Use W, A, S, D to move.";
			this.LblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// UcInformation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.TlpMain);
			this.Name = "UcInformation";
			this.Size = new System.Drawing.Size(889, 124);
			this.TlpMain.ResumeLayout(false);
			this.TlpMain.PerformLayout();
			this.FlpLegend.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PbPlayer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PbExit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PbBonusSteps)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PbBonusTorch)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpMain;
        private System.Windows.Forms.Label LblStepsRemaining;
        private System.Windows.Forms.Label LblBonusStepsRemaining;
        private System.Windows.Forms.Label LblBonusTorchRemaining;
        private System.Windows.Forms.Label TxtStepsRemaining;
        private System.Windows.Forms.Label TxtBonusStepsRemaining;
        private System.Windows.Forms.Label TxtBonusTorchRemaining;
        private System.Windows.Forms.FlowLayoutPanel FlpLegend;
        private System.Windows.Forms.Label LblPlayer;
        private System.Windows.Forms.PictureBox PbPlayer;
        private System.Windows.Forms.Label LblExit;
        private System.Windows.Forms.PictureBox PbExit;
        private System.Windows.Forms.Label LblBonusSteps;
        private System.Windows.Forms.PictureBox PbBonusSteps;
        private System.Windows.Forms.Label LblBonusTorch;
        private System.Windows.Forms.PictureBox PbBonusTorch;
		private System.Windows.Forms.Label LblInstructions;
	}
}
