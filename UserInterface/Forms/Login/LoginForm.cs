using KiPKadryIPlace.DataAccessLayer;
using KiPKadryIPlace.UserInterface.Forms.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiPKadryIPlace.UserInterface.Forms.Login
{
    public partial class LoginForm : Form
    {
        #region Fields

        private DBUtilities dbUtilitiesCon;

        #endregion
        #region Constructor

        public LoginForm()
        {
            InitializeComponent();
            dbUtilitiesCon = new DBUtilities();
            GetUserNameFromDB();
        }

        #endregion
        #region Private Methods

        private void GetUserNameFromDB()
        {
            try
            {
                cbUser.Items.Clear();
                DataTable users = dbUtilitiesCon.GetData("select Name from dbo.Users");

                if (users?.Rows?.Count > 0)
                {
                    foreach (DataRow row in users.Rows)
                    {
                        cbUser.Items.Add(row["Name"].ToString());
                    }
                }
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
            }
        }
        
        private string GetUserName(string name)
        {
            try
            {
                var param = new Dictionary<string, string>();
                param.Add("@Name", name);

                string username = dbUtilitiesCon.DataLookUp("Name", "dbo.Users", "Name=@Name", param);

                return username;
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
                return "";
            }
        }

        private string GetPassword(string pass)
        {
            try
            {
                var param = new Dictionary<string, string>();
                param.Add("@Password", pass);

                string password = dbUtilitiesCon.DataLookUp("Password", "dbo.Users", "Password=@Password", param);

                return password;
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
                return "";
            }
        }

        #endregion
        #region Events

        private void btnConfiguration_Click(object sender, EventArgs e)
        {
            ConfigurationForm frm = new ConfigurationForm();
            frm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if((cbUser.Text == GetUserName(cbUser.Text)) && (txtPassword.Text == GetPassword(txtPassword.Text)))
            {
                MainForm frm = new MainForm();
                frm.ShowDialog();
                Dispose();
                Close();
            }
            else
            {
                MessageBox.Show("Nazwa użytkownika lub hasło są nieprawidłowe!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}
