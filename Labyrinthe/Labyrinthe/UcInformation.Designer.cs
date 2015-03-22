namespace Labyrinth
{
    partial class UcInformations
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
			this.LblBonusTorchRemaining = new System.Windows.Forms.Label();
			this.LblBonusStepsRemaining = new System.Windows.Forms.Label();
			this.LblStepsRemaining = new System.Windows.Forms.Label();
			this.PnlLegend = new System.Windows.Forms.Panel();
			this.LblBonusTorch = new System.Windows.Forms.Label();
			this.PbBonusTorch = new System.Windows.Forms.PictureBox();
			this.LblBonusSteps = new System.Windows.Forms.Label();
			this.PbBonusSteps = new System.Windows.Forms.PictureBox();
			this.LblExit = new System.Windows.Forms.Label();
			this.PbExit = new System.Windows.Forms.PictureBox();
			this.LblPlayer = new System.Windows.Forms.Label();
			this.PbPlayer = new System.Windows.Forms.PictureBox();
			this.TxtStepsRemaining = new System.Windows.Forms.Label();
			this.TxtBonusStepsRemaining = new System.Windows.Forms.Label();
			this.TxtBonusTorchRemaining = new System.Windows.Forms.Label();
			this.LblTitle = new System.Windows.Forms.Label();
			this.FlpTop = new System.Windows.Forms.FlowLayoutPanel();
			this.CdChangeColors = new System.Windows.Forms.ColorDialog();
			this.TlpMain.SuspendLayout();
			this.PnlLegend.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PbBonusTorch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PbBonusSteps)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PbExit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PbPlayer)).BeginInit();
			this.FlpTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// TlpMain
			// 
			this.TlpMain.ColumnCount = 2;
			this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
			this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TlpMain.Controls.Add(this.LblBonusTorchRemaining, 0, 3);
			this.TlpMain.Controls.Add(this.LblBonusStepsRemaining, 0, 2);
			this.TlpMain.Controls.Add(this.LblStepsRemaining, 0, 1);
			this.TlpMain.Controls.Add(this.PnlLegend, 0, 0);
			this.TlpMain.Controls.Add(this.TxtStepsRemaining, 1, 1);
			this.TlpMain.Controls.Add(this.TxtBonusStepsRemaining, 1, 2);
			this.TlpMain.Controls.Add(this.TxtBonusTorchRemaining, 1, 3);
			this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TlpMain.Location = new System.Drawing.Point(0, 20);
			this.TlpMain.Margin = new System.Windows.Forms.Padding(0);
			this.TlpMain.Name = "TlpMain";
			this.TlpMain.RowCount = 4;
			this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
			this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
			this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
			this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TlpMain.Size = new System.Drawing.Size(1200, 95);
			this.TlpMain.TabIndex = 0;
			// 
			// LblBonusTorchRemaining
			// 
			this.LblBonusTorchRemaining.AutoSize = true;
			this.LblBonusTorchRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblBonusTorchRemaining.Location = new System.Drawing.Point(3, 66);
			this.LblBonusTorchRemaining.Name = "LblBonusTorchRemaining";
			this.LblBonusTorchRemaining.Size = new System.Drawing.Size(116, 29);
			this.LblBonusTorchRemaining.TabIndex = 3;
			this.LblBonusTorchRemaining.Text = "Bonus torch remaining:";
			this.LblBonusTorchRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// LblBonusStepsRemaining
			// 
			this.LblBonusStepsRemaining.AutoSize = true;
			this.LblBonusStepsRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblBonusStepsRemaining.Location = new System.Drawing.Point(3, 44);
			this.LblBonusStepsRemaining.Name = "LblBonusStepsRemaining";
			this.LblBonusStepsRemaining.Size = new System.Drawing.Size(116, 22);
			this.LblBonusStepsRemaining.TabIndex = 1;
			this.LblBonusStepsRemaining.Text = "Bonus steps remaining:";
			this.LblBonusStepsRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// LblStepsRemaining
			// 
			this.LblStepsRemaining.AutoSize = true;
			this.LblStepsRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblStepsRemaining.Location = new System.Drawing.Point(3, 22);
			this.LblStepsRemaining.Name = "LblStepsRemaining";
			this.LblStepsRemaining.Size = new System.Drawing.Size(116, 22);
			this.LblStepsRemaining.TabIndex = 0;
			this.LblStepsRemaining.Text = "Steps remaining:";
			this.LblStepsRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// PnlLegend
			// 
			this.TlpMain.SetColumnSpan(this.PnlLegend, 2);
			this.PnlLegend.Controls.Add(this.LblBonusTorch);
			this.PnlLegend.Controls.Add(this.PbBonusTorch);
			this.PnlLegend.Controls.Add(this.LblBonusSteps);
			this.PnlLegend.Controls.Add(this.PbBonusSteps);
			this.PnlLegend.Controls.Add(this.LblExit);
			this.PnlLegend.Controls.Add(this.PbExit);
			this.PnlLegend.Controls.Add(this.LblPlayer);
			this.PnlLegend.Controls.Add(this.PbPlayer);
			this.PnlLegend.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PnlLegend.Location = new System.Drawing.Point(0, 0);
			this.PnlLegend.Margin = new System.Windows.Forms.Padding(0);
			this.PnlLegend.Name = "PnlLegend";
			this.PnlLegend.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.PnlLegend.Size = new System.Drawing.Size(1200, 22);
			this.PnlLegend.TabIndex = 4;
			// 
			// LblBonusTorch
			// 
			this.LblBonusTorch.AutoSize = true;
			this.LblBonusTorch.Dock = System.Windows.Forms.DockStyle.Left;
			this.LblBonusTorch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblBonusTorch.Location = new System.Drawing.Point(284, 0);
			this.LblBonusTorch.Name = "LblBonusTorch";
			this.LblBonusTorch.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.LblBonusTorch.Size = new System.Drawing.Size(75, 16);
			this.LblBonusTorch.TabIndex = 7;
			this.LblBonusTorch.Text = "Bonus torch";
			this.LblBonusTorch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PbBonusTorch
			// 
			this.PbBonusTorch.BackColor = System.Drawing.Color.Gold;
			this.PbBonusTorch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PbBonusTorch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.PbBonusTorch.Dock = System.Windows.Forms.DockStyle.Left;
			this.PbBonusTorch.Location = new System.Drawing.Point(262, 0);
			this.PbBonusTorch.Name = "PbBonusTorch";
			this.PbBonusTorch.Size = new System.Drawing.Size(22, 22);
			this.PbBonusTorch.TabIndex = 6;
			this.PbBonusTorch.TabStop = false;
			this.PbBonusTorch.Click += new System.EventHandler(this.ChangeColor);
			// 
			// LblBonusSteps
			// 
			this.LblBonusSteps.AutoSize = true;
			this.LblBonusSteps.Dock = System.Windows.Forms.DockStyle.Left;
			this.LblBonusSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblBonusSteps.Location = new System.Drawing.Point(171, 0);
			this.LblBonusSteps.Name = "LblBonusSteps";
			this.LblBonusSteps.Padding = new System.Windows.Forms.Padding(0, 3, 15, 0);
			this.LblBonusSteps.Size = new System.Drawing.Size(91, 16);
			this.LblBonusSteps.TabIndex = 5;
			this.LblBonusSteps.Text = "Bonus steps";
			this.LblBonusSteps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PbBonusSteps
			// 
			this.PbBonusSteps.BackColor = System.Drawing.Color.CornflowerBlue;
			this.PbBonusSteps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PbBonusSteps.Cursor = System.Windows.Forms.Cursors.Hand;
			this.PbBonusSteps.Dock = System.Windows.Forms.DockStyle.Left;
			this.PbBonusSteps.Location = new System.Drawing.Point(149, 0);
			this.PbBonusSteps.Name = "PbBonusSteps";
			this.PbBonusSteps.Size = new System.Drawing.Size(22, 22);
			this.PbBonusSteps.TabIndex = 4;
			this.PbBonusSteps.TabStop = false;
			this.PbBonusSteps.Click += new System.EventHandler(this.ChangeColor);
			// 
			// LblExit
			// 
			this.LblExit.AutoSize = true;
			this.LblExit.Dock = System.Windows.Forms.DockStyle.Left;
			this.LblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblExit.Location = new System.Drawing.Point(106, 0);
			this.LblExit.Name = "LblExit";
			this.LblExit.Padding = new System.Windows.Forms.Padding(0, 3, 15, 0);
			this.LblExit.Size = new System.Drawing.Size(43, 16);
			this.LblExit.TabIndex = 3;
			this.LblExit.Text = "Exit";
			this.LblExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PbExit
			// 
			this.PbExit.BackColor = System.Drawing.Color.LightGreen;
			this.PbExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PbExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.PbExit.Dock = System.Windows.Forms.DockStyle.Left;
			this.PbExit.Location = new System.Drawing.Point(84, 0);
			this.PbExit.Name = "PbExit";
			this.PbExit.Size = new System.Drawing.Size(22, 22);
			this.PbExit.TabIndex = 2;
			this.PbExit.TabStop = false;
			this.PbExit.Click += new System.EventHandler(this.ChangeColor);
			// 
			// LblPlayer
			// 
			this.LblPlayer.AutoSize = true;
			this.LblPlayer.Dock = System.Windows.Forms.DockStyle.Left;
			this.LblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblPlayer.Location = new System.Drawing.Point(27, 0);
			this.LblPlayer.Name = "LblPlayer";
			this.LblPlayer.Padding = new System.Windows.Forms.Padding(0, 3, 15, 0);
			this.LblPlayer.Size = new System.Drawing.Size(57, 16);
			this.LblPlayer.TabIndex = 1;
			this.LblPlayer.Text = "Player";
			this.LblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PbPlayer
			// 
			this.PbPlayer.BackColor = System.Drawing.Color.Red;
			this.PbPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PbPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.PbPlayer.Dock = System.Windows.Forms.DockStyle.Left;
			this.PbPlayer.Location = new System.Drawing.Point(5, 0);
			this.PbPlayer.Name = "PbPlayer";
			this.PbPlayer.Size = new System.Drawing.Size(22, 22);
			this.PbPlayer.TabIndex = 0;
			this.PbPlayer.TabStop = false;
			this.PbPlayer.Click += new System.EventHandler(this.ChangeColor);
			// 
			// TxtStepsRemaining
			// 
			this.TxtStepsRemaining.AutoSize = true;
			this.TxtStepsRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtStepsRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtStepsRemaining.Location = new System.Drawing.Point(125, 22);
			this.TxtStepsRemaining.Name = "TxtStepsRemaining";
			this.TxtStepsRemaining.Size = new System.Drawing.Size(1072, 22);
			this.TxtStepsRemaining.TabIndex = 5;
			this.TxtStepsRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TxtBonusStepsRemaining
			// 
			this.TxtBonusStepsRemaining.AutoSize = true;
			this.TxtBonusStepsRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtBonusStepsRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtBonusStepsRemaining.Location = new System.Drawing.Point(125, 44);
			this.TxtBonusStepsRemaining.Name = "TxtBonusStepsRemaining";
			this.TxtBonusStepsRemaining.Size = new System.Drawing.Size(1072, 22);
			this.TxtBonusStepsRemaining.TabIndex = 6;
			this.TxtBonusStepsRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TxtBonusTorchRemaining
			// 
			this.TxtBonusTorchRemaining.AutoSize = true;
			this.TxtBonusTorchRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtBonusTorchRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtBonusTorchRemaining.Location = new System.Drawing.Point(125, 66);
			this.TxtBonusTorchRemaining.Name = "TxtBonusTorchRemaining";
			this.TxtBonusTorchRemaining.Size = new System.Drawing.Size(1072, 29);
			this.TxtBonusTorchRemaining.TabIndex = 7;
			this.TxtBonusTorchRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LblTitle
			// 
			this.LblTitle.AutoSize = true;
			this.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTitle.Location = new System.Drawing.Point(3, 0);
			this.LblTitle.Name = "LblTitle";
			this.LblTitle.Size = new System.Drawing.Size(93, 13);
			this.LblTitle.TabIndex = 0;
			this.LblTitle.Text = "INFORMATION";
			this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FlpTop
			// 
			this.FlpTop.Controls.Add(this.LblTitle);
			this.FlpTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.FlpTop.Location = new System.Drawing.Point(0, 0);
			this.FlpTop.Margin = new System.Windows.Forms.Padding(0);
			this.FlpTop.Name = "FlpTop";
			this.FlpTop.Size = new System.Drawing.Size(1200, 20);
			this.FlpTop.TabIndex = 1;
			// 
			// CdChangeColors
			// 
			this.CdChangeColors.AnyColor = true;
			this.CdChangeColors.FullOpen = true;
			// 
			// UcInformations
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.TlpMain);
			this.Controls.Add(this.FlpTop);
			this.Name = "UcInformations";
			this.Size = new System.Drawing.Size(1200, 115);
			this.TlpMain.ResumeLayout(false);
			this.TlpMain.PerformLayout();
			this.PnlLegend.ResumeLayout(false);
			this.PnlLegend.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PbBonusTorch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PbBonusSteps)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PbExit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PbPlayer)).EndInit();
			this.FlpTop.ResumeLayout(false);
			this.FlpTop.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.TableLayoutPanel TlpMain;
		private System.Windows.Forms.Label LblStepsRemaining;
		private System.Windows.Forms.Label LblBonusStepsRemaining;
		private System.Windows.Forms.Label LblTitle;
		private System.Windows.Forms.FlowLayoutPanel FlpTop;
		private System.Windows.Forms.Label LblBonusTorchRemaining;
		private System.Windows.Forms.Panel PnlLegend;
		private System.Windows.Forms.Label TxtStepsRemaining;
		private System.Windows.Forms.Label TxtBonusStepsRemaining;
		private System.Windows.Forms.Label TxtBonusTorchRemaining;
		private System.Windows.Forms.ColorDialog CdChangeColors;
		private System.Windows.Forms.PictureBox PbPlayer;
		private System.Windows.Forms.Label LblPlayer;
		private System.Windows.Forms.Label LblBonusTorch;
		private System.Windows.Forms.PictureBox PbBonusTorch;
		private System.Windows.Forms.Label LblBonusSteps;
		private System.Windows.Forms.PictureBox PbBonusSteps;
		private System.Windows.Forms.Label LblExit;
		private System.Windows.Forms.PictureBox PbExit;
	}
}
