using BLL.Main;
using System;
using System.Windows.Forms;
using Interfaces;

namespace Task1
{
    public enum ModifyRecord
    {
        AddNew,
        EditExisting
    }

    public partial class FormDataBase : Form
    {
        private IPersonBL personBL;
        private IAwardBL awardBL;

        public FormDataBase(IPersonBL personBL, IAwardBL awardBL)
        {
            InitializeComponent();

            this.personBL = personBL;
            this.awardBL = awardBL;
        }

        private void FormDataBase_Load(object sender, EventArgs e)
        {
            RefreshInformation();
        }

        private void RefreshInformation()
        {
            dgvUsersTable.DataSource = personBL.GetAll();
            dgvAwardsTable.DataSource = awardBL.GetAll();
        }

        private void dgvUsersTable_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvUsersTable.DataSource = personBL.OrderUserByField(e.ColumnIndex);
        }

        private void dgvAwardsTable_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvAwardsTable.DataSource = awardBL.OrderAwardByField(e.ColumnIndex);           
        }

        private void menuAddUser_Click(object sender, EventArgs e)
        {
            UserModify userAdd = new UserModify(personBL, awardBL);

            userAdd.ShowDialog();

            RefreshInformation();
        }

        private void menuEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsersTable.Rows.Count != 0)
            {
                int userID = (int)dgvUsersTable.CurrentRow.Cells[0].Value;

                UserModify userEdit = new UserModify(personBL, awardBL, userID);

                userEdit.ShowDialog();

                RefreshInformation();
            }
            else
            {
                MessageBox.Show("The table is empty");
            }
        }

        private void menuDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsersTable.Rows.Count != 0)
            {
                int userID = (int)dgvUsersTable.CurrentRow.Cells[0].Value;

                var userToDelete = personBL.GetUser(userID);

                var answer = MessageBox.Show($"Delete { userToDelete.FirstName}?", "Deleting User", MessageBoxButtons.YesNo);

                if (answer == DialogResult.Yes)
                {
                    personBL.RemoveUser(userToDelete);
                }

                RefreshInformation();
            }
            else
            {
                MessageBox.Show("The table is empty");
            }
        }

        private void menuAddAward_Click(object sender, EventArgs e)
        {
            AwardModify awardAdd = new AwardModify(awardBL);

            awardAdd.ShowDialog();

            RefreshInformation();
        }

        private void menuEditAward_Click(object sender, EventArgs e)
        {
            if (dgvAwardsTable.Rows.Count != 0)
            {
                int currentID = (int)dgvAwardsTable.CurrentRow.Cells[0].Value;

                AwardModify awardEdit = new AwardModify(awardBL, currentID);
                awardEdit.ShowDialog();

                RefreshInformation();
            }
            else
            {
                MessageBox.Show("The table is empty");
            }

        }

        private void menuDeleteAward_Click(object sender, EventArgs e)
        {
            if (dgvAwardsTable.Rows.Count != 0)
            {
                int currentID = (int)dgvAwardsTable.CurrentRow.Cells[0].Value;
                var awardToDelete = awardBL.GetAward(currentID);

                var answer = MessageBox.Show($"Delete { awardToDelete.Title}?", "Deleting Award", MessageBoxButtons.YesNo);

                if (answer == DialogResult.Yes)
                {
                    awardBL.RemoveAward(awardToDelete, personBL);
                }

                RefreshInformation();
            }
            else
            {
                MessageBox.Show("The table is empty");
            }
        }
    }

}
