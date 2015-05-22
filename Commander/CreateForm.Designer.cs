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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateForm));
            this.folderNameBox = new System.Windows.Forms.TextBox();
            this.createFolderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderNameBox
            // 
            resources.ApplyResources(this.folderNameBox, "folderNameBox");
            this.folderNameBox.Name = "folderNameBox";
            // 
            // createFolderButton
            // 
            resources.ApplyResources(this.createFolderButton, "createFolderButton");
            this.createFolderButton.Name = "createFolderButton";
            this.createFolderButton.UseVisualStyleBackColor = true;
            this.createFolderButton.Click += new System.EventHandler(this.createFolderButton_Click);
            // 
            // CreateForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
