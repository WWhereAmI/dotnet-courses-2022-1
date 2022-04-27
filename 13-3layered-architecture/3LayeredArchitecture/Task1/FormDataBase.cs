using BLL.Main;
using Entities;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Task1
{
    public enum SortDirection
    {
        Asc,
        Desc
    }

    public enum ModifyRecord
    {
        AddNew,
        EditExisting
    }

    public partial class FormDataBase : Form
    {

        private PersonBL personBL = new PersonBL();
        private AwardBL awardBL = new AwardBL();



        public SortDirection currentSortStep = SortDirection.Asc;

        public FormDataBase()
        {
            InitializeComponent();
        }

        private void FormDataBase_Load(object sender, EventArgs e)
        {
            dgvUsersTable.DataSource = personBL.GetAll();
            dgvAwardsTable.DataSource = awardBL.GetAll();
        }

        private void RefreshInformation<T>(BindingList<T> list, DataGridView view)
        {
            list.ResetBindings();
            view.DataSource = list;
        }

        private void dgvUsersTable_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OrderUserByColumn(personBL.GetAll(), e.ColumnIndex);
        }

        private void dgvAwardsTable_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OrderAwardByColumn(awardBL.GetAll(), e.ColumnIndex);
        }

        private void OrderUserByColumn<T>(BindingList<T> listToSort, int columnIndex)
        {
            Func<User, dynamic> sortRule;

            if (listToSort is BindingList<User> userList)
            {
                switch (columnIndex)
                {
                    case 0:
                        sortRule = e => e.ID;
                        break;
                    case 1:
                        sortRule = e => e.FirstName;
                        break;
                    case 2:
                        sortRule = e => e.LastName;
                        break;
                    case 3:
                        sortRule = e => e.BirthDate;
                        break;
                    case 4:
                        sortRule = e => e.Age;
                        break;
                    case 5:
                        sortRule = e => e.UserAwardsList;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                if (currentSortStep == SortDirection.Asc)
                {
                    var list = userList.OrderByDescending(sortRule).ToList();
                    userList = new BindingList<User>(list);
                    RefreshInformation(userList, dgvUsersTable);
                    currentSortStep = SortDirection.Desc;
                }
                else
                {
                    var list = userList.OrderBy(sortRule).ToList();
                    userList = new BindingList<User>(list);
                    RefreshInformation(userList, dgvUsersTable);
                    currentSortStep = SortDirection.Asc;
                }
            }
        }

        private void OrderAwardByColumn<T>(BindingList<T> listToSort, int columnIndex)
        {
            Func<Award, dynamic> sortRule;

            if (listToSort is BindingList<Award> awardList)
            {
                switch (columnIndex)
                {
                    case 0:
                        sortRule = e => e.ID;
                        break;
                    case 1:
                        sortRule = e => e.Title;
                        break;
                    case 2:
                        sortRule = e => e.Description;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                if (currentSortStep == SortDirection.Asc)
                {
                    var list = awardList.OrderByDescending(sortRule).ToList();
                    awardList = new BindingList<Award>(list);
                    RefreshInformation(awardList, dgvAwardsTable);
                    currentSortStep = SortDirection.Desc;
                }
                else
                {
                    var list = awardList.OrderBy(sortRule).ToList();
                    awardList = new BindingList<Award>(list);
                    RefreshInformation(awardList, dgvAwardsTable);
                    currentSortStep = SortDirection.Asc;
                }
            }
        }

        private void menuAddUser_Click(object sender, EventArgs e)
        {
            UserModify userAdd = new UserModify(personBL, awardBL);

            RefreshInformation(personBL.GetAll(), dgvUsersTable);

            userAdd.ShowDialog();
        }

        private void menuEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsersTable.Rows.Count != 0)
            {
                int userID = (int)dgvUsersTable.CurrentRow.Cells[0].Value;

                UserModify userEdit = new UserModify(personBL, awardBL, userID);

                userEdit.ShowDialog();

                RefreshInformation(personBL.GetAll(), dgvUsersTable);
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
                    personBL.GetAll().Remove(userToDelete);
                }
            }
            else
            {
                MessageBox.Show("The table is empty");
            }
        }

        private void menuAddAward_Click(object sender, EventArgs e)
        {
            AwardModify awardAdd = new AwardModify(awardBL);

            RefreshInformation(awardBL.GetAll(), dgvAwardsTable);

            awardAdd.ShowDialog();
        }

        private void menuEditAward_Click(object sender, EventArgs e)
        {
            if (dgvAwardsTable.Rows.Count != 0)
            {
                int currentID = (int)dgvAwardsTable.CurrentRow.Cells[0].Value;

                AwardModify awardEdit = new AwardModify(awardBL, currentID, ModifyRecord.EditExisting);
                awardEdit.ShowDialog();

                RefreshInformation(awardBL.GetAll(), dgvAwardsTable);
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
                    awardBL.RemoveAward(awardToDelete);

                    //CascadeDeleteAwards(awardToDelete);
                }
            }
            else
            {
                MessageBox.Show("The table is empty");
            }
        }

        //private void CascadeDeleteAwards(Award awardToDelete)
        //{
        //    foreach (var user in personBL.GetAll())
        //    {
        //        user.UserAwards.Remove(awardToDelete);
        //    }
        //}
    }

}
