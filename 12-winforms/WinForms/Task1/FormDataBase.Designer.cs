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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataBase));
            this.tcTables = new System.Windows.Forms.TabControl();
            this.tpUsers = new System.Windows.Forms.TabPage();
            this.dgvUsersTable = new System.Windows.Forms.DataGridView();
            this.menustrUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tpAwards = new System.Windows.Forms.TabPage();
            this.dgvAwardsTable = new System.Windows.Forms.DataGridView();
            this.menustrAwards = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAddAward = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditAward = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteAward = new System.Windows.Forms.ToolStripMenuItem();
            this.tcTables.SuspendLayout();
            this.tpUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersTable)).BeginInit();
            this.menustrUser.SuspendLayout();
            this.tpAwards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwardsTable)).BeginInit();
            this.menustrAwards.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcTables
            // 
            this.tcTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcTables.Controls.Add(this.tpUsers);
            this.tcTables.Controls.Add(this.tpAwards);
            this.tcTables.Location = new System.Drawing.Point(0, 0);
            this.tcTables.Multiline = true;
            this.tcTables.Name = "tcTables";
            this.tcTables.SelectedIndex = 0;
            this.tcTables.Size = new System.Drawing.Size(1074, 483);
            this.tcTables.TabIndex = 0;
            // 
            // tpUsers
            // 
            this.tpUsers.Controls.Add(this.dgvUsersTable);
            this.tpUsers.Location = new System.Drawing.Point(4, 24);
            this.tpUsers.Name = "tpUsers";
            this.tpUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsers.Size = new System.Drawing.Size(1066, 455);
            this.tpUsers.TabIndex = 0;
            this.tpUsers.Text = "Users";
            this.tpUsers.UseVisualStyleBackColor = true;
            // 
            // dgvUsersTable
            // 
            this.dgvUsersTable.AllowUserToAddRows = false;
            this.dgvUsersTable.AllowUserToDeleteRows = false;
            this.dgvUsersTable.AllowUserToResizeRows = false;
            this.dgvUsersTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsersTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsersTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUsersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersTable.ContextMenuStrip = this.menustrUser;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsersTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsersTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUsersTable.Location = new System.Drawing.Point(3, 3);
            this.dgvUsersTable.Name = "dgvUsersTable";
            this.dgvUsersTable.RowHeadersWidth = 51;
            this.dgvUsersTable.RowTemplate.Height = 25;
            this.dgvUsersTable.Size = new System.Drawing.Size(1060, 449);
            this.dgvUsersTable.TabIndex = 0;
            this.dgvUsersTable.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsersTable_ColumnHeaderMouseClick);
            // 
            // menustrUser
            // 
            this.menustrUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddUser,
            this.menuEditUser,
            this.menuDeleteUser});
            this.menustrUser.Name = "contextMenuStrip1";
            this.menustrUser.Size = new System.Drawing.Size(134, 70);
            // 
            // menuAddUser
            // 
            this.menuAddUser.Name = "menuAddUser";
            this.menuAddUser.Size = new System.Drawing.Size(133, 22);
            this.menuAddUser.Text = "Add User";
            this.menuAddUser.Click += new System.EventHandler(this.menuAddUser_Click);
            // 
            // menuEditUser
            // 
            this.menuEditUser.Name = "menuEditUser";
            this.menuEditUser.Size = new System.Drawing.Size(133, 22);
            this.menuEditUser.Text = "Edit User";
            this.menuEditUser.Click += new System.EventHandler(this.menuEditUser_Click);
            // 
            // menuDeleteUser
            // 
            this.menuDeleteUser.Name = "menuDeleteUser";
            this.menuDeleteUser.Size = new System.Drawing.Size(133, 22);
            this.menuDeleteUser.Text = "Delete User";
            this.menuDeleteUser.Click += new System.EventHandler(this.menuDeleteUser_Click);
            // 
            // tpAwards
            // 
            this.tpAwards.Controls.Add(this.dgvAwardsTable);
            this.tpAwards.Location = new System.Drawing.Point(4, 24);
            this.tpAwards.Name = "tpAwards";
            this.tpAwards.Padding = new System.Windows.Forms.Padding(3);
            this.tpAwards.Size = new System.Drawing.Size(1066, 455);
            this.tpAwards.TabIndex = 1;
            this.tpAwards.Text = "Awards";
            this.tpAwards.UseVisualStyleBackColor = true;
            // 
            // dgvAwardsTable
            // 
            this.dgvAwardsTable.AllowUserToAddRows = false;
            this.dgvAwardsTable.AllowUserToDeleteRows = false;
            this.dgvAwardsTable.AllowUserToResizeRows = false;
            this.dgvAwardsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAwardsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAwardsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvAwardsTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAwardsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAwardsTable.ContextMenuStrip = this.menustrAwards;
            this.dgvAwardsTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAwardsTable.Location = new System.Drawing.Point(3, 3);
            this.dgvAwardsTable.Name = "dgvAwardsTable";
            this.dgvAwardsTable.RowHeadersWidth = 51;
            this.dgvAwardsTable.RowTemplate.Height = 25;
            this.dgvAwardsTable.Size = new System.Drawing.Size(1060, 449);
            this.dgvAwardsTable.TabIndex = 0;
            this.dgvAwardsTable.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAwardsTable_ColumnHeaderMouseClick);
            // 
            // menustrAwards
            // 
            this.menustrAwards.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddAward,
            this.menuEditAward,
            this.menuDeleteAward});
            this.menustrAwards.Name = "contextMenuStrip3";
            this.menustrAwards.Size = new System.Drawing.Size(145, 70);
            // 
            // menuAddAward
            // 
            this.menuAddAward.Name = "menuAddAward";
            this.menuAddAward.Size = new System.Drawing.Size(144, 22);
            this.menuAddAward.Text = "Add Award";
            this.menuAddAward.Click += new System.EventHandler(this.menuAddAward_Click);
            // 
            // menuEditAward
            // 
            this.menuEditAward.Name = "menuEditAward";
            this.menuEditAward.Size = new System.Drawing.Size(144, 22);
            this.menuEditAward.Text = "Edit Award";
            this.menuEditAward.Click += new System.EventHandler(this.menuEditAward_Click);
            // 
            // menuDeleteAward
            // 
            this.menuDeleteAward.Name = "menuDeleteAward";
            this.menuDeleteAward.Size = new System.Drawing.Size(144, 22);
            this.menuDeleteAward.Text = "Delete Award";
            this.menuDeleteAward.Click += new System.EventHandler(this.menuDeleteAward_Click);
            // 
            // FormDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 509);
            this.Controls.Add(this.tcTables);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(958, 548);
            this.Name = "FormDataBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Awards";
            this.Load += new System.EventHandler(this.FormDataBase_Load);
            this.tcTables.ResumeLayout(false);
            this.tpUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersTable)).EndInit();
            this.menustrUser.ResumeLayout(false);
            this.tpAwards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwardsTable)).EndInit();
            this.menustrAwards.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcTables;
        private System.Windows.Forms.TabPage tpUsers;
        private System.Windows.Forms.TabPage tpAwards;
        private System.Windows.Forms.DataGridView dgvUsersTable;
        private System.Windows.Forms.DataGridView dgvAwardsTable;
        private System.Windows.Forms.ContextMenuStrip menustrUser;
        private System.Windows.Forms.ToolStripMenuItem menuAddUser;
        private System.Windows.Forms.ToolStripMenuItem menuEditUser;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteUser;
        private System.Windows.Forms.ContextMenuStrip menustrAwards;
        private System.Windows.Forms.ToolStripMenuItem menuAddAward;
        private System.Windows.Forms.ToolStripMenuItem menuEditAward;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteAward;
    }
}
