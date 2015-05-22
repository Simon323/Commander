namespace Commander
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.driveComboLeft = new System.Windows.Forms.ComboBox();
            this.dataGVLeft = new System.Windows.Forms.DataGridView();
            this.PathLeftDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameLeftDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeLeftDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateLeftDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsRootLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathBoxLeft = new System.Windows.Forms.TextBox();
            this.menuStripBottom = new System.Windows.Forms.MenuStrip();
            this.preview = new System.Windows.Forms.ToolStripMenuItem();
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.copy = new System.Windows.Forms.ToolStripMenuItem();
            this.create = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.close = new System.Windows.Forms.ToolStripMenuItem();
            this.driveComboRight = new System.Windows.Forms.ComboBox();
            this.pathBoxRight = new System.Windows.Forms.TextBox();
            this.dataGVRight = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.changeLanguage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVLeft)).BeginInit();
            this.menuStripBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVRight)).BeginInit();
            this.SuspendLayout();
            // 
            // driveComboLeft
            // 
            resources.ApplyResources(this.driveComboLeft, "driveComboLeft");
            this.driveComboLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driveComboLeft.Name = "driveComboLeft";
            this.driveComboLeft.SelectedIndexChanged += new System.EventHandler(this.driveComboLeft_SelectedIndexChanged);
            // 
            // dataGVLeft
            // 
            resources.ApplyResources(this.dataGVLeft, "dataGVLeft");
            this.dataGVLeft.AllowUserToAddRows = false;
            this.dataGVLeft.AllowUserToResizeRows = false;
            this.dataGVLeft.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGVLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVLeft.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PathLeftDG,
            this.NameLeftDG,
            this.SizeLeftDG,
            this.DateLeftDG,
            this.IsRootLeft});
            this.dataGVLeft.MultiSelect = false;
            this.dataGVLeft.Name = "dataGVLeft";
            this.dataGVLeft.ReadOnly = true;
            this.dataGVLeft.RowHeadersVisible = false;
            this.dataGVLeft.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVLeft.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVLeft_CellClick);
            this.dataGVLeft.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVLeft_CellDoubleClick);
            // 
            // PathLeftDG
            // 
            resources.ApplyResources(this.PathLeftDG, "PathLeftDG");
            this.PathLeftDG.Name = "PathLeftDG";
            this.PathLeftDG.ReadOnly = true;
            // 
            // NameLeftDG
            // 
            resources.ApplyResources(this.NameLeftDG, "NameLeftDG");
            this.NameLeftDG.Name = "NameLeftDG";
            this.NameLeftDG.ReadOnly = true;
            // 
            // SizeLeftDG
            // 
            resources.ApplyResources(this.SizeLeftDG, "SizeLeftDG");
            this.SizeLeftDG.Name = "SizeLeftDG";
            this.SizeLeftDG.ReadOnly = true;
            // 
            // DateLeftDG
            // 
            resources.ApplyResources(this.DateLeftDG, "DateLeftDG");
            this.DateLeftDG.Name = "DateLeftDG";
            this.DateLeftDG.ReadOnly = true;
            // 
            // IsRootLeft
            // 
            resources.ApplyResources(this.IsRootLeft, "IsRootLeft");
            this.IsRootLeft.Name = "IsRootLeft";
            this.IsRootLeft.ReadOnly = true;
            // 
            // pathBoxLeft
            // 
            resources.ApplyResources(this.pathBoxLeft, "pathBoxLeft");
            this.pathBoxLeft.BackColor = System.Drawing.SystemColors.Window;
            this.pathBoxLeft.Name = "pathBoxLeft";
            this.pathBoxLeft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pathBoxLeft_KeyDown);
            // 
            // menuStripBottom
            // 
            resources.ApplyResources(this.menuStripBottom, "menuStripBottom");
            this.menuStripBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preview,
            this.edit,
            this.copy,
            this.create,
            this.delete,
            this.close});
            this.menuStripBottom.Name = "menuStripBottom";
            this.menuStripBottom.ShowItemToolTips = true;
            // 
            // preview
            // 
            resources.ApplyResources(this.preview, "preview");
            this.preview.Name = "preview";
            this.preview.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.preview.Click += new System.EventHandler(this.preview_Click);
            // 
            // edit
            // 
            resources.ApplyResources(this.edit, "edit");
            this.edit.Name = "edit";
            this.edit.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // copy
            // 
            resources.ApplyResources(this.copy, "copy");
            this.copy.Name = "copy";
            this.copy.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // create
            // 
            resources.ApplyResources(this.create, "create");
            this.create.Name = "create";
            this.create.Padding = new System.Windows.Forms.Padding(45, 0, 45, 0);
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // delete
            // 
            resources.ApplyResources(this.delete, "delete");
            this.delete.Name = "delete";
            this.delete.Padding = new System.Windows.Forms.Padding(45, 0, 45, 0);
            // 
            // close
            // 
            resources.ApplyResources(this.close, "close");
            this.close.Name = "close";
            this.close.Padding = new System.Windows.Forms.Padding(45, 0, 45, 0);
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // driveComboRight
            // 
            resources.ApplyResources(this.driveComboRight, "driveComboRight");
            this.driveComboRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driveComboRight.Name = "driveComboRight";
            this.driveComboRight.SelectedIndexChanged += new System.EventHandler(this.driveComboRight_SelectedIndexChanged);
            // 
            // pathBoxRight
            // 
            resources.ApplyResources(this.pathBoxRight, "pathBoxRight");
            this.pathBoxRight.Name = "pathBoxRight";
            this.pathBoxRight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pathBoxRight_KeyDown);
            // 
            // dataGVRight
            // 
            resources.ApplyResources(this.dataGVRight, "dataGVRight");
            this.dataGVRight.AllowUserToAddRows = false;
            this.dataGVRight.AllowUserToResizeRows = false;
            this.dataGVRight.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGVRight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVRight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGVRight.MultiSelect = false;
            this.dataGVRight.Name = "dataGVRight";
            this.dataGVRight.ReadOnly = true;
            this.dataGVRight.RowHeadersVisible = false;
            this.dataGVRight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVRight.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVRight_CellClick);
            this.dataGVRight.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVRight_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // changeLanguage
            // 
            resources.ApplyResources(this.changeLanguage, "changeLanguage");
            this.changeLanguage.Name = "changeLanguage";
            this.changeLanguage.UseVisualStyleBackColor = true;
            this.changeLanguage.Click += new System.EventHandler(this.changeLanguage_Click);
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.changeLanguage);
            this.Controls.Add(this.dataGVRight);
            this.Controls.Add(this.pathBoxRight);
            this.Controls.Add(this.driveComboRight);
            this.Controls.Add(this.pathBoxLeft);
            this.Controls.Add(this.dataGVLeft);
            this.Controls.Add(this.driveComboLeft);
            this.Controls.Add(this.menuStripBottom);
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVLeft)).EndInit();
            this.menuStripBottom.ResumeLayout(false);
            this.menuStripBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox driveComboLeft;
        private System.Windows.Forms.DataGridView dataGVLeft;
        private System.Windows.Forms.TextBox pathBoxLeft;
        private System.Windows.Forms.MenuStrip menuStripBottom;
        private System.Windows.Forms.ToolStripMenuItem preview;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem copy;
        private System.Windows.Forms.ToolStripMenuItem create;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.ToolStripMenuItem close;
        private System.Windows.Forms.ComboBox driveComboRight;
        private System.Windows.Forms.TextBox pathBoxRight;
        private System.Windows.Forms.DataGridView dataGVRight;
        public System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button changeLanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn PathLeftDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameLeftDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeLeftDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateLeftDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsRootLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

