using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class FormDataBase : Form
    {
        private BindingList<User> userList = new BindingList<User>();
        private BindingList<Award> awardList = new BindingList<Award>();

        public FormDataBase()
        {
            InitializeComponent();

            #region for tests
            //userList.Add(new User(1, "Alexander", "Pshenichnikov", new DateTime(2000, 07, 04)));
            //userList.Add(new User(2, "Maxim", "Prohorov", new DateTime(1995, 03, 04)));

            //awardList.Add(new Award(1, "The best", "For the best men role"));
            //awardList.Add(new Award(2, "The worst", "For the worst men role"));
            #endregion
        }

        private void FormDataBase_Load(object sender, EventArgs e)
        {         
            dgvUsersTable.DataSource = userList;
            dgvAwardsTable.DataSource = awardList;
        }

        private void menuImport_Click(object sender, EventArgs e)
        {
            userList.ResetBindings();
            awardList.ResetBindings();

            userList = InformationDeserelization<User>.DeserilizeJson("Users.json");
            awardList = InformationDeserelization<Award>.DeserilizeJson("Awards.json");
            
            dgvUsersTable.DataSource = userList;
            dgvAwardsTable.DataSource = awardList;
                
        }

        private void menuExport_Click(object sender, EventArgs e)
        {
            InformationSerelization<User>.SerelizeList(userList, "Users.json");
            InformationSerelization<Award>.SerelizeList(awardList, "Awards.json");
        }
    }
}
