namespace GeoLocator
{
    partial class MainWindow
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
            this.ChooseSourceFileButton = new System.Windows.Forms.Button();
            this.SourceTextBox = new System.Windows.Forms.TextBox();
            this.lblSourceFile = new System.Windows.Forms.Label();
            this.SourceFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.LoadCsvButton = new System.Windows.Forms.Button();
            this.InsertToDBButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseSourceFileButton
            // 
            this.ChooseSourceFileButton.Location = new System.Drawing.Point(332, 11);
            this.ChooseSourceFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChooseSourceFileButton.Name = "ChooseSourceFileButton";
            this.ChooseSourceFileButton.Size = new System.Drawing.Size(23, 19);
            this.ChooseSourceFileButton.TabIndex = 10;
            this.ChooseSourceFileButton.Text = "...";
            this.ChooseSourceFileButton.UseVisualStyleBackColor = true;
            this.ChooseSourceFileButton.Click += new System.EventHandler(this.ChooseSourceFileButton_Click);
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.Location = new System.Drawing.Point(137, 11);
            this.SourceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.Size = new System.Drawing.Size(192, 20);
            this.SourceTextBox.TabIndex = 9;
            // 
            // lblSourceFile
            // 
            this.lblSourceFile.AutoSize = true;
            this.lblSourceFile.Location = new System.Drawing.Point(12, 14);
            this.lblSourceFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSourceFile.Name = "lblSourceFile";
            this.lblSourceFile.Size = new System.Drawing.Size(84, 13);
            this.lblSourceFile.TabIndex = 8;
            this.lblSourceFile.Text = "Source CSV File";
            // 
            // LoadCsvButton
            // 
            this.LoadCsvButton.Location = new System.Drawing.Point(137, 47);
            this.LoadCsvButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoadCsvButton.Name = "LoadCsvButton";
            this.LoadCsvButton.Size = new System.Drawing.Size(80, 22);
            this.LoadCsvButton.TabIndex = 11;
            this.LoadCsvButton.Text = "Load CSV";
            this.LoadCsvButton.UseVisualStyleBackColor = true;
            this.LoadCsvButton.Click += new System.EventHandler(this.LoadCsvButton_Click);
            // 
            // InsertToDBButton
            // 
            this.InsertToDBButton.Enabled = false;
            this.InsertToDBButton.Location = new System.Drawing.Point(137, 74);
            this.InsertToDBButton.Name = "InsertToDBButton";
            this.InsertToDBButton.Size = new System.Drawing.Size(80, 22);
            this.InsertToDBButton.TabIndex = 12;
            this.InsertToDBButton.Text = "Insert to DB";
            this.InsertToDBButton.UseVisualStyleBackColor = true;
            this.InsertToDBButton.Click += new System.EventHandler(this.InsertToDBButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 108);
            this.Controls.Add(this.InsertToDBButton);
            this.Controls.Add(this.LoadCsvButton);
            this.Controls.Add(this.ChooseSourceFileButton);
            this.Controls.Add(this.SourceTextBox);
            this.Controls.Add(this.lblSourceFile);
            this.Name = "MainWindow";
            this.Text = "GeoLocator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseSourceFileButton;
        private System.Windows.Forms.TextBox SourceTextBox;
        private System.Windows.Forms.Label lblSourceFile;
        private System.Windows.Forms.OpenFileDialog SourceFileDialog;
        private System.Windows.Forms.Button LoadCsvButton;
        private System.Windows.Forms.Button InsertToDBButton;
    }
}

