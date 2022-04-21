namespace Task1
{
    partial class UserModify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserModify));
            this.tbFirstNameUser = new System.Windows.Forms.TextBox();
            this.tbLastNameUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBitrhDateUser = new System.Windows.Forms.DateTimePicker();
            this.btnModifyUser = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbUserAwards = new System.Windows.Forms.ListBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbAvailableAwards = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFirstNameUser
            // 
            resources.ApplyResources(this.tbFirstNameUser, "tbFirstNameUser");
            this.tbFirstNameUser.Name = "tbFirstNameUser";
            // 
            // tbLastNameUser
            // 
            resources.ApplyResources(this.tbLastNameUser, "tbLastNameUser");
            this.tbLastNameUser.Name = "tbLastNameUser";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tbBitrhDateUser
            // 
            resources.ApplyResources(this.tbBitrhDateUser, "tbBitrhDateUser");
            this.tbBitrhDateUser.Name = "tbBitrhDateUser";
            // 
            // btnModifyUser
            // 
            resources.ApplyResources(this.btnModifyUser, "btnModifyUser");
            this.btnModifyUser.Name = "btnModifyUser";
            this.btnModifyUser.UseVisualStyleBackColor = true;
            this.btnModifyUser.Click += new System.EventHandler(this.btnModifyUser_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            resources.ApplyResources(this.errorProvider, "errorProvider");
            // 
            // lbUserAwards
            // 
            this.lbUserAwards.FormattingEnabled = true;
            resources.ApplyResources(this.lbUserAwards, "lbUserAwards");
            this.lbUserAwards.Name = "lbUserAwards";
            this.lbUserAwards.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbUserAwards_MouseDoubleClick);
            // 
            // Label4
            // 
            resources.ApplyResources(this.Label4, "Label4");
            this.Label4.Name = "Label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // lbAvailableAwards
            // 
            this.lbAvailableAwards.FormattingEnabled = true;
            resources.ApplyResources(this.lbAvailableAwards, "lbAvailableAwards");
            this.lbAvailableAwards.Name = "lbAvailableAwards";
            this.lbAvailableAwards.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbAvailableAwards_MouseDoubleClick);
            // 
            // UserModify
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbAvailableAwards);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.lbUserAwards);
            this.Controls.Add(this.tbBitrhDateUser);
            this.Controls.Add(this.btnModifyUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLastNameUser);
            this.Controls.Add(this.tbFirstNameUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UserModify";
            this.Load += new System.EventHandler(this.UserModify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbFirstNameUser;
        private System.Windows.Forms.TextBox tbLastNameUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker tbBitrhDateUser;
        private System.Windows.Forms.Button btnModifyUser;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.ListBox lbUserAwards;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbAvailableAwards;
    }
}