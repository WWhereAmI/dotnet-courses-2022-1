using System;
using System.ComponentModel;
using System.Windows.Forms;
using Entities;
using BLL.Main;
using Interfaces;

namespace Task1
{
    public partial class UserModify : Form
    {
        private IAwardBL awardBL;
        private IPersonBL personBL;

        private User user;
        private ModifyRecord workMode;
    
        public UserModify(IPersonBL personBL, IAwardBL awardBL)
        {
            InitializeComponent();

            workMode = ModifyRecord.AddNew;

            this.personBL = personBL;
            this.awardBL = awardBL;    
            
            user = new User();
        }

        public UserModify(IPersonBL personBL, IAwardBL awardBL, int userID)
        {
            InitializeComponent();

            workMode = ModifyRecord.EditExisting;
            
            this.personBL = personBL;
            this.awardBL = awardBL;

            user = personBL.GetUser(userID);

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
                    personBL.AddUser(user);       
                }
                else if (workMode == ModifyRecord.EditExisting)
                {
                    user.UserAwards.Clear();
                }

                //Adding awards from UI
                foreach (var award in lbUserAwards.Items)
                {
                    if (award is Award newAward)
                    {                       
                        personBL.AddUserAward(user, newAward);
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

                foreach (var award in awardBL.GetAll())
                {
                    lbAvailableAwards.Items.Add(award);
                }
            }
            else if (workMode == ModifyRecord.EditExisting)
            {
                btnModifyUser.Text = "Save Changes";

                tbFirstNameUser.Text = user.FirstName;
                tbLastNameUser.Text = user.LastName;
                tbBitrhDateUser.Value = user.BirthDate;

                foreach (Award award in awardBL.GetAll())
                {
                    if (user.UserAwards.Contains(award))
                    {
                        lbUserAwards.Items.Add(award);
                    }
                    else
                    {
                        lbAvailableAwards.Items.Add(award);
                    }
                }
            }
        }
    }
}
