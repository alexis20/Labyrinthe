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
            this.TlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpMain
            // 
            this.TlpMain.ColumnCount = 2;
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpMain.Controls.Add(this.LblStepsRemaining, 0, 0);
            this.TlpMain.Controls.Add(this.LblBonusStepsRemaining, 0, 1);
            this.TlpMain.Controls.Add(this.LblBonusTorchRemaining, 0, 2);
            this.TlpMain.Controls.Add(this.TxtStepsRemaining, 1, 0);
            this.TlpMain.Controls.Add(this.TxtBonusStepsRemaining, 1, 1);
            this.TlpMain.Controls.Add(this.TxtBonusTorchRemaining, 1, 2);
            this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpMain.Location = new System.Drawing.Point(0, 0);
            this.TlpMain.Name = "TlpMain";
            this.TlpMain.RowCount = 3;
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TlpMain.Size = new System.Drawing.Size(889, 124);
            this.TlpMain.TabIndex = 0;
            // 
            // LblStepsRemaining
            // 
            this.LblStepsRemaining.AutoSize = true;
            this.LblStepsRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblStepsRemaining.Location = new System.Drawing.Point(3, 0);
            this.LblStepsRemaining.Name = "LblStepsRemaining";
            this.LblStepsRemaining.Size = new System.Drawing.Size(85, 41);
            this.LblStepsRemaining.TabIndex = 0;
            this.LblStepsRemaining.Text = "Steps remaining:";
            this.LblStepsRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblBonusStepsRemaining
            // 
            this.LblBonusStepsRemaining.AutoSize = true;
            this.LblBonusStepsRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblBonusStepsRemaining.Location = new System.Drawing.Point(3, 41);
            this.LblBonusStepsRemaining.Name = "LblBonusStepsRemaining";
            this.LblBonusStepsRemaining.Size = new System.Drawing.Size(85, 41);
            this.LblBonusStepsRemaining.TabIndex = 1;
            this.LblBonusStepsRemaining.Text = "Bonus steps:";
            this.LblBonusStepsRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblBonusTorchRemaining
            // 
            this.LblBonusTorchRemaining.AutoSize = true;
            this.LblBonusTorchRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblBonusTorchRemaining.Location = new System.Drawing.Point(3, 82);
            this.LblBonusTorchRemaining.Name = "LblBonusTorchRemaining";
            this.LblBonusTorchRemaining.Size = new System.Drawing.Size(85, 42);
            this.LblBonusTorchRemaining.TabIndex = 2;
            this.LblBonusTorchRemaining.Text = "Bonus torch:";
            this.LblBonusTorchRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtStepsRemaining
            // 
            this.TxtStepsRemaining.AutoSize = true;
            this.TxtStepsRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtStepsRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStepsRemaining.Location = new System.Drawing.Point(94, 0);
            this.TxtStepsRemaining.Name = "TxtStepsRemaining";
            this.TxtStepsRemaining.Size = new System.Drawing.Size(792, 41);
            this.TxtStepsRemaining.TabIndex = 3;
            this.TxtStepsRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtBonusStepsRemaining
            // 
            this.TxtBonusStepsRemaining.AutoSize = true;
            this.TxtBonusStepsRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBonusStepsRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBonusStepsRemaining.Location = new System.Drawing.Point(94, 41);
            this.TxtBonusStepsRemaining.Name = "TxtBonusStepsRemaining";
            this.TxtBonusStepsRemaining.Size = new System.Drawing.Size(792, 41);
            this.TxtBonusStepsRemaining.TabIndex = 4;
            this.TxtBonusStepsRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtBonusTorchRemaining
            // 
            this.TxtBonusTorchRemaining.AutoSize = true;
            this.TxtBonusTorchRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBonusTorchRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBonusTorchRemaining.Location = new System.Drawing.Point(94, 82);
            this.TxtBonusTorchRemaining.Name = "TxtBonusTorchRemaining";
            this.TxtBonusTorchRemaining.Size = new System.Drawing.Size(792, 42);
            this.TxtBonusTorchRemaining.TabIndex = 5;
            this.TxtBonusTorchRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
    }
}
