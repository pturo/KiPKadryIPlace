using KiPKadryIPlace.DataAccessLayer;
using KiPKadryIPlace.UserInterface.Extensions;
using KiPKadryIPlace.UserInterface.Forms.Employees.Base;
using KiPKadryIPlace.UserInterface.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace KiPKadryIPlace.UserInterface.Forms.Employees
{
    public partial class EmployeeEditForm : BaseAddEditForm
    {
        #region Fields

        private DBUtilities dbUtilitiesCon;

        #endregion
        #region Constructor

        public EmployeeEditForm(int employeeId)
        {
            InitializeComponent();
            dbUtilitiesCon = new DBUtilities();
            LoadGender();
            GetEmployeeFromDB(employeeId);
            ValidateControls();
        }

        #endregion
        #region Private Methods

        private void GetEmployeeFromDB(int employeeId)
        {
            try
            {
                string query = "select dbo.Employees.ID, LastName, FirstName, Code, g.Value, DateBirth, Pesel, PhoneNumber, EmailAddress, IdentityCardNumber, " +
                        "IssueDateIdentityCard, ExpirationDateIdentityCard, PassportNumber, IssueDatePassport, ExpirationDatePassport from dbo.Employees " +
                        "inner join dbo.Genders g on GenderId = g.ID where dbo.Employees.ID = @ID";
                DataTable employeeData = dbUtilitiesCon.GetData(query, new Dictionary<string, string> { { "@ID", Convert.ToString(employeeId) } });

                if (employeeData?.Rows?.Count > 0)
                {
                    foreach (DataRow row in employeeData.Rows)
                    {
                        txtID.Text = row["ID"].ToString();
                        txtLastName.Text = row["LastName"].ToString();
                        txtFirstName.Text = row["FirstName"].ToString();
                        txtCode.Text = row["Code"].ToString();
                        cbGender.Text = row["Value"].ToString();
                        dtpDateBirth.Value = Convert.ToDateTime(row["DateBirth"]);
                        txtPesel.Text = row["Pesel"].ToString();
                        txtPhoneNumber.Text = row["PhoneNumber"].ToString();
                        txtEmailAddress.Text = row["EmailAddress"].ToString();
                        txtIdentityCardNumber.Text = row["IdentityCardNumber"].ToString();
                        dtpIssueDateIdentityCard.Value = Convert.ToDateTime(row["IssueDateIdentityCard"]);
                        dtpExpirationDateIdentityCard.Value = Convert.ToDateTime(row["ExpirationDateIdentityCard"]);
                        txtPassportNumber.Text = row["PassportNumber"].ToString();
                        dtpIssueDatePassport.Value = Convert.ToDateTime(row["IssueDatePassport"]);
                        dtpExpirationDatePassport.Value = Convert.ToDateTime(row["ExpirationDatePassport"]);
                    }
                }
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
            }
        }

        private void LoadGender()
        {
            try
            {
                cbGender.Items.Clear();
                DataTable genders = dbUtilitiesCon.GetData("select Value from dbo.Genders");

                if (genders?.Rows?.Count > 0)
                {
                    foreach (DataRow row in genders.Rows)
                    {
                        cbGender.Items.Add(row["Value"].ToString());
                    }
                }
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
            }
        }

        private int GetGenderId(string gender)
        {
            try
            {
                int genderId = Convert.ToInt32(dbUtilitiesCon.DataLookUp("ID", "dbo.Genders", "Value='" + gender + "'"));

                return genderId;
            }
            catch (Exception exc)
            {
                string msg = exc.Message;
                return 0;
            }
        }

        private void ValidateControls()
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                epLastName.SetError(txtLastName, "Pole 'Nazwisko' jest wymagane!");
            }
            else
            {
                epLastName.Clear();
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                epFirstName.SetError(txtFirstName, "Pole 'Imię' jest wymagane!");
            }
            else
            {
                epFirstName.Clear();
            }

            if (!string.IsNullOrWhiteSpace(txtPesel.Text) && !ValidatorsHelper.IsValidPESEL(txtPesel.Text))
            {
                epPesel.SetError(txtPesel, "Cyfra kontrolna numeru pesel jest nieprawidłowa!");
            }
            else
            {
                epPesel.Clear();
            }
        }

        private bool ValidateForm()
        {
            StringBuilder sbErrorMessage = new StringBuilder();

            string lastNameErrorMessage = epLastName.GetError(txtLastName);
            if (!string.IsNullOrEmpty(lastNameErrorMessage))
            {
                sbErrorMessage.Append(lastNameErrorMessage);
            }

            string firstNameErrorMessage = epFirstName.GetError(txtFirstName);
            if (!string.IsNullOrEmpty(firstNameErrorMessage))
            {
                sbErrorMessage.Append(firstNameErrorMessage);
            }

            if (sbErrorMessage.Length > 0)
            {
                MessageBox.Show(sbErrorMessage.ToString(), "Dodawanie pracownika", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string peselWarinngMessage = epPesel.GetError(txtPesel);
            if (!string.IsNullOrEmpty(peselWarinngMessage))
            {
                DialogResult answer = MessageBox.Show(peselWarinngMessage + Environment.NewLine + "Czy mimo to chcesz dodać pracownika?", "Dodawanie pracownika", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.No)
                {
                    return false;
                }
            }

            return true;
        }

        #endregion
        #region Events

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            dtp.DateTimePickerValueChanged();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtPesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPesel_Validated(object sender, EventArgs e)
        {
            string pesel = txtPesel.Text;

            if (!string.IsNullOrWhiteSpace(pesel) && !ValidatorsHelper.IsValidPESEL(pesel))
            {
                epPesel.SetError(txtPesel, "Cyfra kontrolna numeru pesel jest nieprawidłowa!");
            }
            else
            {
                epPesel.Clear();
            }
        }

        #endregion
        #region Override

        protected override void Save()
        {
            if (ValidateForm())
            {
                // SQL

                var param = new Dictionary<string, string>();
                param.Add("@ID", txtID.Text);
                param.Add("@LastName", txtLastName.Text);
                param.Add("@FirstName", txtFirstName.Text);
                param.Add("@Code", txtCode.Text);
                param.Add("@GenderId", GetGenderId(cbGender.Text).ToString());
                param.Add("@DateBirth", Convert.ToDateTime(dtpDateBirth.Value).ToString("yyyy-MM-dd"));
                param.Add("@Pesel", txtPesel.Text);
                param.Add("@PhoneNumber", txtPhoneNumber.Text);
                param.Add("@EmailAddress", txtEmailAddress.Text);
                param.Add("@IdentityCardNumber", txtIdentityCardNumber.Text);
                param.Add("@IssueDateIdentityCard", Convert.ToDateTime(dtpIssueDateIdentityCard.Value).ToString("yyyy-MM-dd"));
                param.Add("@ExpirationDateIdentityCard", Convert.ToDateTime(dtpExpirationDateIdentityCard.Value).ToString("yyyy-MM-dd"));
                param.Add("@PassportNumber", txtPassportNumber.Text);
                param.Add("@IssueDatePassport", Convert.ToDateTime(dtpIssueDatePassport.Value).ToString("yyyy-MM-dd"));
                param.Add("@ExpirationDatePassport", Convert.ToDateTime(dtpExpirationDatePassport.Value).ToString("yyyy-MM-dd"));

                string query = "update dbo.Employees set LastName = @LastName, FirstName = @FirstName, Code = @Code, GenderId = @GenderId, DateBirth = @DateBirth, " +
                    "Pesel = @Pesel, PhoneNumber = @PhoneNumber, EmailAddress = @EmailAddress, IdentityCardNumber = @IdentityCardNumber, " +
                    "IssueDateIdentityCard = @IssueDateIdentityCard, ExpirationDateIdentityCard = @ExpirationDateIdentityCard, PassportNumber = @PassportNumber, " +
                    "IssueDatePassport = @IssueDatePassport, ExpirationDatePassport = @ExpirationDatePassport where dbo.Employees.ID = @ID";

                int result = dbUtilitiesCon.ExecuteQuery(query, param);
                if(result > 0)
                {
                    MessageBox.Show("Pomyślnie zmodyfikowano dane pracownika!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Wystąpił błąd podczas zapisywania zmodyfikowanych danych do bazy!");
                }
            }
        }

        protected override void Cancel()
        {
            Close();
        }

        #endregion
    }
}
