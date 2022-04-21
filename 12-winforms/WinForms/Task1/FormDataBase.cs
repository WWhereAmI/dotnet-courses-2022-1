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
        private BindingList<User> userList = new BindingList<User>();
        private BindingList<Award> awardList = new BindingList<Award>();

        public SortDirection currentSortStep = SortDirection.Asc;

        public FormDataBase()
        {
            InitializeComponent();
        }

        private void FormDataBase_Load(object sender, EventArgs e)
        {
            dgvUsersTable.DataSource = userList;
            dgvAwardsTable.DataSource = awardList;
        }

        private void RefreshInformation<T>(BindingList<T> list, DataGridView view)
        {
            list.ResetBindings();
            view.DataSource = list;
        }

        private void dgvUsersTable_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OrderUserByColumn(userList, e.ColumnIndex);
        }

        private void dgvAwardsTable_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OrderAwardByColumn(awardList, e.ColumnIndex);
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
            UserModify userAdd = new UserModify(new User(), userList, awardList, ModifyRecord.AddNew);
            RefreshInformation(userList, dgvUsersTable);
            userAdd.ShowDialog();
        }

        private void menuEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsersTable.Rows.Count != 0)
            {
                var userToEdit = userList.First(e => e.ID == (int)dgvUsersTable.CurrentRow.Cells[0].Value);

                UserModify userEdit = new UserModify(userToEdit, userList, awardList, ModifyRecord.EditExisting);
                userEdit.ShowDialog();

                RefreshInformation(userList, dgvUsersTable);
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
                var userToDelete = userList.First(e => e.ID == (int)dgvUsersTable.CurrentRow.Cells[0].Value);

                var answer = MessageBox.Show($"Delete { userToDelete.FirstName}?", "Deleting User", MessageBoxButtons.YesNo);

                if (answer == DialogResult.Yes)
                {
                    userList.Remove(userToDelete);
                }
            }
            else
            {
                MessageBox.Show("The table is empty");
            }
        }

        private void menuAddAward_Click(object sender, EventArgs e)
        {
            AwardModify awardAdd = new AwardModify(new Award(), awardList, ModifyRecord.AddNew);
            RefreshInformation(awardList, dgvAwardsTable);
            awardAdd.ShowDialog();
        }

        private void menuEditAward_Click(object sender, EventArgs e)
        {
            if (dgvAwardsTable.Rows.Count != 0)
            {
                var awardToEdit = awardList.First(e => e.ID == (int)dgvAwardsTable.CurrentRow.Cells[0].Value);

                AwardModify awardEdit = new AwardModify(awardToEdit, awardList, ModifyRecord.EditExisting);
                awardEdit.ShowDialog();

                RefreshInformation(awardList, dgvAwardsTable);
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
                var awardToDelete = awardList.First(e => e.ID == (int)dgvAwardsTable?.CurrentRow?.Cells[0]?.Value);

                var answer = MessageBox.Show($"Delete { awardToDelete.Title}?", "Deleting Award", MessageBoxButtons.YesNo);

                if (answer == DialogResult.Yes)
                {
                    awardList.Remove(awardToDelete);

                    CascadeDeleteAwards(awardToDelete);
                }
            }
            else
            {
                MessageBox.Show("The table is empty");
            }
        }

        private void CascadeDeleteAwards(Award awardToDelete)
        {
            foreach (var user in userList)
            {
                user.UserAwards.Remove(awardToDelete);
            }
        }
    }

}
