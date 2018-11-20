namespace Lb5.View
{
	partial class AddSubjectForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font( "Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 204 ) ) );
			this.label1.Location = new System.Drawing.Point( 24, 22 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 57, 20 );
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point( 87, 22 );
			this.nameTextBox.Multiline = true;
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size( 147, 22 );
			this.nameTextBox.TabIndex = 1;
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point( 28, 75 );
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size( 206, 29 );
			this.saveButton.TabIndex = 2;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler( this.saveButton_Click );
			// 
			// AddSubjectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 8F, 16F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 246, 129 );
			this.Controls.Add( this.saveButton );
			this.Controls.Add( this.nameTextBox );
			this.Controls.Add( this.label1 );
			this.Name = "AddSubjectForm";
			this.Text = "AddSubjectForm";
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Button saveButton;
	}
}