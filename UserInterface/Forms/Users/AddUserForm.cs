using KiPKadryIPlace.DataAccessLayer;
using KiPKadryIPlace.UserInterface.Forms.Employees.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace KiPKadryIPlace.UserInterface.Forms.Users
{
    public partial class AddUserForm : BaseAddEditForm
    {
        #region Fields

        public EventHandler ReloadUsers;
        private DBUtilities dbUtilitiesCon;

        #endregion
        #region Constructor

        public AddUserForm()
        {
            InitializeComponent();
            dbUtilitiesCon = new DBUtilities();
        }

        #endregion
        #region Private Methods

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
                MessageBox.Show(sbErrorMessage.ToString(), "Dodawanie użytkownika", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        #endregion
        #region Events

        private void btnSaveAndSend_Click(object sender, EventArgs e)
        {
            if (ValidateForm()) 
            {
                // SQL

                string query = "insert into dbo.Users (LastName, FirstName, EmailAddress, Name, Password, IsAdministrator) " +
                               "values (@LastName, @FirstName, @EmailAddress, @Name, @Password, @IsAdministrator)";

                var param = new Dictionary<string, string>();
                param.Add("@LastName", txtLastName.Text);
                param.Add("@FirstName", txtFirstName.Text);
                param.Add("@EmailAddress", txtEmailAddress.Text);
                param.Add("@Name", txtName.Text);
                param.Add("@Password", txtPassword.Text);
                param.Add("@IsAdministrator", chbAdmin.Checked.ToString());

                int result = dbUtilitiesCon.ExecuteQuery(query, param);
                if(result > 0)
                {
                    MessageBox.Show("Pomyślnie wprowadzono użytkownika do bazy!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd podczas wprowadzania użytkownika do bazy!");
                }
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        #endregion
    }
}
