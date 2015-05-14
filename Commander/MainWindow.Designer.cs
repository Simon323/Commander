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
            this.driveComboLeft = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGVLeft = new System.Windows.Forms.DataGridView();
            this.PathLeftDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameLeftDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeLeftDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateLeftDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsRootLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathBoxLeft = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // driveComboLeft
            // 
            this.driveComboLeft.Location = new System.Drawing.Point(12, 68);
            this.driveComboLeft.Name = "driveComboLeft";
            this.driveComboLeft.Size = new System.Drawing.Size(121, 21);
            this.driveComboLeft.TabIndex = 0;
            this.driveComboLeft.SelectedIndexChanged += new System.EventHandler(this.driveComboLeft_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(411, 68);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // dataGVLeft
            // 
            this.dataGVLeft.AllowUserToResizeRows = false;
            this.dataGVLeft.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGVLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVLeft.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PathLeftDG,
            this.NameLeftDG,
            this.SizeLeftDG,
            this.DateLeftDG,
            this.IsRootLeft});
            this.dataGVLeft.Location = new System.Drawing.Point(16, 133);
            this.dataGVLeft.MultiSelect = false;
            this.dataGVLeft.Name = "dataGVLeft";
            this.dataGVLeft.ReadOnly = true;
            this.dataGVLeft.RowHeadersVisible = false;
            this.dataGVLeft.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVLeft.Size = new System.Drawing.Size(361, 323);
            this.dataGVLeft.TabIndex = 4;
            this.dataGVLeft.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVLeft_CellDoubleClick);
            // 
            // PathLeftDG
            // 
            this.PathLeftDG.HeaderText = "Path";
            this.PathLeftDG.Name = "PathLeftDG";
            this.PathLeftDG.ReadOnly = true;
            // 
            // NameLeftDG
            // 
            this.NameLeftDG.HeaderText = "Name";
            this.NameLeftDG.Name = "NameLeftDG";
            this.NameLeftDG.ReadOnly = true;
            // 
            // SizeLeftDG
            // 
            this.SizeLeftDG.HeaderText = "Size";
            this.SizeLeftDG.Name = "SizeLeftDG";
            this.SizeLeftDG.ReadOnly = true;
            // 
            // DateLeftDG
            // 
            this.DateLeftDG.HeaderText = "Date";
            this.DateLeftDG.Name = "DateLeftDG";
            this.DateLeftDG.ReadOnly = true;
            // 
            // IsRootLeft
            // 
            this.IsRootLeft.HeaderText = "IsRoot";
            this.IsRootLeft.Name = "IsRootLeft";
            this.IsRootLeft.ReadOnly = true;
            // 
            // pathBoxLeft
            // 
            this.pathBoxLeft.Location = new System.Drawing.Point(12, 96);
            this.pathBoxLeft.Name = "pathBoxLeft";
            this.pathBoxLeft.Size = new System.Drawing.Size(365, 20);
            this.pathBoxLeft.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(411, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(365, 20);
            this.textBox2.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView2.Location = new System.Drawing.Point(415, 133);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(361, 323);
            this.dataGridView2.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Path";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 50F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Extension";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Size";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pathBoxLeft);
            this.Controls.Add(this.dataGVLeft);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.driveComboLeft);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox driveComboLeft;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGVLeft;
        private System.Windows.Forms.TextBox pathBoxLeft;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PathLeftDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameLeftDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeLeftDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateLeftDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsRootLeft;
    }
}

