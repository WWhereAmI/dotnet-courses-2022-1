namespace Task1
{
    partial class FormDataBase
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataBase));
            this.tcTables = new System.Windows.Forms.TabControl();
            this.tpUsers = new System.Windows.Forms.TabPage();
            this.dgvUsersTable = new System.Windows.Forms.DataGridView();
            this.tpAwards = new System.Windows.Forms.TabPage();
            this.dgvAwardsTable = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tcTables.SuspendLayout();
            this.tpUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersTable)).BeginInit();
            this.tpAwards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwardsTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcTables
            // 
            this.tcTables.Controls.Add(this.tpUsers);
            this.tcTables.Controls.Add(this.tpAwards);
            this.tcTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcTables.Location = new System.Drawing.Point(0, 24);
            this.tcTables.Multiline = true;
            this.tcTables.Name = "tcTables";
            this.tcTables.SelectedIndex = 0;
            this.tcTables.Size = new System.Drawing.Size(966, 440);
            this.tcTables.TabIndex = 0;
            // 
            // tpUsers
            // 
            this.tpUsers.Controls.Add(this.dgvUsersTable);
            this.tpUsers.Location = new System.Drawing.Point(4, 24);
            this.tpUsers.Name = "tpUsers";
            this.tpUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsers.Size = new System.Drawing.Size(958, 412);
            this.tpUsers.TabIndex = 0;
            this.tpUsers.Text = "Users";
            this.tpUsers.UseVisualStyleBackColor = true;
            // 
            // dgvUsersTable
            // 
            this.dgvUsersTable.AllowUserToAddRows = false;
            this.dgvUsersTable.AllowUserToDeleteRows = false;
            this.dgvUsersTable.AllowUserToResizeRows = false;
            this.dgvUsersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsersTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUsersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsersTable.Location = new System.Drawing.Point(3, 3);
            this.dgvUsersTable.Name = "dgvUsersTable";
            this.dgvUsersTable.RowTemplate.Height = 25;
            this.dgvUsersTable.Size = new System.Drawing.Size(952, 406);
            this.dgvUsersTable.TabIndex = 0;
            // 
            // tpAwards
            // 
            this.tpAwards.Controls.Add(this.dgvAwardsTable);
            this.tpAwards.Location = new System.Drawing.Point(4, 24);
            this.tpAwards.Name = "tpAwards";
            this.tpAwards.Padding = new System.Windows.Forms.Padding(3);
            this.tpAwards.Size = new System.Drawing.Size(958, 412);
            this.tpAwards.TabIndex = 1;
            this.tpAwards.Text = "Awards";
            this.tpAwards.UseVisualStyleBackColor = true;
            // 
            // dgvAwardsTable
            // 
            this.dgvAwardsTable.AllowUserToAddRows = false;
            this.dgvAwardsTable.AllowUserToDeleteRows = false;
            this.dgvAwardsTable.AllowUserToResizeRows = false;
            this.dgvAwardsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAwardsTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAwardsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAwardsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAwardsTable.Location = new System.Drawing.Point(3, 3);
            this.dgvAwardsTable.Name = "dgvAwardsTable";
            this.dgvAwardsTable.RowTemplate.Height = 25;
            this.dgvAwardsTable.Size = new System.Drawing.Size(952, 406);
            this.dgvAwardsTable.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(966, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImport,
            this.menuExport});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuImport
            // 
            this.menuImport.Name = "menuImport";
            this.menuImport.Size = new System.Drawing.Size(180, 22);
            this.menuImport.Text = "Import Table";
            this.menuImport.Click += new System.EventHandler(this.menuImport_Click);
            // 
            // menuExport
            // 
            this.menuExport.Name = "menuExport";
            this.menuExport.Size = new System.Drawing.Size(180, 22);
            this.menuExport.Text = "Export Table";
            this.menuExport.Click += new System.EventHandler(this.menuExport_Click);
            // 
            // FormDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 496);
            this.Controls.Add(this.tcTables);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDataBase";
            this.Text = "Nobel Prizes";
            this.Load += new System.EventHandler(this.FormDataBase_Load);
            this.tcTables.ResumeLayout(false);
            this.tpUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersTable)).EndInit();
            this.tpAwards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwardsTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcTables;
        private System.Windows.Forms.TabPage tpUsers;
        private System.Windows.Forms.TabPage tpAwards;
        private System.Windows.Forms.DataGridView dgvUsersTable;
        private System.Windows.Forms.DataGridView dgvAwardsTable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuImport;
        private System.Windows.Forms.ToolStripMenuItem menuExport;
    }
}
