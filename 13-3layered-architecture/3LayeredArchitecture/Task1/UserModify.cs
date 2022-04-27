using System;
using System.ComponentModel;
using System.Windows.Forms;
using Entities;
using BLL.Main;

namespace Task1
{
    public partial class UserModify : Form
    {
        private User user;
        private ModifyRecord workMode;

        private int userID;
        private PersonBL personBL;
        private AwardBL awardBL;


        public UserModify(PersonBL personBL, AwardBL awardBL, ModifyRecord workMode = ModifyRecord.AddNew)
        {
            InitializeComponent();

            this.personBL = personBL;
            this.workMode = workMode;
            this.awardBL = awardBL;    
            

            user = new User();
        }

        public UserModify(PersonBL personBL, AwardBL awardBL, int userID, ModifyRecord workMode = ModifyRecord.EditExisting)
        {
            InitializeComponent();

            this.workMode = workMode;
            this.personBL = personBL;
            this.awardBL = awardBL;

            this.userID = userID;

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

                foreach (var item in awardBL.GetAll())
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

                foreach (Award item in personBL.GetUserAwards(userID))
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
