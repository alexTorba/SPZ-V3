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
			this.chooseMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.chooseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeFromRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.saveFile});
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
			this.saveFile.Click += SaveFile_Click;
			// 
			// chooseMenu
			// 
			this.chooseMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseToolStripMenuItem,
            this.saveToRegisterToolStripMenuItem,
            this.removeFromRegisterToolStripMenuItem});
			this.chooseMenu.Name = "chooseMenu";
			this.chooseMenu.Size = new System.Drawing.Size(43, 20);
			this.chooseMenu.Text = "Font";
			// 
			// chooseToolStripMenuItem
			// 
			this.chooseToolStripMenuItem.Name = "chooseToolStripMenuItem";
			this.chooseToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.chooseToolStripMenuItem.Text = "Choose";
			this.chooseToolStripMenuItem.Click += ChooseFont_Clicked;
			// 
			// saveToRegisterToolStripMenuItem
			// 
			this.saveToRegisterToolStripMenuItem.Name = "saveToRegisterToolStripMenuItem";
			this.saveToRegisterToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.saveToRegisterToolStripMenuItem.Text = "Save to register";
			this.saveToRegisterToolStripMenuItem.Click += SaveToRegister_Clicked;
			// 
			// removeFromRegisterToolStripMenuItem
			// 
			this.removeFromRegisterToolStripMenuItem.Name = "removeFromRegisterToolStripMenuItem";
			this.removeFromRegisterToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.removeFromRegisterToolStripMenuItem.Text = "Remove from register";
			this.removeFromRegisterToolStripMenuItem.Click += RemoveFromRegister_Clicked;
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
		private System.Windows.Forms.ToolStripMenuItem chooseMenu;
		private System.Windows.Forms.ToolStripMenuItem chooseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToRegisterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeFromRegisterToolStripMenuItem;
	}
}

