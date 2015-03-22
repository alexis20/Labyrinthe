namespace Labyrinthe
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
			this.TlpButtons = new System.Windows.Forms.TableLayoutPanel();
			this.BtnStart = new System.Windows.Forms.Button();
			this.BtnReset = new System.Windows.Forms.Button();
			this.BtnExit = new System.Windows.Forms.Button();
			this.UcInformation = new Labyrinth.UcInformations();
			this.TlpButtons.SuspendLayout();
			this.SuspendLayout();
			// 
			// TlpButtons
			// 
			this.TlpButtons.ColumnCount = 1;
			this.TlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TlpButtons.Controls.Add(this.BtnStart, 0, 0);
			this.TlpButtons.Controls.Add(this.BtnReset, 0, 1);
			this.TlpButtons.Controls.Add(this.BtnExit, 0, 2);
			this.TlpButtons.Dock = System.Windows.Forms.DockStyle.Right;
			this.TlpButtons.Location = new System.Drawing.Point(1050, 0);
			this.TlpButtons.Name = "TlpButtons";
			this.TlpButtons.RowCount = 3;
			this.TlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.TlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.TlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.TlpButtons.Size = new System.Drawing.Size(148, 148);
			this.TlpButtons.TabIndex = 1;
			// 
			// BtnStart
			// 
			this.BtnStart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnStart.Location = new System.Drawing.Point(3, 3);
			this.BtnStart.Name = "BtnStart";
			this.BtnStart.Size = new System.Drawing.Size(142, 43);
			this.BtnStart.TabIndex = 0;
			this.BtnStart.Text = "Start";
			this.BtnStart.UseVisualStyleBackColor = true;
			this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
			// 
			// BtnReset
			// 
			this.BtnReset.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnReset.Location = new System.Drawing.Point(3, 52);
			this.BtnReset.Name = "BtnReset";
			this.BtnReset.Size = new System.Drawing.Size(142, 43);
			this.BtnReset.TabIndex = 1;
			this.BtnReset.Text = "Reset";
			this.BtnReset.UseVisualStyleBackColor = true;
			this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
			// 
			// BtnExit
			// 
			this.BtnExit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnExit.Location = new System.Drawing.Point(3, 101);
			this.BtnExit.Name = "BtnExit";
			this.BtnExit.Size = new System.Drawing.Size(142, 44);
			this.BtnExit.TabIndex = 2;
			this.BtnExit.Text = "Exit";
			this.BtnExit.UseVisualStyleBackColor = true;
			this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// UcInformation
			// 
			this.UcInformation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UcInformation.Location = new System.Drawing.Point(0, 0);
			this.UcInformation.Name = "UcInformation";
			this.UcInformation.Size = new System.Drawing.Size(1050, 148);
			this.UcInformation.TabIndex = 0;
			// 
			// UcGestion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.UcInformation);
			this.Controls.Add(this.TlpButtons);
			this.Name = "UcGestion";
			this.Size = new System.Drawing.Size(1198, 148);
			this.TlpButtons.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Labyrinth.UcInformations UcInformation;
		private System.Windows.Forms.TableLayoutPanel TlpButtons;
		private System.Windows.Forms.Button BtnStart;
		private System.Windows.Forms.Button BtnReset;
		private System.Windows.Forms.Button BtnExit;
	}
}
