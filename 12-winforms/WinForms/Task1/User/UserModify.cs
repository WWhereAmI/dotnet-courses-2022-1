using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Task1
{
    public partial class UserModify : Form
    {
        private IBindingList users;
        private IBindingList awards;
        private User user;
        private ModifyRecord workMode;


        public UserModify(User user, IBindingList users, IBindingList awards, ModifyRecord workMode)
        {
            InitializeComponent();

            this.awards = awards;
            this.users = users;
            this.user = user;

            this.workMode = workMode;
        }


        private void btnModifyUser_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (IsEnititesIsValid())
            {
                user.FirstName = tbFirstNameUser.Text;
                user.LastName = tbLastNameUser.Text;
                user.BirthDate = tbBitrhDateUser.Value;

                if (workMode == ModifyRecord.AddNew)
                { 
                    users.Add(user);       
                }
                else if (workMode == ModifyRecord.EditExisting)
                {
                    user.UserAwards.Clear();
                }

                //Adding awards
                foreach (var award in lbUserAwards.Items)
                {
                    if (award is Award newAward)
                    {
                        user.UserAwards.Add(newAward);
                    }
                }

                Close();
            }
        }

        private bool IsEnititesIsValid()
        {
            if (string.IsNullOrWhiteSpace(tbFirstNameUser.Text))
            {
                errorProvider.SetError(tbFirstNameUser, "This field must be filled in");
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbLastNameUser.Text))
            {
                errorProvider.SetError(tbLastNameUser, "This field must be filled in");
                return false;
            }

            if (tbBitrhDateUser.Value > DateTime.Now || tbBitrhDateUser.Value.Year <= DateTime.Now.Year - 150)
            {
                errorProvider.SetError(tbBitrhDateUser, "Incorrect date value");
                return false;
            }

            return true;
        }

        private void lbAvailableAwards_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbAvailableAwards.SelectedItem != null)
            {
                lbUserAwards.Items.Add(lbAvailableAwards.SelectedItem);
                lbAvailableAwards.Items.Remove(lbAvailableAwards.SelectedItem);
            }
        }

        private void lbUserAwards_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbUserAwards.SelectedItem != null)
            {
                lbAvailableAwards.Items.Add(lbUserAwards.SelectedItem);
                lbUserAwards.Items.Remove(lbUserAwards.SelectedItem);
            }
        }

        private void UserModify_Load(object sender, EventArgs e)
        {
            if (workMode == ModifyRecord.AddNew)
            {
                btnModifyUser.Text = "Add User";

                foreach (var item in awards)
                {
                    lbAvailableAwards.Items.Add(item);
                }
            }
            else if (workMode == ModifyRecord.EditExisting)
            {
                btnModifyUser.Text = "Save Changes";

                tbFirstNameUser.Text = user.FirstName;
                tbLastNameUser.Text = user.LastName;
                tbBitrhDateUser.Value = user.BirthDate;

                foreach (Award item in awards)
                {
                    if (user.UserAwards.Contains(item))
                    {
                        lbUserAwards.Items.Add(item);
                    }
                    else
                    {
                        lbAvailableAwards.Items.Add(item);
                    }
                }
            }
        }
    }
}
