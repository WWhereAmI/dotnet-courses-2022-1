using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Task1
{
    public partial class UserAdd : Form
    {
        private IBindingList users;

        private IBindingList awards;

        public UserAdd(IBindingList users, IBindingList awards)
        {
            InitializeComponent();

            this.awards = awards;
            this.users = users;

            InitialAvailableAwardsList();
        }

        private void InitialAvailableAwardsList()
        {
            foreach (var item in awards)
            {
                lbAvailableAwards.Items.Add(item);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (IsEnititesIsValid())
            {
                User newUser = new User(tbFirstNameUser.Text, tbLastNameUser.Text, DateTime.Parse(tbBitrhDateUser.Text));

                users.Add(newUser);

                //Adding awards
                foreach (var item in lbUserAwards.Items)
                {
                    if (item is Award newAward)
                    {
                        newUser.UserAwards.Add(newAward);
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
    }
}
