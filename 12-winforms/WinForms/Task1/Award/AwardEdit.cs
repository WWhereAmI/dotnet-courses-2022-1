using System;
using System.Windows.Forms;

namespace Task1
{
    public partial class AwardEdit : Form
    {
        private Award awardToEdit;

        public AwardEdit(Award awardToEdit)
        {
            InitializeComponent();

            this.awardToEdit = awardToEdit;
        }

        private void AwardEdit_Load(object sender, EventArgs e)
        {
            tbTitleAward.Text = awardToEdit.Title;
            tbDescriptionAward.Text = awardToEdit.Description;
        }

        private void btnSaveEditedAward_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (IsEnititesIsValid())
            {
                awardToEdit.Title = tbTitleAward.Text;
                awardToEdit.Description = tbDescriptionAward.Text;

                Close();
            }

        }

        private bool IsEnititesIsValid()
        {
            if (string.IsNullOrWhiteSpace(tbTitleAward.Text))
            {
                errorProvider.SetError(tbTitleAward, "This field must be filled in");
                return false;
            }

            return true;
        }
    }
}
