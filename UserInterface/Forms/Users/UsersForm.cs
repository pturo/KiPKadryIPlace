using KiPKadryIPlace.DataAccessLayer;
using KiPKadryIPlace.DataAccessLayer.ViewModels;
using KiPKadryIPlace.UserInterface.Forms.Employees.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace KiPKadryIPlace.UserInterface.Forms.Users
{
    public partial class UsersForm : BaseForm
    {
        #region Fields

        private static UsersForm _instance = null;
        private int userId;
        private static BindingList<UserViewModel> sqlUsr = new BindingList<UserViewModel>();
        private DBUtilities dbUtilitiesCon;

        #endregion
        #region Properties

        public static UsersForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UsersForm();
                }
                return _instance;
            }
        }

        public static bool IsNull
        {
            get
            {
                if (_instance == null)
                {
                    return true;
                }
                return false;
            }
        }

        #endregion
        #region Constructor

        public UsersForm()
        {
            InitializeComponent();
            GetUsersFromDB();
        }

        #endregion
        #region Private Methods

        private void GetUsersFromDB()
        {
            dbUtilitiesCon = new DBUtilities();
            DataTable dt = dbUtilitiesCon.GetData("select dbo.Users.ID, LastName, FirstName, EmailAddress, Name, IsAdministrator from dbo.Users order by dbo.Users.ID;");

            if (dt?.Rows?.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    sqlUsr.Add(new UserViewModel()
                    {
                        Id = Convert.ToInt32(row["ID"]),
                        LastName = row["LastName"].ToString(),
                        FirstName = row["FirstName"].ToString(),
                        EmailAddress = row["EmailAddress"].ToString(),
                        Name = row["Name"].ToString(),
                        Administrator = row["IsAdministrator"].ToString()
                    });

                    var source = new BindingSource(sqlUsr, null);
                    dgvUsers.DataSource = source;
                }
            }
        }

        private void DeleteUserFromDB(int userId)
        {
            try
            {
                string query = "delete from dbo.Users where dbo.Users.ID = @ID;";
                var param = new Dictionary<string, string>();
                param.Add("ID", Convert.ToString(userId));
                int result = dbUtilitiesCon.ExecuteQuery(query, param);
                if (result > 0)
                {
                    MessageBox.Show("Pomyślnie usunięto użytkownika z bazy!");
                    RefreshData();
                }
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
                MessageBox.Show("Wystąpił problem podczas usuwania użytkownika z bazy!");
            }
        }

        private void RefreshData()
        {
            dgvUsers.Rows.Clear();
            GetUsersFromDB();
        }

        #endregion
        #region Events

        private void UsersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AddUserForm frm = new AddUserForm();
            frm.ShowDialog();
            RefreshData();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["colId"].Value);

            EditUserForm frm = new EditUserForm(userId);
            frm.ShowDialog();
            RefreshData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["colId"].Value);

            DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć użytkownika?", "Usuwanie użytkownika",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                DeleteUserFromDB(userId);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        #endregion
    }
}
