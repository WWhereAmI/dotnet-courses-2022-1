using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Task1
{
    public partial class AwardModify : Form
    {
        private IBindingList awardList;
        private Award award;
        private ModifyRecord workMode;

        public AwardModify(Award award, IBindingList awardList, ModifyRecord workMode)
        {
            InitializeComponent();

            this.awardList = awardList;        
            this.award = award;

            this.workMode = workMode;
        }

        private void btnModifyAward_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (IsEnititesIsValid())
            {
                award.Title = tbTitleAward.Text;
                award.Description = tbDescriptionAward.Text;

                if (workMode == ModifyRecord.AddNew)
                {                 
                    awardList.Add(award);
                }


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

        private void AwardModify_Load(object sender, EventArgs e)
        {
            if (workMode == ModifyRecord.AddNew)
            {
                btnModifyAward.Text = "Add new";
            }
            else if(workMode == ModifyRecord.EditExisting)
            {
                tbTitleAward.Text = award.Title;
                tbDescriptionAward.Text = award.Description;
                btnModifyAward.Text = "Save changes";
            }
        }
    }
}
