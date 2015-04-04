namespace Labyrinth
{
	partial class FormGameOver
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
			this.TlpMain = new System.Windows.Forms.TableLayoutPanel();
			this.LblTitle = new System.Windows.Forms.Label();
			this.GbSteps = new System.Windows.Forms.GroupBox();
			this.TlpSteps = new System.Windows.Forms.TableLayoutPanel();
			this.TxtTotalSteps = new System.Windows.Forms.Label();
			this.LblStepsRemaining = new System.Windows.Forms.Label();
			this.LblTotalSteps = new System.Windows.Forms.Label();
			this.TxtStepsRemaining = new System.Windows.Forms.Label();
			this.GbBonusSteps = new System.Windows.Forms.GroupBox();
			this.TlpBonusSteps = new System.Windows.Forms.TableLayoutPanel();
			this.TxtTotalBonusStepsTaken = new System.Windows.Forms.Label();
			this.TxtTotalBonusSteps = new System.Windows.Forms.Label();
			this.LblBonusStepsRemaining = new System.Windows.Forms.Label();
			this.LblTotalBonusSteps = new System.Windows.Forms.Label();
			this.LblTotalBonusStepsTaken = new System.Windows.Forms.Label();
			this.TxtBonusStepsRemaining = new System.Windows.Forms.Label();
			this.GbBonusTorch = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.TxtTotalBonusTorchTaken = new System.Windows.Forms.Label();
			this.TxtTotalBonusTorch = new System.Windows.Forms.Label();
			this.LblBonusTorchRemaining = new System.Windows.Forms.Label();
			this.LblTotalBonusTorchTaken = new System.Windows.Forms.Label();
			this.LblTotalBonusTorch = new System.Windows.Forms.Label();
			this.TxtBonusTorchRemaining = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.LblTimer = new System.Windows.Forms.Label();
			this.TxtTimer = new System.Windows.Forms.Label();
			this.FlpBottom = new System.Windows.Forms.FlowLayoutPanel();
			this.BtnExit = new System.Windows.Forms.Button();
			this.BtnRestart = new System.Windows.Forms.Button();
			this.PnlMain = new System.Windows.Forms.Panel();
			this.TlpMain.SuspendLayout();
			this.GbSteps.SuspendLayout();
			this.TlpSteps.SuspendLayout();
			this.GbBonusSteps.SuspendLayout();
			this.TlpBonusSteps.SuspendLayout();
			this.GbBonusTorch.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.FlpBottom.SuspendLayout();
			this.PnlMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// TlpMain
			// 
			this.TlpMain.ColumnCount = 1;
			this.TlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TlpMain.Controls.Add(this.LblTitle, 0, 0);
			this.TlpMain.Controls.Add(this.GbSteps, 0, 2);
			this.TlpMain.Controls.Add(this.GbBonusSteps, 0, 3);
			this.TlpMain.Controls.Add(this.GbBonusTorch, 0, 4);
			this.TlpMain.Controls.Add(this.flowLayoutPanel1, 0, 1);
			this.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TlpMain.Location = new System.Drawing.Point(10, 10);
			this.TlpMain.Name = "TlpMain";
			this.TlpMain.RowCount = 5;
			this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
			this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.49004F));
			this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.25498F));
			this.TlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.85658F));
			this.TlpMain.Size = new System.Drawing.Size(351, 303);
			this.TlpMain.TabIndex = 1;
			// 
			// LblTitle
			// 
			this.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTitle.Location = new System.Drawing.Point(3, 0);
			this.LblTitle.Name = "LblTitle";
			this.LblTitle.Size = new System.Drawing.Size(345, 30);
			this.LblTitle.TabIndex = 0;
			this.LblTitle.Text = "WINNER / LOOSER !";
			this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// GbSteps
			// 
			this.GbSteps.Controls.Add(this.TlpSteps);
			this.GbSteps.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GbSteps.Location = new System.Drawing.Point(3, 55);
			this.GbSteps.Name = "GbSteps";
			this.GbSteps.Size = new System.Drawing.Size(345, 63);
			this.GbSteps.TabIndex = 12;
			this.GbSteps.TabStop = false;
			this.GbSteps.Text = "Steps";
			// 
			// TlpSteps
			// 
			this.TlpSteps.ColumnCount = 2;
			this.TlpSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TlpSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TlpSteps.Controls.Add(this.TxtTotalSteps, 1, 1);
			this.TlpSteps.Controls.Add(this.LblStepsRemaining, 0, 0);
			this.TlpSteps.Controls.Add(this.LblTotalSteps, 0, 1);
			this.TlpSteps.Controls.Add(this.TxtStepsRemaining, 1, 0);
			this.TlpSteps.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TlpSteps.Location = new System.Drawing.Point(3, 16);
			this.TlpSteps.Margin = new System.Windows.Forms.Padding(0);
			this.TlpSteps.Name = "TlpSteps";
			this.TlpSteps.RowCount = 2;
			this.TlpSteps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TlpSteps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TlpSteps.Size = new System.Drawing.Size(339, 44);
			this.TlpSteps.TabIndex = 0;
			// 
			// TxtTotalSteps
			// 
			this.TxtTotalSteps.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtTotalSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtTotalSteps.Location = new System.Drawing.Point(99, 22);
			this.TxtTotalSteps.Name = "TxtTotalSteps";
			this.TxtTotalSteps.Size = new System.Drawing.Size(237, 22);
			this.TxtTotalSteps.TabIndex = 8;
			this.TxtTotalSteps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LblStepsRemaining
			// 
			this.LblStepsRemaining.AutoSize = true;
			this.LblStepsRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblStepsRemaining.Location = new System.Drawing.Point(3, 0);
			this.LblStepsRemaining.Name = "LblStepsRemaining";
			this.LblStepsRemaining.Size = new System.Drawing.Size(90, 22);
			this.LblStepsRemaining.TabIndex = 1;
			this.LblStepsRemaining.Text = "Steps Remaining:";
			this.LblStepsRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// LblTotalSteps
			// 
			this.LblTotalSteps.AutoSize = true;
			this.LblTotalSteps.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblTotalSteps.Location = new System.Drawing.Point(3, 22);
			this.LblTotalSteps.Name = "LblTotalSteps";
			this.LblTotalSteps.Size = new System.Drawing.Size(90, 22);
			this.LblTotalSteps.TabIndex = 7;
			this.LblTotalSteps.Text = "Total Steps:";
			this.LblTotalSteps.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TxtStepsRemaining
			// 
			this.TxtStepsRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtStepsRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtStepsRemaining.Location = new System.Drawing.Point(99, 0);
			this.TxtStepsRemaining.Name = "TxtStepsRemaining";
			this.TxtStepsRemaining.Size = new System.Drawing.Size(237, 22);
			this.TxtStepsRemaining.TabIndex = 4;
			this.TxtStepsRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// GbBonusSteps
			// 
			this.GbBonusSteps.Controls.Add(this.TlpBonusSteps);
			this.GbBonusSteps.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GbBonusSteps.Location = new System.Drawing.Point(3, 124);
			this.GbBonusSteps.Name = "GbBonusSteps";
			this.GbBonusSteps.Size = new System.Drawing.Size(345, 85);
			this.GbBonusSteps.TabIndex = 13;
			this.GbBonusSteps.TabStop = false;
			this.GbBonusSteps.Text = "Bonus Steps";
			// 
			// TlpBonusSteps
			// 
			this.TlpBonusSteps.ColumnCount = 2;
			this.TlpBonusSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TlpBonusSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TlpBonusSteps.Controls.Add(this.TxtTotalBonusStepsTaken, 1, 2);
			this.TlpBonusSteps.Controls.Add(this.TxtTotalBonusSteps, 1, 1);
			this.TlpBonusSteps.Controls.Add(this.LblBonusStepsRemaining, 0, 0);
			this.TlpBonusSteps.Controls.Add(this.LblTotalBonusSteps, 0, 1);
			this.TlpBonusSteps.Controls.Add(this.LblTotalBonusStepsTaken, 0, 2);
			this.TlpBonusSteps.Controls.Add(this.TxtBonusStepsRemaining, 1, 0);
			this.TlpBonusSteps.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TlpBonusSteps.Location = new System.Drawing.Point(3, 16);
			this.TlpBonusSteps.Margin = new System.Windows.Forms.Padding(0);
			this.TlpBonusSteps.Name = "TlpBonusSteps";
			this.TlpBonusSteps.RowCount = 3;
			this.TlpBonusSteps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.TlpBonusSteps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.TlpBonusSteps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.TlpBonusSteps.Size = new System.Drawing.Size(339, 66);
			this.TlpBonusSteps.TabIndex = 0;
			// 
			// TxtTotalBonusStepsTaken
			// 
			this.TxtTotalBonusStepsTaken.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtTotalBonusStepsTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtTotalBonusStepsTaken.Location = new System.Drawing.Point(107, 44);
			this.TxtTotalBonusStepsTaken.Name = "TxtTotalBonusStepsTaken";
			this.TxtTotalBonusStepsTaken.Size = new System.Drawing.Size(229, 22);
			this.TxtTotalBonusStepsTaken.TabIndex = 11;
			this.TxtTotalBonusStepsTaken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TxtTotalBonusSteps
			// 
			this.TxtTotalBonusSteps.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtTotalBonusSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtTotalBonusSteps.Location = new System.Drawing.Point(107, 22);
			this.TxtTotalBonusSteps.Name = "TxtTotalBonusSteps";
			this.TxtTotalBonusSteps.Size = new System.Drawing.Size(229, 22);
			this.TxtTotalBonusSteps.TabIndex = 10;
			this.TxtTotalBonusSteps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LblBonusStepsRemaining
			// 
			this.LblBonusStepsRemaining.AutoSize = true;
			this.LblBonusStepsRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblBonusStepsRemaining.Location = new System.Drawing.Point(3, 0);
			this.LblBonusStepsRemaining.Name = "LblBonusStepsRemaining";
			this.LblBonusStepsRemaining.Size = new System.Drawing.Size(98, 22);
			this.LblBonusStepsRemaining.TabIndex = 2;
			this.LblBonusStepsRemaining.Text = "Steps Remaining:";
			this.LblBonusStepsRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// LblTotalBonusSteps
			// 
			this.LblTotalBonusSteps.AutoSize = true;
			this.LblTotalBonusSteps.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblTotalBonusSteps.Location = new System.Drawing.Point(3, 22);
			this.LblTotalBonusSteps.Name = "LblTotalBonusSteps";
			this.LblTotalBonusSteps.Size = new System.Drawing.Size(98, 22);
			this.LblTotalBonusSteps.TabIndex = 9;
			this.LblTotalBonusSteps.Text = "Total Steps:";
			this.LblTotalBonusSteps.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// LblTotalBonusStepsTaken
			// 
			this.LblTotalBonusStepsTaken.AutoSize = true;
			this.LblTotalBonusStepsTaken.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblTotalBonusStepsTaken.Location = new System.Drawing.Point(3, 44);
			this.LblTotalBonusStepsTaken.Name = "LblTotalBonusStepsTaken";
			this.LblTotalBonusStepsTaken.Size = new System.Drawing.Size(98, 22);
			this.LblTotalBonusStepsTaken.TabIndex = 8;
			this.LblTotalBonusStepsTaken.Text = "Total Steps Taken:";
			this.LblTotalBonusStepsTaken.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TxtBonusStepsRemaining
			// 
			this.TxtBonusStepsRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtBonusStepsRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtBonusStepsRemaining.Location = new System.Drawing.Point(107, 0);
			this.TxtBonusStepsRemaining.Name = "TxtBonusStepsRemaining";
			this.TxtBonusStepsRemaining.Size = new System.Drawing.Size(229, 22);
			this.TxtBonusStepsRemaining.TabIndex = 5;
			this.TxtBonusStepsRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// GbBonusTorch
			// 
			this.GbBonusTorch.Controls.Add(this.tableLayoutPanel1);
			this.GbBonusTorch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GbBonusTorch.Location = new System.Drawing.Point(3, 215);
			this.GbBonusTorch.Name = "GbBonusTorch";
			this.GbBonusTorch.Size = new System.Drawing.Size(345, 85);
			this.GbBonusTorch.TabIndex = 14;
			this.GbBonusTorch.TabStop = false;
			this.GbBonusTorch.Text = "Bonus Torch";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.TxtTotalBonusTorchTaken, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.TxtTotalBonusTorch, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.LblBonusTorchRemaining, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.LblTotalBonusTorchTaken, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.LblTotalBonusTorch, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.TxtBonusTorchRemaining, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(339, 66);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// TxtTotalBonusTorchTaken
			// 
			this.TxtTotalBonusTorchTaken.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtTotalBonusTorchTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtTotalBonusTorchTaken.Location = new System.Drawing.Point(108, 44);
			this.TxtTotalBonusTorchTaken.Name = "TxtTotalBonusTorchTaken";
			this.TxtTotalBonusTorchTaken.Size = new System.Drawing.Size(228, 22);
			this.TxtTotalBonusTorchTaken.TabIndex = 13;
			this.TxtTotalBonusTorchTaken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TxtTotalBonusTorch
			// 
			this.TxtTotalBonusTorch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtTotalBonusTorch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtTotalBonusTorch.Location = new System.Drawing.Point(108, 22);
			this.TxtTotalBonusTorch.Name = "TxtTotalBonusTorch";
			this.TxtTotalBonusTorch.Size = new System.Drawing.Size(228, 22);
			this.TxtTotalBonusTorch.TabIndex = 12;
			this.TxtTotalBonusTorch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LblBonusTorchRemaining
			// 
			this.LblBonusTorchRemaining.AutoSize = true;
			this.LblBonusTorchRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblBonusTorchRemaining.Location = new System.Drawing.Point(3, 0);
			this.LblBonusTorchRemaining.Name = "LblBonusTorchRemaining";
			this.LblBonusTorchRemaining.Size = new System.Drawing.Size(99, 22);
			this.LblBonusTorchRemaining.TabIndex = 3;
			this.LblBonusTorchRemaining.Text = "Torch Remaining:";
			this.LblBonusTorchRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// LblTotalBonusTorchTaken
			// 
			this.LblTotalBonusTorchTaken.AutoSize = true;
			this.LblTotalBonusTorchTaken.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblTotalBonusTorchTaken.Location = new System.Drawing.Point(3, 44);
			this.LblTotalBonusTorchTaken.Name = "LblTotalBonusTorchTaken";
			this.LblTotalBonusTorchTaken.Size = new System.Drawing.Size(99, 22);
			this.LblTotalBonusTorchTaken.TabIndex = 10;
			this.LblTotalBonusTorchTaken.Text = "Total Torch Taken:";
			this.LblTotalBonusTorchTaken.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// LblTotalBonusTorch
			// 
			this.LblTotalBonusTorch.AutoSize = true;
			this.LblTotalBonusTorch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblTotalBonusTorch.Location = new System.Drawing.Point(3, 22);
			this.LblTotalBonusTorch.Name = "LblTotalBonusTorch";
			this.LblTotalBonusTorch.Size = new System.Drawing.Size(99, 22);
			this.LblTotalBonusTorch.TabIndex = 11;
			this.LblTotalBonusTorch.Text = "Total Torch:";
			this.LblTotalBonusTorch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TxtBonusTorchRemaining
			// 
			this.TxtBonusTorchRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtBonusTorchRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtBonusTorchRemaining.Location = new System.Drawing.Point(108, 0);
			this.TxtBonusTorchRemaining.Name = "TxtBonusTorchRemaining";
			this.TxtBonusTorchRemaining.Size = new System.Drawing.Size(228, 22);
			this.TxtBonusTorchRemaining.TabIndex = 6;
			this.TxtBonusTorchRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.LblTimer);
			this.flowLayoutPanel1.Controls.Add(this.TxtTimer);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 30);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(351, 22);
			this.flowLayoutPanel1.TabIndex = 15;
			// 
			// LblTimer
			// 
			this.LblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTimer.Location = new System.Drawing.Point(3, 0);
			this.LblTimer.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.LblTimer.Name = "LblTimer";
			this.LblTimer.Size = new System.Drawing.Size(38, 23);
			this.LblTimer.TabIndex = 0;
			this.LblTimer.Text = "Time:";
			this.LblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TxtTimer
			// 
			this.TxtTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtTimer.Location = new System.Drawing.Point(3, 23);
			this.TxtTimer.Name = "TxtTimer";
			this.TxtTimer.Size = new System.Drawing.Size(487, 23);
			this.TxtTimer.TabIndex = 1;
			this.TxtTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FlpBottom
			// 
			this.FlpBottom.Controls.Add(this.BtnExit);
			this.FlpBottom.Controls.Add(this.BtnRestart);
			this.FlpBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.FlpBottom.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.FlpBottom.Location = new System.Drawing.Point(10, 335);
			this.FlpBottom.Name = "FlpBottom";
			this.FlpBottom.Size = new System.Drawing.Size(373, 48);
			this.FlpBottom.TabIndex = 2;
			// 
			// BtnExit
			// 
			this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnExit.Location = new System.Drawing.Point(253, 5);
			this.BtnExit.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
			this.BtnExit.Name = "BtnExit";
			this.BtnExit.Size = new System.Drawing.Size(115, 38);
			this.BtnExit.TabIndex = 0;
			this.BtnExit.Text = "Exit";
			this.BtnExit.UseVisualStyleBackColor = true;
			// 
			// BtnRestart
			// 
			this.BtnRestart.DialogResult = System.Windows.Forms.DialogResult.Retry;
			this.BtnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnRestart.Location = new System.Drawing.Point(133, 5);
			this.BtnRestart.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
			this.BtnRestart.Name = "BtnRestart";
			this.BtnRestart.Size = new System.Drawing.Size(115, 38);
			this.BtnRestart.TabIndex = 1;
			this.BtnRestart.Text = "Restart";
			this.BtnRestart.UseVisualStyleBackColor = true;
			// 
			// PnlMain
			// 
			this.PnlMain.BackColor = System.Drawing.Color.White;
			this.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PnlMain.Controls.Add(this.TlpMain);
			this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PnlMain.Location = new System.Drawing.Point(10, 10);
			this.PnlMain.Name = "PnlMain";
			this.PnlMain.Padding = new System.Windows.Forms.Padding(10);
			this.PnlMain.Size = new System.Drawing.Size(373, 325);
			this.PnlMain.TabIndex = 3;
			// 
			// FormGameOver
			// 
			this.AcceptButton = this.BtnRestart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.BtnExit;
			this.ClientSize = new System.Drawing.Size(393, 393);
			this.Controls.Add(this.PnlMain);
			this.Controls.Add(this.FlpBottom);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormGameOver";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Game Over";
			this.TlpMain.ResumeLayout(false);
			this.GbSteps.ResumeLayout(false);
			this.TlpSteps.ResumeLayout(false);
			this.TlpSteps.PerformLayout();
			this.GbBonusSteps.ResumeLayout(false);
			this.TlpBonusSteps.ResumeLayout(false);
			this.TlpBonusSteps.PerformLayout();
			this.GbBonusTorch.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.FlpBottom.ResumeLayout(false);
			this.PnlMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel TlpMain;
		private System.Windows.Forms.FlowLayoutPanel FlpBottom;
		private System.Windows.Forms.Label LblStepsRemaining;
		private System.Windows.Forms.Label LblBonusStepsRemaining;
		private System.Windows.Forms.Label LblBonusTorchRemaining;
		private System.Windows.Forms.Label TxtStepsRemaining;
		private System.Windows.Forms.Label TxtBonusStepsRemaining;
		private System.Windows.Forms.Label TxtBonusTorchRemaining;
		private System.Windows.Forms.Label LblTotalSteps;
		private System.Windows.Forms.Label LblTotalBonusStepsTaken;
		private System.Windows.Forms.Label LblTotalBonusSteps;
		private System.Windows.Forms.Label LblTotalBonusTorchTaken;
		private System.Windows.Forms.Label LblTotalBonusTorch;
		private System.Windows.Forms.GroupBox GbSteps;
		private System.Windows.Forms.TableLayoutPanel TlpSteps;
		private System.Windows.Forms.Label TxtTotalSteps;
		private System.Windows.Forms.GroupBox GbBonusSteps;
		private System.Windows.Forms.TableLayoutPanel TlpBonusSteps;
		private System.Windows.Forms.Label TxtTotalBonusStepsTaken;
		private System.Windows.Forms.Label TxtTotalBonusSteps;
		private System.Windows.Forms.GroupBox GbBonusTorch;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label TxtTotalBonusTorchTaken;
		private System.Windows.Forms.Label TxtTotalBonusTorch;
		private System.Windows.Forms.Label LblTitle;
		private System.Windows.Forms.Button BtnExit;
		private System.Windows.Forms.Button BtnRestart;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label LblTimer;
		private System.Windows.Forms.Label TxtTimer;
		private System.Windows.Forms.Panel PnlMain;
	}
}