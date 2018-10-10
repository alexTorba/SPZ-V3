namespace Lb2_V2._0
{
    partial class MergeUniversities
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
            this.saveButton = new System.Windows.Forms.Button();
            this.firstListBox = new System.Windows.Forms.ListBox();
            this.secondListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.saveButton.Location = new System.Drawing.Point(58, 175);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 33);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // firstListBox
            // 
            this.firstListBox.FormattingEnabled = true;
            this.firstListBox.ItemHeight = 16;
            this.firstListBox.Location = new System.Drawing.Point(29, 29);
            this.firstListBox.Name = "firstListBox";
            this.firstListBox.Size = new System.Drawing.Size(120, 116);
            this.firstListBox.TabIndex = 16;
            // 
            // secondListBox
            // 
            this.secondListBox.FormattingEnabled = true;
            this.secondListBox.ItemHeight = 16;
            this.secondListBox.Location = new System.Drawing.Point(235, 29);
            this.secondListBox.Name = "secondListBox";
            this.secondListBox.Size = new System.Drawing.Size(120, 116);
            this.secondListBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(177, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "+";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cancelButton.Location = new System.Drawing.Point(199, 175);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(120, 33);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // MergeUniversityes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 233);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondListBox);
            this.Controls.Add(this.firstListBox);
            this.Controls.Add(this.saveButton);
            this.Name = "MergeUniversityes";
            this.Text = "MergeUniversityes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox firstListBox;
        private System.Windows.Forms.ListBox secondListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
    }
}