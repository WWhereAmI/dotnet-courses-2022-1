using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Task1
{
    public partial class AwardAdd : Form
    {
        private IBindingList awardList;
        public AwardAdd(IBindingList awardList)
        {
            InitializeComponent();
            this.awardList = awardList;
        }

        private void btnAddAward_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (IsEnititesIsValid())
            {
                awardList.Add(new Award(tbTitleAward.Text, tbDescriptionAward.Text));

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
