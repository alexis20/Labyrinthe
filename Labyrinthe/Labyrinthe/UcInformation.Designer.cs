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
			this.LblStepsRemaining = new System.Windows.Forms.Label();
			this.LblBonusStepsRemaining = new System.Windows.Forms.Label();
			this.LblTitle = new System.Windows.Forms.Label();
			this.FlpTop = new System.Windows.Forms.FlowLayoutPanel();
			this.LblBonusTorchRemaining = new System.Windows.Forms.Label();
			this.PnlLegend = new System.Windows.Forms.Panel();
			this.TxtStepsRemaining = new System.Windows.Forms.Label();
			this.TxtBonusStepsRemaining = new System.Windows.Forms.Label();
			this.TxtBonusTorchRemaining = new System.Windows.Forms.Label();
			this.TlpMain.SuspendLayout();
			this.FlpTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// TlpMain
			// 
			this.TlpMain.ColumnCount = 2;
			this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.79884F));
			this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.20116F));
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
			this.TlpMain.Size = new System.Drawing.Size(1034, 176);
			this.TlpMain.TabIndex = 0;
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
			this.FlpTop.Size = new System.Drawing.Size(1034, 20);
			this.FlpTop.TabIndex = 1;
			// 
			// LblBonusTorchRemaining
			// 
			this.LblBonusTorchRemaining.AutoSize = true;
			this.LblBonusTorchRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblBonusTorchRemaining.Location = new System.Drawing.Point(3, 66);
			this.LblBonusTorchRemaining.Name = "LblBonusTorchRemaining";
			this.LblBonusTorchRemaining.Size = new System.Drawing.Size(116, 110);
			this.LblBonusTorchRemaining.TabIndex = 3;
			this.LblBonusTorchRemaining.Text = "Bonus torch remaining:";
			this.LblBonusTorchRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// PnlLegend
			// 
			this.TlpMain.SetColumnSpan(this.PnlLegend, 2);
			this.PnlLegend.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PnlLegend.Location = new System.Drawing.Point(0, 0);
			this.PnlLegend.Margin = new System.Windows.Forms.Padding(0);
			this.PnlLegend.Name = "PnlLegend";
			this.PnlLegend.Size = new System.Drawing.Size(1034, 22);
			this.PnlLegend.TabIndex = 4;
			// 
			// TxtStepsRemaining
			// 
			this.TxtStepsRemaining.AutoSize = true;
			this.TxtStepsRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtStepsRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtStepsRemaining.Location = new System.Drawing.Point(125, 22);
			this.TxtStepsRemaining.Name = "TxtStepsRemaining";
			this.TxtStepsRemaining.Size = new System.Drawing.Size(906, 22);
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
			this.TxtBonusStepsRemaining.Size = new System.Drawing.Size(906, 22);
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
			this.TxtBonusTorchRemaining.Size = new System.Drawing.Size(906, 110);
			this.TxtBonusTorchRemaining.TabIndex = 7;
			this.TxtBonusTorchRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// UcInformations
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.TlpMain);
			this.Controls.Add(this.FlpTop);
			this.Name = "UcInformations";
			this.Size = new System.Drawing.Size(1034, 196);
			this.TlpMain.ResumeLayout(false);
			this.TlpMain.PerformLayout();
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
	}
}
