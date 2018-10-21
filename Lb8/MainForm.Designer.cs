namespace Lb8
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
			this.fileText = new System.Windows.Forms.TextBox();
			this.menu = new System.Windows.Forms.MenuStrip();
			this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.openFile = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFile = new System.Windows.Forms.ToolStripMenuItem();
			this.closeFile = new System.Windows.Forms.ToolStripMenuItem();
			this.chooseMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// fileText
			// 
			this.fileText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fileText.Location = new System.Drawing.Point(0, 27);
			this.fileText.Multiline = true;
			this.fileText.Name = "fileText";
			this.fileText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.fileText.Size = new System.Drawing.Size(803, 424);
			this.fileText.TabIndex = 0;
			this.fileText.WordWrap = false;
			// 
			// menu
			// 
			this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.chooseMenu});
			this.menu.Location = new System.Drawing.Point(0, 0);
			this.menu.Name = "menu";
			this.menu.Size = new System.Drawing.Size(800, 24);
			this.menu.TabIndex = 1;
			this.menu.Text = "Menu";
			// 
			// fileMenu
			// 
			this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile,
            this.saveFile,
            this.closeFile});
			this.fileMenu.Name = "fileMenu";
			this.fileMenu.Size = new System.Drawing.Size(37, 20);
			this.fileMenu.Text = "File";
			// 
			// openFile
			// 
			this.openFile.Name = "openFile";
			this.openFile.Size = new System.Drawing.Size(180, 22);
			this.openFile.Text = "Open";
			this.openFile.Click += OpenFile_Click;
			// 
			// saveFile
			// 
			this.saveFile.Name = "saveFile";
			this.saveFile.Size = new System.Drawing.Size(180, 22);
			this.saveFile.Text = "Save";
			// 
			// closeFile
			// 
			this.closeFile.Name = "closeFile";
			this.closeFile.Size = new System.Drawing.Size(180, 22);
			this.closeFile.Text = "Close";
			// 
			// chooseMenu
			// 
			this.chooseMenu.Name = "chooseMenu";
			this.chooseMenu.Size = new System.Drawing.Size(86, 20);
			this.chooseMenu.Text = "Choose Font";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.fileText);
			this.Controls.Add(this.menu);
			this.MainMenuStrip = this.menu;
			this.Name = "MainForm";
			this.Text = "Lb8";
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox fileText;
		private System.Windows.Forms.MenuStrip menu;
		private System.Windows.Forms.ToolStripMenuItem fileMenu;
		private System.Windows.Forms.ToolStripMenuItem openFile;
		private System.Windows.Forms.ToolStripMenuItem saveFile;
		private System.Windows.Forms.ToolStripMenuItem closeFile;
		private System.Windows.Forms.ToolStripMenuItem chooseMenu;
	}
}

