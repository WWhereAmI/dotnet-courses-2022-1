namespace Task1
{
    partial class AwardModify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AwardModify));
            this.btnModifyAward = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescriptionAward = new System.Windows.Forms.TextBox();
            this.tbTitleAward = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModifyAward
            // 
            this.btnModifyAward.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnModifyAward.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModifyAward.Location = new System.Drawing.Point(0, 187);
            this.btnModifyAward.Name = "btnModifyAward";
            this.btnModifyAward.Size = new System.Drawing.Size(514, 47);
            this.btnModifyAward.TabIndex = 14;
            this.btnModifyAward.Text = "Add Award";
            this.btnModifyAward.UseVisualStyleBackColor = true;
            this.btnModifyAward.Click += new System.EventHandler(this.btnModifyAward_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Title";
            // 
            // tbDescriptionAward
            // 
            this.tbDescriptionAward.Location = new System.Drawing.Point(138, 73);
            this.tbDescriptionAward.MaxLength = 250;
            this.tbDescriptionAward.Multiline = true;
            this.tbDescriptionAward.Name = "tbDescriptionAward";
            this.tbDescriptionAward.Size = new System.Drawing.Size(304, 80);
            this.tbDescriptionAward.TabIndex = 10;
            // 
            // tbTitleAward
            // 
            this.tbTitleAward.Location = new System.Drawing.Point(138, 15);
            this.tbTitleAward.MaxLength = 50;
            this.tbTitleAward.Name = "tbTitleAward";
            this.tbTitleAward.Size = new System.Drawing.Size(304, 23);
            this.tbTitleAward.TabIndex = 9;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // AwardModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 234);
            this.Controls.Add(this.btnModifyAward);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescriptionAward);
            this.Controls.Add(this.tbTitleAward);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AwardModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AwardAdd";
            this.Load += new System.EventHandler(this.AwardModify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnModifyAward;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescriptionAward;
        private System.Windows.Forms.TextBox tbTitleAward;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}