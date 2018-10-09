namespace Lb2
{
    partial class AddStudent
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.recordBookLabel = new System.Windows.Forms.Label();
            this.courceLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.courceTextBox = new System.Windows.Forms.TextBox();
            this.recordBookTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(23, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(66, 21);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // recordBookLabel
            // 
            this.recordBookLabel.AutoSize = true;
            this.recordBookLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recordBookLabel.Location = new System.Drawing.Point(23, 133);
            this.recordBookLabel.Name = "recordBookLabel";
            this.recordBookLabel.Size = new System.Drawing.Size(123, 21);
            this.recordBookLabel.TabIndex = 4;
            this.recordBookLabel.Text = "Record book:";
            // 
            // courceLabel
            // 
            this.courceLabel.AutoSize = true;
            this.courceLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.courceLabel.Location = new System.Drawing.Point(23, 74);
            this.courceLabel.Name = "courceLabel";
            this.courceLabel.Size = new System.Drawing.Size(77, 21);
            this.courceLabel.TabIndex = 5;
            this.courceLabel.Text = "Cource:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(23, 39);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(162, 22);
            this.nameTextBox.TabIndex = 6;
            // 
            // courceTextBox
            // 
            this.courceTextBox.Location = new System.Drawing.Point(23, 98);
            this.courceTextBox.Multiline = true;
            this.courceTextBox.Name = "courceTextBox";
            this.courceTextBox.Size = new System.Drawing.Size(162, 22);
            this.courceTextBox.TabIndex = 7;
            // 
            // recordBookTextBox
            // 
            this.recordBookTextBox.Location = new System.Drawing.Point(23, 157);
            this.recordBookTextBox.Multiline = true;
            this.recordBookTextBox.Name = "recordBookTextBox";
            this.recordBookTextBox.Size = new System.Drawing.Size(162, 22);
            this.recordBookTextBox.TabIndex = 8;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.saveButton.Location = new System.Drawing.Point(254, 196);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(103, 35);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.clearButton.Location = new System.Drawing.Point(376, 196);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(103, 35);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 243);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.recordBookTextBox);
            this.Controls.Add(this.courceTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.courceLabel);
            this.Controls.Add(this.recordBookLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label recordBookLabel;
        private System.Windows.Forms.Label courceLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox courceTextBox;
        private System.Windows.Forms.TextBox recordBookTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
    }
}