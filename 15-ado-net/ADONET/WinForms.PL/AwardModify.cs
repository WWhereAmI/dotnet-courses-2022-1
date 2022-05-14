using BLL.Main;
using Entities;
using Interfaces;
using System;
using System.Windows.Forms;

namespace Task1
{
    public partial class AwardModify : Form
    {
        private Award award;
        private ModifyRecord workMode;

        private IAwardBL awardBL;


        public AwardModify(IAwardBL awardBL)
        {
            InitializeComponent();

            workMode = ModifyRecord.AddNew;

            this.awardBL = awardBL;

            award = new Award();
        }

        public AwardModify(IAwardBL awardBL, int awardID)
        {
            InitializeComponent();

            workMode = ModifyRecord.EditExisting;

            this.awardBL = awardBL;


            award = awardBL.GetAward(awardID);
        }

        private void btnModifyAward_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (IsEnititesIsValid())
            {                    
                if (workMode == ModifyRecord.AddNew)
                {
                    award.Title = tbTitleAward.Text;
                    award.Description = tbDescriptionAward.Text;

                    awardBL.AddAward(award);
                }
                else if (workMode == ModifyRecord.EditExisting)
                {
                    awardBL.UpdateAward(award.ID, tbTitleAward.Text, tbDescriptionAward.Text);
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
            else if (workMode == ModifyRecord.EditExisting)
            {
                tbTitleAward.Text = award.Title;
                tbDescriptionAward.Text = award.Description;
                btnModifyAward.Text = "Save changes";
            }
        }
    }
}
