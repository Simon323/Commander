namespace Commander
{
    partial class CreateForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderNameBox = new System.Windows.Forms.TextBox();
            this.createFolderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderNameBox
            // 
            this.folderNameBox.Location = new System.Drawing.Point(12, 10);
            this.folderNameBox.Name = "folderNameBox";
            this.folderNameBox.Size = new System.Drawing.Size(179, 20);
            this.folderNameBox.TabIndex = 0;
            // 
            // createFolderButton
            // 
            this.createFolderButton.Location = new System.Drawing.Point(197, 8);
            this.createFolderButton.Name = "createFolderButton";
            this.createFolderButton.Size = new System.Drawing.Size(75, 23);
            this.createFolderButton.TabIndex = 1;
            this.createFolderButton.Text = "Ok";
            this.createFolderButton.UseVisualStyleBackColor = true;
            this.createFolderButton.Click += new System.EventHandler(this.createFolderButton_Click);
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 40);
            this.Controls.Add(this.createFolderButton);
            this.Controls.Add(this.folderNameBox);
            this.Name = "CreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox folderNameBox;
        public System.Windows.Forms.Button createFolderButton;
    }
}
