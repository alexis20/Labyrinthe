namespace Labyrinth
{
    partial class UcGestionInformation
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
			this.TlpInformation = new System.Windows.Forms.TableLayoutPanel();
			this.BtnStart = new System.Windows.Forms.Button();
			this.BtnExit = new System.Windows.Forms.Button();
			this.BtnRestart = new System.Windows.Forms.Button();
			this.UcInformation = new Labyrinth.UcInformation();
			this.PnlMain = new System.Windows.Forms.Panel();
			this.TlpInformation.SuspendLayout();
			this.PnlMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// TlpInformation
			// 
			this.TlpInformation.ColumnCount = 2;
			this.TlpInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TlpInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
			this.TlpInformation.Controls.Add(this.BtnStart, 1, 0);
			this.TlpInformation.Controls.Add(this.BtnExit, 1, 2);
			this.TlpInformation.Controls.Add(this.BtnRestart, 1, 1);
			this.TlpInformation.Controls.Add(this.UcInformation, 0, 0);
			this.TlpInformation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TlpInformation.Location = new System.Drawing.Point(0, 0);
			this.TlpInformation.Name = "TlpInformation";
			this.TlpInformation.RowCount = 3;
			this.TlpInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.TlpInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.TlpInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.TlpInformation.Size = new System.Drawing.Size(923, 111);
			this.TlpInformation.TabIndex = 0;
			// 
			// BtnStart
			// 
			this.BtnStart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnStart.Location = new System.Drawing.Point(789, 3);
			this.BtnStart.Name = "BtnStart";
			this.BtnStart.Size = new System.Drawing.Size(131, 31);
			this.BtnStart.TabIndex = 0;
			this.BtnStart.Text = "Start";
			this.BtnStart.UseVisualStyleBackColor = true;
			this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
			// 
			// BtnExit
			// 
			this.BtnExit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnExit.Location = new System.Drawing.Point(789, 77);
			this.BtnExit.Name = "BtnExit";
			this.BtnExit.Size = new System.Drawing.Size(131, 31);
			this.BtnExit.TabIndex = 2;
			this.BtnExit.Text = "Exit";
			this.BtnExit.UseVisualStyleBackColor = true;
			this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// BtnRestart
			// 
			this.BtnRestart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnRestart.Enabled = false;
			this.BtnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnRestart.Location = new System.Drawing.Point(789, 40);
			this.BtnRestart.Name = "BtnRestart";
			this.BtnRestart.Size = new System.Drawing.Size(131, 31);
			this.BtnRestart.TabIndex = 1;
			this.BtnRestart.Text = "Restart";
			this.BtnRestart.UseVisualStyleBackColor = true;
			this.BtnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
			// 
			// UcInformation
			// 
			this.UcInformation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UcInformation.Location = new System.Drawing.Point(3, 3);
			this.UcInformation.Name = "UcInformation";
			this.TlpInformation.SetRowSpan(this.UcInformation, 3);
			this.UcInformation.Size = new System.Drawing.Size(780, 105);
			this.UcInformation.TabIndex = 3;
			// 
			// PnlMain
			// 
			this.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PnlMain.Controls.Add(this.TlpInformation);
			this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PnlMain.Location = new System.Drawing.Point(0, 0);
			this.PnlMain.Name = "PnlMain";
			this.PnlMain.Size = new System.Drawing.Size(925, 113);
			this.PnlMain.TabIndex = 1;
			// 
			// UcGestionInformation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.PnlMain);
			this.Name = "UcGestionInformation";
			this.Size = new System.Drawing.Size(925, 113);
			this.TlpInformation.ResumeLayout(false);
			this.PnlMain.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpInformation;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnRestart;
        private UcInformation UcInformation;
        private System.Windows.Forms.Panel PnlMain;
    }
}
