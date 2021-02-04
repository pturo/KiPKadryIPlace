using KiPKadryIPlace.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiPKadryIPlace.UserInterface.Forms.Users
{
    public partial class EditUserForm : Form
    {
        #region Fields

        private DBUtilities dbUtilitiesCon;

        #endregion
        #region Constructor

        public EditUserForm(int userId)
        {
            InitializeComponent();
            dbUtilitiesCon = new DBUtilities();
            GetUserFromDB(userId);
        }

        #endregion
        #region Private Methods

        private void GetUserFromDB(int userId)
        {
            try
            {
                string query = "select dbo.Users.ID, LastName, FirstName, EmailAddress, Name, Password, IsAdministrator from dbo.Users where dbo.Users.ID = @ID";
                DataTable userData = dbUtilitiesCon.GetData(query, new Dictionary<string, string> { { "@ID", Convert.ToString(userId) } });

                if(userData?.Rows?.Count > 0)
                {
                    foreach(DataRow row in userData.Rows)
                    {
                        txtID.Text = row["ID"].ToString();
                        txtLastName.Text = row["LastName"].ToString();
                        txtFirstName.Text = row["FirstName"].ToString();
                        txtEmailAddress.Text = row["EmailAddress"].ToString();
                        txtName.Text = row["Name"].ToString();
                        txtPassword.Text = row["Password"].ToString();
                        chbAdmin.Checked = Convert.ToBoolean(row["IsAdministrator"]);
                    }
                }
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
            }
        }

        private bool ValidateForm()
        {
            StringBuilder sbErrorMessage = new StringBuilder();

            string lastNameErrorMessage = eLastName.GetError(txtLastName);
            if (!string.IsNullOrEmpty(lastNameErrorMessage))
            {
                sbErrorMessage.Append(lastNameErrorMessage);
            }

            string firstNameErrorMessage = eFirstName.GetError(txtFirstName);
            if (!string.IsNullOrEmpty(firstNameErrorMessage))
            {
                sbErrorMessage.Append(firstNameErrorMessage);
            }

            string emailAddressErrorMessage = eEmailAddress.GetError(txtLastName);
            if (!string.IsNullOrEmpty(lastNameErrorMessage))
            {
                sbErrorMessage.Append(emailAddressErrorMessage);
            }

            string nameErrorMessage = eName.GetError(txtFirstName);
            if (!string.IsNullOrEmpty(firstNameErrorMessage))
            {
                sbErrorMessage.Append(nameErrorMessage);
            }

            string passwordErrorMessage = ePassword.GetError(txtLastName);
            if (!string.IsNullOrEmpty(lastNameErrorMessage))
            {
                sbErrorMessage.Append(passwordErrorMessage);
            }

            string adminErrorMessage = eAdmin.GetError(txtFirstName);
            if (!string.IsNullOrEmpty(firstNameErrorMessage))
            {
                sbErrorMessage.Append(adminErrorMessage);
            }

            if (sbErrorMessage.Length > 0)
            {
                MessageBox.Show(sbErrorMessage.ToString(), "Modyfikowanie pracownika", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        #endregion
        #region Events

        private void btnSaveAndSend_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                // SQL

                var param = new Dictionary<string, string>();
                param.Add("@ID", txtID.Text);
                param.Add("@LastName", txtLastName.Text);
                param.Add("@FirstName", txtFirstName.Text);
                param.Add("@EmailAddress", txtEmailAddress.Text);
                param.Add("@Name", txtName.Text);
                param.Add("@Password", txtPassword.Text);
                param.Add("@IsAdministrator", chbAdmin.Checked.ToString());

                string query = "update dbo.Users set LastName = @LastName, FirstName = @FirstName, EmailAddress = @EmailAddress, " +
                    "Name = @Name, Password = @Password, IsAdministrator = @IsAdministrator where dbo.Users.ID = @ID";

                int result = dbUtilitiesCon.ExecuteQuery(query, param);
                if(result > 0)
                {
                    MessageBox.Show("Pomyślnie zmodyfikowano dane użytkownika!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd podczas zapisywania zmodufikowanych danych do bazy!");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
