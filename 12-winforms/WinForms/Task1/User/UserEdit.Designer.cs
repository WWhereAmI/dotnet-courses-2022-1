namespace Task1
{
    partial class UserEdit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEdit));
            this.tbBitrhDateUser = new System.Windows.Forms.DateTimePicker();
            this.btnSaveEditedUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLastNameUser = new System.Windows.Forms.TextBox();
            this.tbFirstNameUser = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbAvailableAwards = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.lbUserAwards = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBitrhDateUser
            // 
            this.tbBitrhDateUser.Location = new System.Drawing.Point(138, 134);
            this.tbBitrhDateUser.Name = "tbBitrhDateUser";
            this.tbBitrhDateUser.Size = new System.Drawing.Size(240, 23);
            this.tbBitrhDateUser.TabIndex = 15;
            // 
            // btnSaveEditedUser
            // 
            this.btnSaveEditedUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSaveEditedUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSaveEditedUser.Location = new System.Drawing.Point(0, 417);
            this.btnSaveEditedUser.Name = "btnSaveEditedUser";
            this.btnSaveEditedUser.Size = new System.Drawing.Size(490, 47);
            this.btnSaveEditedUser.TabIndex = 14;
            this.btnSaveEditedUser.Text = "Save Changes";
            this.btnSaveEditedUser.UseVisualStyleBackColor = true;
            this.btnSaveEditedUser.Click += new System.EventHandler(this.btnSaveEditedUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Birth Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "First Name";
            // 
            // tbLastNameUser
            // 
            this.tbLastNameUser.Location = new System.Drawing.Point(138, 73);
            this.tbLastNameUser.MaxLength = 50;
            this.tbLastNameUser.Name = "tbLastNameUser";
            this.tbLastNameUser.Size = new System.Drawing.Size(240, 23);
            this.tbLastNameUser.TabIndex = 10;
            // 
            // tbFirstNameUser
            // 
            this.tbFirstNameUser.Location = new System.Drawing.Point(138, 15);
            this.tbFirstNameUser.MaxLength = 50;
            this.tbFirstNameUser.Name = "tbFirstNameUser";
            this.tbFirstNameUser.Size = new System.Drawing.Size(240, 23);
            this.tbFirstNameUser.TabIndex = 9;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // lbAvailableAwards
            // 
            this.lbAvailableAwards.FormattingEnabled = true;
            this.lbAvailableAwards.ItemHeight = 15;
            this.lbAvailableAwards.Location = new System.Drawing.Point(287, 216);
            this.lbAvailableAwards.Name = "lbAvailableAwards";
            this.lbAvailableAwards.Size = new System.Drawing.Size(186, 184);
            this.lbAvailableAwards.TabIndex = 21;
            this.lbAvailableAwards.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbAvailableAwards_MouseDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(325, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Available Awards";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(81, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "UserAwards";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(223, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 54);
            this.label5.TabIndex = 18;
            this.label5.Text = "←";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label4.Location = new System.Drawing.Point(223, 216);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(58, 54);
            this.Label4.TabIndex = 17;
            this.Label4.Text = "→";
            // 
            // lbUserAwards
            // 
            this.lbUserAwards.FormattingEnabled = true;
            this.lbUserAwards.ItemHeight = 15;
            this.lbUserAwards.Location = new System.Drawing.Point(31, 216);
            this.lbUserAwards.Name = "lbUserAwards";
            this.lbUserAwards.Size = new System.Drawing.Size(186, 184);
            this.lbUserAwards.TabIndex = 16;
            this.lbUserAwards.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbUserAwards_MouseDoubleClick);
            // 
            // UserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 464);
            this.Controls.Add(this.lbAvailableAwards);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.lbUserAwards);
            this.Controls.Add(this.tbBitrhDateUser);
            this.Controls.Add(this.btnSaveEditedUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLastNameUser);
            this.Controls.Add(this.tbFirstNameUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserEdit";
            this.Load += new System.EventHandler(this.UserEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker tbBitrhDateUser;
        private System.Windows.Forms.Button btnSaveEditedUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLastNameUser;
        private System.Windows.Forms.TextBox tbFirstNameUser;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ListBox lbAvailableAwards;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.ListBox lbUserAwards;
    }
}