using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Task1
{
    public partial class UserEdit : Form
    {
        private User userToEdit;

        private IBindingList awards;
        public UserEdit(User userToEdit, IBindingList awards)
        {
            InitializeComponent();

            this.userToEdit = userToEdit;
            this.awards = awards;
        }

        private void UserEdit_Load(object sender, EventArgs e)
        {
            tbFirstNameUser.Text = userToEdit.FirstName;
            tbLastNameUser.Text = userToEdit.LastName;
            tbBitrhDateUser.Value = userToEdit.BirthDate;

            foreach (Award item in awards)
            {
                if (userToEdit.UserAwards.Contains(item))
                {
                    lbUserAwards.Items.Add(item);
                }
                else
                {
                    lbAvailableAwards.Items.Add(item);
                }
            }
        }

        private void btnSaveEditedUser_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (IsEnititesValid())
            {
                userToEdit.FirstName = tbFirstNameUser.Text;
                userToEdit.LastName = tbLastNameUser.Text;
                userToEdit.BirthDate = tbBitrhDateUser.Value;

                //Adding awards
                userToEdit.UserAwards.Clear();

                foreach (var item in lbUserAwards.Items)
                {
                    if (item is Award newAward)
                    {
                        userToEdit.UserAwards.Add(newAward);
                    }
                }
                Close();
            }
        }

        private bool IsEnititesValid()
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

        private void lbUserAwards_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbUserAwards.SelectedItems != null)
            {
                lbAvailableAwards.Items.Add(lbUserAwards.SelectedItem);
                lbUserAwards.Items.Remove(lbUserAwards.SelectedItem);
            }
        }

        private void lbAvailableAwards_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbAvailableAwards.SelectedItem != null)
            {
                lbUserAwards.Items.Add(lbAvailableAwards.SelectedItem);
                lbAvailableAwards.Items.Remove(lbAvailableAwards.SelectedItem);
            }
        }
    }
}
