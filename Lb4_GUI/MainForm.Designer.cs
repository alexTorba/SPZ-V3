namespace Lb4_GUI
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.InputFileContentTB = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.TopMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveResultMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.GenerateNumbersB = new System.Windows.Forms.Button();
			this.RunB = new System.Windows.Forms.Button();
			this.ResultTB = new System.Windows.Forms.TextBox();
			this.InputLBL = new System.Windows.Forms.Label();
			this.ResultLBL = new System.Windows.Forms.Label();
			this.NumbersToGenerateNUD = new System.Windows.Forms.NumericUpDown();
			this.NumbersToGenerateLBL = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumbersToGenerateNUD)).BeginInit();
			this.SuspendLayout();
			// 
			// InputFileContentTB
			// 
			this.InputFileContentTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.InputFileContentTB.Location = new System.Drawing.Point(97, 27);
			this.InputFileContentTB.Name = "InputFileContentTB";
			this.InputFileContentTB.Size = new System.Drawing.Size(378, 20);
			this.InputFileContentTB.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TopMenu});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(487, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// TopMenu
			// 
			this.TopMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenuItem,
            this.SaveResultMenuItem});
			this.TopMenu.Name = "TopMenu";
			this.TopMenu.Size = new System.Drawing.Size(37, 20);
			this.TopMenu.Text = "File";
			// 
			// OpenMenuItem
			// 
			this.OpenMenuItem.Name = "OpenMenuItem";
			this.OpenMenuItem.Size = new System.Drawing.Size(133, 22);
			this.OpenMenuItem.Text = "Open";
			this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
			// 
			// SaveResultMenuItem
			// 
			this.SaveResultMenuItem.Name = "SaveResultMenuItem";
			this.SaveResultMenuItem.Size = new System.Drawing.Size(133, 22);
			this.SaveResultMenuItem.Text = "Save Result";
			this.SaveResultMenuItem.Click += new System.EventHandler(this.SaveResultMenuItem_Click);
			// 
			// GenerateNumbersB
			// 
			this.GenerateNumbersB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.GenerateNumbersB.Location = new System.Drawing.Point(12, 100);
			this.GenerateNumbersB.Name = "GenerateNumbersB";
			this.GenerateNumbersB.Size = new System.Drawing.Size(264, 23);
			this.GenerateNumbersB.TabIndex = 2;
			this.GenerateNumbersB.Text = "Clear Input And Generete New Numbers";
			this.GenerateNumbersB.UseVisualStyleBackColor = true;
			this.GenerateNumbersB.Click += new System.EventHandler(this.GenerateNumbersB_Click);
			// 
			// RunB
			// 
			this.RunB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.RunB.Location = new System.Drawing.Point(12, 129);
			this.RunB.Name = "RunB";
			this.RunB.Size = new System.Drawing.Size(463, 23);
			this.RunB.TabIndex = 3;
			this.RunB.Text = "Count Lenght Of Sequnces";
			this.RunB.UseVisualStyleBackColor = true;
			this.RunB.Click += new System.EventHandler(this.RunB_Click);
			// 
			// ResultTB
			// 
			this.ResultTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ResultTB.Location = new System.Drawing.Point(97, 53);
			this.ResultTB.Name = "ResultTB";
			this.ResultTB.ReadOnly = true;
			this.ResultTB.Size = new System.Drawing.Size(378, 20);
			this.ResultTB.TabIndex = 4;
			// 
			// InputLBL
			// 
			this.InputLBL.AutoSize = true;
			this.InputLBL.Location = new System.Drawing.Point(13, 33);
			this.InputLBL.Name = "InputLBL";
			this.InputLBL.Size = new System.Drawing.Size(34, 13);
			this.InputLBL.TabIndex = 5;
			this.InputLBL.Text = "Input:";
			// 
			// ResultLBL
			// 
			this.ResultLBL.AutoSize = true;
			this.ResultLBL.Location = new System.Drawing.Point(13, 59);
			this.ResultLBL.Name = "ResultLBL";
			this.ResultLBL.Size = new System.Drawing.Size(40, 13);
			this.ResultLBL.TabIndex = 6;
			this.ResultLBL.Text = "Result:";
			// 
			// NumbersToGenerateNUD
			// 
			this.NumbersToGenerateNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.NumbersToGenerateNUD.Location = new System.Drawing.Point(282, 100);
			this.NumbersToGenerateNUD.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.NumbersToGenerateNUD.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.NumbersToGenerateNUD.Name = "NumbersToGenerateNUD";
			this.NumbersToGenerateNUD.Size = new System.Drawing.Size(77, 20);
			this.NumbersToGenerateNUD.TabIndex = 7;
			this.NumbersToGenerateNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// NumbersToGenerateLBL
			// 
			this.NumbersToGenerateLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.NumbersToGenerateLBL.AutoSize = true;
			this.NumbersToGenerateLBL.Location = new System.Drawing.Point(365, 102);
			this.NumbersToGenerateLBL.Name = "NumbersToGenerateLBL";
			this.NumbersToGenerateLBL.Size = new System.Drawing.Size(110, 13);
			this.NumbersToGenerateLBL.TabIndex = 8;
			this.NumbersToGenerateLBL.Text = "- numbers to generate";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(487, 164);
			this.Controls.Add(this.NumbersToGenerateLBL);
			this.Controls.Add(this.NumbersToGenerateNUD);
			this.Controls.Add(this.ResultLBL);
			this.Controls.Add(this.InputLBL);
			this.Controls.Add(this.ResultTB);
			this.Controls.Add(this.RunB);
			this.Controls.Add(this.GenerateNumbersB);
			this.Controls.Add(this.InputFileContentTB);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(503, 203);
			this.Name = "MainForm";
			this.Text = "Lb4";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumbersToGenerateNUD)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox InputFileContentTB;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem TopMenu;
		private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SaveResultMenuItem;
		private System.Windows.Forms.Button GenerateNumbersB;
		private System.Windows.Forms.Button RunB;
		private System.Windows.Forms.TextBox ResultTB;
		private System.Windows.Forms.Label InputLBL;
		private System.Windows.Forms.Label ResultLBL;
		private System.Windows.Forms.NumericUpDown NumbersToGenerateNUD;
		private System.Windows.Forms.Label NumbersToGenerateLBL;
	}
}

