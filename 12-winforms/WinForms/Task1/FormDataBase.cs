using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Task1
{
    public enum SortDirection
    {
        asc,
        desc
    }

    public partial class FormDataBase : Form
    {
        private BindingList<User> userList = new BindingList<User>();
        private BindingList<Award> awardList = new BindingList<Award>();

        public SortDirection currentSortStep = SortDirection.asc;

        public FormDataBase()
        {
            InitializeComponent();

            menuExport.Enabled = false;
        }

        private void FormDataBase_Load(object sender, EventArgs e)
        {
            dgvUsersTable.DataSource = userList;
            dgvAwardsTable.DataSource = awardList;
        }

        private void menuImport_Click(object sender, EventArgs e)
        {
            userList = InformationDeserelization<User>.DeserilizeJson(ConfigurationManager.AppSettings["UserTable"]);
            awardList = InformationDeserelization<Award>.DeserilizeJson(ConfigurationManager.AppSettings["AwardTable"]);

            RefreshInformation(userList, dgvUsersTable);
            RefreshInformation(awardList, dgvAwardsTable);

            menuExport.Enabled = true;

            User.GUID = userList.Count + 1;
            Award.GUID = awardList.Count + 1;

        }

        private void RefreshInformation<T>(BindingList<T> list, DataGridView view)
        {
            list.ResetBindings();
            view.DataSource = list;
        }

        private void menuExport_Click(object sender, EventArgs e)
        {
            InformationSerelization<User>.SerelizeList(userList, ConfigurationManager.AppSettings["UserTable"]);
            InformationSerelization<Award>.SerelizeList(awardList, ConfigurationManager.AppSettings["AwardTable"]);
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
                    case 4:
                        sortRule = e => e.Age;
                        break;
                    case 5:
                        sortRule = e => e.UserAwardsList;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                if (currentSortStep == SortDirection.asc)
                {
                    var list = userList.OrderByDescending(sortRule).ToList();
                    userList = new BindingList<User>(list);
                    RefreshInformation(userList, dgvUsersTable);
                    currentSortStep = SortDirection.desc;
                }
                else
                {
                    var list = userList.OrderBy(sortRule).ToList();
                    userList = new BindingList<User>(list);
                    RefreshInformation(userList, dgvUsersTable);
                    currentSortStep = SortDirection.asc;
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

                if (currentSortStep == SortDirection.asc)
                {
                    var list = awardList.OrderByDescending(sortRule).ToList();
                    awardList = new BindingList<Award>(list);
                    RefreshInformation(awardList, dgvAwardsTable);
                    currentSortStep = SortDirection.desc;
                }
                else
                {
                    var list = awardList.OrderBy(sortRule).ToList();
                    awardList = new BindingList<Award>(list);
                    RefreshInformation(awardList, dgvAwardsTable);
                    currentSortStep = SortDirection.asc;
                }
            }
        }

        private void menuAddUser_Click(object sender, EventArgs e)
        {
            menuExport.Enabled = true;

            UserAdd userAdd = new UserAdd(userList, awardList);
            userAdd.ShowDialog();
        }

        private void menuEditUser_Click(object sender, EventArgs e)
        {
            var userToEdit = userList.First(e => e.ID == (int)dgvUsersTable.CurrentRow.Cells[0].Value);

            UserEdit userEdit = new UserEdit(userToEdit, awardList);
            userEdit.ShowDialog();

            RefreshInformation(userList, dgvUsersTable);
        }

        private void menuDeleteUser_Click(object sender, EventArgs e)
        {
            var userToDelete = userList.First(e => e.ID == (int)dgvUsersTable.CurrentRow.Cells[0].Value);

            var answer = MessageBox.Show($"Delete { userToDelete.FirstName}?", "Deleting User", MessageBoxButtons.YesNo);

            if (answer == DialogResult.Yes)
            {
                userList.Remove(userToDelete);
            }
        }

        private void menuAddAward_Click(object sender, EventArgs e)
        {
            menuExport.Enabled = true;

            AwardAdd awardAdd = new AwardAdd(awardList);
            awardAdd.ShowDialog();
        }

        private void menuEditAward_Click(object sender, EventArgs e)
        {
            var awardToEdit = awardList.First(e => e.ID == (int)dgvAwardsTable.CurrentRow.Cells[0].Value);

            AwardEdit awardEdit = new AwardEdit(awardToEdit);
            awardEdit.ShowDialog();

            RefreshInformation(awardList, dgvAwardsTable);
        }

        private void menuDeleteAward_Click(object sender, EventArgs e)
        {
            var awardToDelete = awardList.First(e => e.ID == (int)dgvAwardsTable.CurrentRow.Cells[0].Value);

            var answer = MessageBox.Show($"Delete { awardToDelete.Title}?", "Deleting Award", MessageBoxButtons.YesNo);

            if (answer == DialogResult.Yes)
            {
                awardList.Remove(awardToDelete);

                CascadeDeleteAwards(awardToDelete);
            }
        }

        private void CascadeUpdateAwards(Award awardToEdit)
        {
            foreach (var user in userList)
            {
                user.UserAwards.Remove(awardToEdit);
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
