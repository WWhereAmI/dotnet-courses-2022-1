namespace Task1
{
    partial class AwardEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AwardEdit));
            this.btnSaveEditedAward = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescriptionAward = new System.Windows.Forms.TextBox();
            this.tbTitleAward = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveEditedAward
            // 
            this.btnSaveEditedAward.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSaveEditedAward.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSaveEditedAward.Location = new System.Drawing.Point(0, 155);
            this.btnSaveEditedAward.Name = "btnSaveEditedAward";
            this.btnSaveEditedAward.Size = new System.Drawing.Size(517, 47);
            this.btnSaveEditedAward.TabIndex = 19;
            this.btnSaveEditedAward.Text = "Save Changes";
            this.btnSaveEditedAward.UseVisualStyleBackColor = true;
            this.btnSaveEditedAward.Click += new System.EventHandler(this.btnSaveEditedAward_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Title";
            // 
            // tbDescriptionAward
            // 
            this.tbDescriptionAward.Location = new System.Drawing.Point(138, 66);
            this.tbDescriptionAward.MaxLength = 250;
            this.tbDescriptionAward.Multiline = true;
            this.tbDescriptionAward.Name = "tbDescriptionAward";
            this.tbDescriptionAward.Size = new System.Drawing.Size(304, 69);
            this.tbDescriptionAward.TabIndex = 16;
            // 
            // tbTitleAward
            // 
            this.tbTitleAward.Location = new System.Drawing.Point(138, 8);
            this.tbTitleAward.MaxLength = 50;
            this.tbTitleAward.Name = "tbTitleAward";
            this.tbTitleAward.Size = new System.Drawing.Size(304, 23);
            this.tbTitleAward.TabIndex = 15;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // AwardEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 202);
            this.Controls.Add(this.btnSaveEditedAward);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescriptionAward);
            this.Controls.Add(this.tbTitleAward);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AwardEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AwardEdit";
            this.Load += new System.EventHandler(this.AwardEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveEditedAward;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescriptionAward;
        private System.Windows.Forms.TextBox tbTitleAward;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}